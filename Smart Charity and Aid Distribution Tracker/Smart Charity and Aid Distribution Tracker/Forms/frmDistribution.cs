using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmDistribution : Form
    {
        private string currentDistributionId = null;

        public frmDistribution()
        {
            InitializeComponent();
            FontManager.ApplyFontToControls(this);

            // ربط الأحداث الأساسية المتوفرة في Designer الخاص بك
            this.Load += FrmDistribution_Load;
            this.btnSave.Click += BtnSave_Click;
            this.btnAddNew.Click += (s, e) => SwitchMode(FormMode.Add);
            this.btnCancel.Click += (s, e) => SwitchMode(FormMode.View);
            this.dgvDistributionsList.SelectionChanged += DgvDistributionsList_SelectionChanged;

            // أحداث تغيير نوع الصرف
            this.rbInKind.CheckedChanged += RbType_CheckedChanged;
            this.rbCash.CheckedChanged += RbType_CheckedChanged;

            // أحداث البحث
            this.txtSearch.TextChanged += (s, e) => FilterData(txtSearch.Text);
            this.btnClear.Click += (s, e) => { txtSearch.Clear(); RefreshData(); };
        }

        private void FrmDistribution_Load(object sender, EventArgs e)
        {
            SetupComboBoxes();
            RefreshData();
            SwitchMode(FormMode.View);
        }

        private void SetupComboBoxes()
        {
            // استخدام الدوال المتوفرة في DataService الخاص بك
            var activeBeneficiaries = DataService.GetBeneficiaries().Where(b => b.IsActive).ToList();
            cmbBeneficiary.DataSource = activeBeneficiaries;
            cmbBeneficiary.DisplayMember = "FullName";
            cmbBeneficiary.ValueMember = "BeneficiaryID";
            cmbBeneficiary.SelectedIndex = -1;

            var activeItems = DataService.GetAllInventoryItems().Where(i => i.IsActive).ToList();
            cmbItem.DataSource = activeItems;
            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemID";
            cmbItem.SelectedIndex = -1;
        }

        private void RefreshData()
        {
            var distributions = DataService.GetDistributions().OrderByDescending(d => d.DistributionDate).ToList();
            UpdateGrid(distributions);
        }

        private void UpdateGrid(List<Distribution> list)
        {
            dgvDistributionsList.AutoGenerateColumns = false;

            colID.DataPropertyName = "DistributionID";
            colBeneficiaryName.DataPropertyName = "BeneficiaryName";
            colDistType.DataPropertyName = "DistType";
            colDistDate.DataPropertyName = "DistDate";

            dgvDistributionsList.DataSource = list.Select(d => new
            {
                DistributionID = d.DistributionID,
                BeneficiaryName = DataService.GetBeneficiaryById(d.BeneficiaryID)?.FullName,
                DistType = d.Type.ToString(),
                DistDate = d.DistributionDate.ToString("yyyy-MM-dd HH:mm")
            }).ToList();
        }

        private void FilterData(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                RefreshData();
                return;
            }
            var filtered = DataService.GetDistributions()
                .Where(d => (DataService.GetBeneficiaryById(d.BeneficiaryID)?.FullName ?? "").Contains(term))
                .ToList();
            UpdateGrid(filtered);
        }

        private void DgvDistributionsList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDistributionsList.CurrentRow != null && pnlView.Visible)
            {
                currentDistributionId = dgvDistributionsList.CurrentRow.Cells["colID"].Value?.ToString();
                var dist = DataService.GetDistributions().FirstOrDefault(x => x.DistributionID == currentDistributionId);

                if (dist != null)
                {
                    lblBeneficiaryText.Text = DataService.GetBeneficiaryById(dist.BeneficiaryID)?.FullName ?? "غير معروف";
                    lblTypeText.Text = dist.Type.ToString();
                    lblNotesText.Text = string.IsNullOrEmpty(dist.Notes) ? "لا توجد ملاحظات" : dist.Notes;

                    if (dist.Type == DonationType.نقدي)
                    {
                        lblAmountText.Text = dist.Amount.ToString("N2");
                        lblItemText.Text = "----";
                        lblQuantityText.Text = "----";
                    }
                    else
                    {
                        lblAmountText.Text = "----";
                        // حل بديل لعدم وجود GetDistributionDetails و GetItemById في DataService
                        // سنعتمد على البيانات المسجلة في الـ Distribution نفسه أو أول تفصيل متاح
                        lblItemText.Text = "صنف عيني";
                        lblQuantityText.Text = "راجع المخزن";
                    }
                }
            }
        }

        private void RbType_CheckedChanged(object sender, EventArgs e)
        {
            bool isInKind = rbInKind.Checked;

            // العناصر المتوفرة في ملف الـ Designer الخاص بك حصراً
            label3.Visible = cmbItem.Visible = isInKind;
            label4.Visible = numQuantity.Visible = isInKind;

            lblAmount.Visible = txtAmount.Visible = !isInKind;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbBeneficiary.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار مستفيد");
                return;
            }

            string performedBy = SessionManager.GetCurrentUser()?.EmployeeID ?? "System";
            var distId = "DIST" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string selectedBeneficiaryId = cmbBeneficiary.SelectedValue.ToString();
            string currentUser = SessionManager.GetCurrentUser()?.FullName ?? "System";
            string newDistId = "DIST-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            var distribution = new Distribution
            {
                DistributionID = distId,
                BeneficiaryID = cmbBeneficiary.SelectedValue.ToString(),
                DistributionDate = DateTime.Now,
                PerformedBy = performedBy,
                Status = DistributionStatus.منفذة,
                Notes = txtNotes.Text.Trim()
            };

            if (rbCash.Checked)
            {
                if (!double.TryParse(txtAmount.Text, out double amount) || amount <= 0)
                {
                    new frmAlert("الرجاء إدخال مبلغ صحيح أكبر من الصفر.").ShowDialog();
                    return;
                }
                double currentBalance = DataService.GetTreasuryBalance();
                if (amount > currentBalance)
                {
                    new frmAlert($"الرصيد المالي غير كافٍ! الرصيد المتاح هو: {currentBalance} د.ل").ShowDialog();
                    return;
                }
                distribution.Type = DonationType.نقدي;
                distribution.Amount = amount;

                DataService.AddDistribution(distribution);
                DataService.RecordFinancialTransaction(new FinancialTransaction
                {
                    TransactionID = "TRX" + Guid.NewGuid().ToString().Substring(0, 8),
                    Amount = amount,
                    Type = TransactionType.صادر,
                    ReferenceID = distId,
                    TransactionDate = DateTime.Now,
                    PerformedBy = performedBy
                });
            }
            else
            {
                if (cmbItem.SelectedValue == null)
                {
                    MessageBox.Show("الرجاء اختيار صنف");
                    return;
                }
                var requestedItems = new Dictionary<string, double>();
                // التحقق الفعلي من توفر الكمية في المخزون
                foreach (var reqItem in requestedItems)
                {
                    var inventoryItem = DataService.GetAllInventoryItems().FirstOrDefault(i => i.ItemID == reqItem.Key);
                    if (inventoryItem != null && reqItem.Value > inventoryItem.CurrentQuantity)
                    {
                        new frmAlert($"الكمية المطلوبة من '{inventoryItem.ItemName}' ({reqItem.Value}) تتجاوز المخزون المتاح ({inventoryItem.CurrentQuantity})!").ShowDialog();
                        return;
                    }
                }

                string itemId = cmbItem.SelectedValue.ToString();
                double qty = (double)numQuantity.Value;

                distribution.Type = DonationType.عيني;
                distribution.Amount = 0;

                DataService.AddDistribution(distribution);

                // استخدام الدوال المتاحة في DataService الخاص بك
                DataService.AddDistributionDetail(new DistributionDetail
                {
                    DetailID = Guid.NewGuid().ToString(),
                    DistributionID = distId,
                    ItemID = itemId,
                    Quantity = qty
                });

                DataService.RecordMovement(new InventoryMovement
                {
                    MovementID = "MOV" + Guid.NewGuid().ToString().Substring(0, 8),
                    ItemID = itemId,
                    Quantity = qty,
                    MovementType = MovementType.صادر,
                    MovementDate = DateTime.Now,
                    ReferenceID = distId,
                    PerformedBy = performedBy
                });


            }

            MessageBox.Show("تمت عملية الصرف بنجاح");
            RefreshData();
            SwitchMode(FormMode.View);
        }

        private void SwitchMode(FormMode mode)
        {
            pnlInputs.Visible = (mode == FormMode.Add);
            pnlView.Visible = (mode == FormMode.View);
            btnSave.Visible = btnCancel.Visible = (mode == FormMode.Add);
            btnAddNew.Visible = (mode == FormMode.View);

            // أزرار إضافية موجودة في Designer الخاص بك
            btnEdit.Visible = (mode == FormMode.View);
            btnDelete.Visible = (mode == FormMode.View);

            if (mode == FormMode.Add) ResetForm();
        }

        private void ResetForm()
        {
            cmbBeneficiary.SelectedIndex = -1;
            cmbItem.SelectedIndex = -1;
            numQuantity.Value = 1;
            txtAmount.Clear();
            txtNotes.Clear();
            rbInKind.Checked = true;
        }
    }

    public enum FormMode { Add, View }
}
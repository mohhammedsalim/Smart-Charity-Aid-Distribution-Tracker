using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmDistributionReport : Form
    {
        public frmDistributionReport()
        {
            InitializeComponent(); FontManager.ApplyFontToControls(this);
            this.Load += new System.EventHandler(this.frmDistributionReport_Load);
        }

        // --- 1. أحداث تحميل وإغلاق الفورم ---

        private void frmDistributionReport_Load(object sender, EventArgs e)
        {
            // إعداد الفورم عند التحميل
            ResetFilters();
            LoadAndDisplayData();
        }

        private void frmDistributionReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            // عند إغلاق هذه الشاشة، أظهر لوحة التحكم مرة أخرى
            var dashboard = Application.OpenForms.OfType<frmDashBoard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Show();
            }
        }

        // --- 2. تحميل البيانات وتنسيقها ---

        private void LoadAndDisplayData()
        {
            // --- الحصول على البيانات ---
            var allDistributions = DataService.GetAllDistributions();
            var allBeneficiaries = DataService.GetBeneficiaries();

            // --- تطبيق الفلاتر ---
            string searchTerm = txtSearch.Text.Trim().ToLower();
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1); // لنهاية اليوم

            var filteredData = allDistributions
                .Where(d => d.DistributionDate >= startDate && d.DistributionDate <= endDate)
                .Select(d => new
                {
                    Distribution = d,
                    Beneficiary = allBeneficiaries.FirstOrDefault(b => b.BeneficiaryID == d.BeneficiaryID)
                })
                .Where(joined => joined.Beneficiary != null &&
                                 (string.IsNullOrEmpty(searchTerm) || joined.Beneficiary.FullName.ToLower().Contains(searchTerm)))
                .Select(joined => new
                {
                    DistributionID = joined.Distribution.DistributionID,
                    BeneficiaryName = joined.Beneficiary.FullName,
                    DistributionDate = joined.Distribution.DistributionDate,
                    PerformedBy = joined.Distribution.PerformedBy,
                    Status = joined.Distribution.Status.ToString().Replace("_", " ")
                })
                .OrderByDescending(d => d.DistributionDate)
                .ToList();

            // --- عرض البيانات في الجدول الرئيسي ---
            dgvDistributions.DataSource = filteredData;

            // --- تخصيص أعمدة الجدول الرئيسي ---
            if (dgvDistributions.Columns.Count > 0)
            {
                dgvDistributions.Columns["DistributionID"].HeaderText = "رقم العملية";
                dgvDistributions.Columns["BeneficiaryName"].HeaderText = "اسم المستفيد";
                dgvDistributions.Columns["DistributionDate"].HeaderText = "تاريخ التوزيع";
                dgvDistributions.Columns["PerformedBy"].HeaderText = "المنفذ";
                dgvDistributions.Columns["Status"].HeaderText = "الحالة";

                dgvDistributions.Columns["BeneficiaryName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // تفريغ جدول التفاصيل عند كل تحديث
            dgvDetails.Rows.Clear();
        }

        private void DisplayDistributionDetails(string distributionId)
        {
            dgvDetails.Rows.Clear();

            if (string.IsNullOrEmpty(distributionId)) return;

            var distribution = DataService.GetAllDistributions().FirstOrDefault(d => d.DistributionID == distributionId);
            if (distribution == null) return;

            foreach (var detail in distribution.Details)
            {
                var inventoryItem = DataService.GetAllInventoryItems().FirstOrDefault(i => i.ItemID == detail.ItemID);
                if (inventoryItem != null)
                {
                    dgvDetails.Rows.Add(inventoryItem.ItemName, detail.Quantity, inventoryItem.Unit);
                }
                else
                {
                    // في حال تم حذف الصنف من المخزون، اعرض اسمه كـ "صنف محذوف"
                    dgvDetails.Rows.Add("صنف محذوف", detail.Quantity, "N/A");
                }
            }
        }

        // --- 3. أحداث الأزرار وعناصر التحكم ---

        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAndDisplayData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFilters();
            LoadAndDisplayData();
        }

        private void dgvDistributions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDistributions.CurrentRow != null)
            {
                // الحصول على رقم العملية من الصف المحدد
                string selectedDistributionId = dgvDistributions.CurrentRow.Cells["DistributionID"].Value.ToString();
                // عرض تفاصيل هذه العملية في الجدول الجانبي
                DisplayDistributionDetails(selectedDistributionId);
            }
        }

        private void ResetFilters()
        {
            txtSearch.Clear();
            // إعادة تعيين التواريخ إلى الشهر الحالي
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;
        }
    }
}

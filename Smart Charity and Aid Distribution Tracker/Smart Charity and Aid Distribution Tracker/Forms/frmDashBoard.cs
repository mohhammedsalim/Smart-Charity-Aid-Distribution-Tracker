using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
            FontManager.ApplyFontToControls(this); this.Load += new System.EventHandler(this.frmDashBoard_Load);

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            LoadStatistics();
            LoadChartData();
            LoadRecentActivities();
        }

        private void LoadStatistics()
        {
            try
            {

                double treasuryBalance = DataService.GetTreasuryBalance();
                // استخدام "N2" لعرض الرقم مع فاصلة الآلاف ورقمين عشريين (مثال: 1,500.00)
                string lblTreasuryBalance= treasuryBalance.ToString("N2") + " د.ل";
                lblNumberDisbursement.Text = lblTreasuryBalance;

                // قراءة البيانات الحقيقية فقط
                lblNumberBeneficiaries.Text = DataService.GetBeneficiaries().Count.ToString();
                lblNumberInventory.Text = DataService.GetAllInventoryItems().Count.ToString();
                lblNumberDonations.Text = DataService.GetDonations().Count.ToString();
                //lblNumberDisbursement.Text = DataService.GetAllDistributions().Count.ToString();

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطأ: " + ex.Message);
            }
        }

        private void LoadChartData()
        {
            try
            {
                chartStatistics.Series["التبرعات"].Points.Clear();
                chartStatistics.Series["عمليات الصرف"].Points.Clear();

                var donations = DataService.GetDonations();
                var distributions = DataService.GetAllDistributions();

                if (donations.Count > 0 || distributions.Count > 0)
                {
                    chartStatistics.Series["التبرعات"].Points.AddXY("الإجمالي", donations.Count);
                    chartStatistics.Series["عمليات الصرف"].Points.AddXY("الإجمالي", distributions.Count);
                }

                chartStatistics.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartStatistics.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطأ: " + ex.Message);
            }
        }

        private void LoadRecentActivities()
        {
            try
            {
                var distributions = DataService.GetAllDistributions();

                DataTable dt = new DataTable();
                dt.Columns.Add("رقم العملية");
                dt.Columns.Add("المستفيد");
                dt.Columns.Add("التاريخ");

                if (distributions != null && distributions.Count > 0)
                {
                    var recent = distributions.OrderByDescending(d => d.DistributionDate).Take(5).ToList();
                    foreach (var d in recent)
                    {
                        var ben = DataService.GetBeneficiaryById(d.BeneficiaryID);
                        dt.Rows.Add(d.DistributionID, ben != null ? ben.FullName : "غير معروف", d.DistributionDate.ToString("yyyy-MM-dd"));
                    }
                }

                dgvRecentActivities.DataSource = dt;

                if (dgvRecentActivities.Columns.Count > 0)
                {
                    dgvRecentActivities.Columns["المستفيد"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطأ: " + ex.Message);
            }
        }
    }
}

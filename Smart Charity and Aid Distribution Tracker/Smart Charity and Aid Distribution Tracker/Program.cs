using Smart_Charity_and_Aid_Distribution_Tracker.Data;
using Smart_Charity_and_Aid_Distribution_Tracker.Distrbution;
using Smart_Charity_and_Aid_Distribution_Tracker.Donations;
using Smart_Charity_and_Aid_Distribution_Tracker.Donations.DonorManagement;
using Smart_Charity_and_Aid_Distribution_Tracker.Reports;
using Smart_Charity_and_Aid_Distribution_Tracker.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataStore.SeedData(); DataStore.SeedData1();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBeneficiarie());
        }
    }
}

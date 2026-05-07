using Smart_Charity_and_Aid_Distribution_Tracker.Forms;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SeedData.Initialize(); // قم بملء البيانات الأولية

            Application.Run(new frmLogin());
        }
    }
}

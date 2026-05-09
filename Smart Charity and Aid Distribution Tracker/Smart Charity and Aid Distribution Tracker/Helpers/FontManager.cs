using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Helpers
{
    public static class FontManager
    {
        // نحتفظ بالخطوط هنا لتبقى في الذاكرة طوال فترة تشغيل البرنامج
        private static PrivateFontCollection pfc = new PrivateFontCollection();

        // متغير للوصول لعائلة الخط من أي مكان
        public static FontFamily CairoFamily { get; private set; }

        public static void LoadFonts()
        {
            try
            {
                string fontPathRegular = Path.Combine(Application.StartupPath, "Fonts", "Cairo-Regular.ttf");
                string fontPathBold = Path.Combine(Application.StartupPath, "Fonts", "Cairo-Bold.ttf");

                if (File.Exists(fontPathRegular)) pfc.AddFontFile(fontPathRegular);
                if (File.Exists(fontPathBold)) pfc.AddFontFile(fontPathBold);

                if (pfc.Families.Length > 0)
                {
                    CairoFamily = pfc.Families[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("حدث خطأ أثناء تحميل الخطوط: " + ex.Message);
            }
        }

        // دالة مساعدة لتطبيق الخط على جميع الأدوات داخل أي نافذة بضغطة واحدة
        public static void ApplyFontToControls(Control parentControl)
        {
            if (CairoFamily == null) return;
            float sizeMultiplier = 1.0f;
            foreach (Control c in parentControl.Controls)
            {
                float newSize = c.Font.Size * sizeMultiplier;
                c.Font = new Font(CairoFamily, newSize, c.Font.Style);

                if (c is Guna.UI2.WinForms.Guna2DataGridView dgv)
                {
                    dgv.ThemeStyle.HeaderStyle.Font = new Font(CairoFamily, 12F * sizeMultiplier, FontStyle.Bold);
                    dgv.ThemeStyle.RowsStyle.Font = new Font(CairoFamily, 11F * sizeMultiplier, FontStyle.Regular);
                    dgv.ThemeStyle.AlternatingRowsStyle.Font = new Font(CairoFamily, 11F * sizeMultiplier, FontStyle.Regular);
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font(CairoFamily, 12F * sizeMultiplier, FontStyle.Bold);
                    dgv.DefaultCellStyle.Font = new Font(CairoFamily, 11F * sizeMultiplier, FontStyle.Regular);
                }

                if (c.HasChildren)
                {
                    ApplyFontToControls(c);
                }
            }
        }
    }
}

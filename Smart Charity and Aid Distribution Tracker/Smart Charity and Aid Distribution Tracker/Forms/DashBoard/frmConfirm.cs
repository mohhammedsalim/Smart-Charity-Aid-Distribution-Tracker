using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms.DashBoard
{
    public partial class frmConfirm : Form
    {
        // 1. المُنشئ (Constructor) - يتم استدعاؤه عند إنشاء نسخة جديدة من الفورم
        public frmConfirm()
        {
            InitializeComponent();
        }

        // 2. الوظيفة الثابتة (Static Method) - هذه هي الطريقة التي سنستدعي بها الرسالة
        public static DialogResult Show(string message, string title, MessageBoxIcon icon)
        {
            // إنشاء نسخة من شاشتنا المخصصة
            using (var form = new frmConfirm())
            {
                form.Text = title;
                form.lblMessage.Text = message;

                // تحديد الأيقونة بناءً على المدخلات
                switch (icon)
                {
                    case MessageBoxIcon.Question:
                        form.picIcon.Image = System.Drawing.SystemIcons.Question.ToBitmap();
                        break;
                    case MessageBoxIcon.Error:
                        form.picIcon.Image = System.Drawing.SystemIcons.Error.ToBitmap();
                        break;
                    case MessageBoxIcon.Warning:
                        form.picIcon.Image = System.Drawing.SystemIcons.Warning.ToBitmap();
                        break;
                    case MessageBoxIcon.Information:
                        form.picIcon.Image = System.Drawing.SystemIcons.Information.ToBitmap();
                        break;
                }

                // إظهار الفورم كـ Dialog وانتظار المستخدم ليضغط على زر
                // سيعود هذا بقيمة DialogResult.Yes أو DialogResult.No التي حددناها في أحداث النقر
                return form.ShowDialog();
            }
        }

        // 3. أحداث النقر للأزرار (Click Events)
        private void btnYes_Click_1(object sender, EventArgs e)
        {
            // عند الضغط على "نعم"، اجعل نتيجة الحوار "Yes"
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click_1(object sender, EventArgs e)
        {
            // عند الضغط على "لا"، اجعل نتيجة الحوار "No"
            this.DialogResult = DialogResult.No;
        }
    }
}

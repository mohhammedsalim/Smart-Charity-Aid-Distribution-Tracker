using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmUsers : Form
    {
        private enum PanelMode { View, Add, Edit }
        private PanelMode _currentMode;
        private User _selectedUser;

        public frmUsers()
        {
            InitializeComponent();
            FontManager.ApplyFontToControls(this); this.Load += new System.EventHandler(this.frmUsers_Load);
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            SetupComboBoxes();
            LoadUsersData();
            SetPanelMode(PanelMode.View);
        }

        private void SetPanelMode(PanelMode mode)
        {
            _currentMode = mode;

            pnlView.Visible = (mode == PanelMode.View);
            pnlInputs.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);

            btnSave.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);
            btnCancel.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);

            btnAddNew.Visible = (mode == PanelMode.View);
            btnEdit.Visible = (mode == PanelMode.View && _selectedUser != null);
            btnDelete.Visible = (mode == PanelMode.View && _selectedUser != null);
            btnResetPassword.Visible = (mode == PanelMode.View && _selectedUser != null);

            switch (mode)
            {
                case PanelMode.View:
                    lblPanelTitle.Text = "تفاصيل المستخدم";
                    DisplayUserDetails(_selectedUser);
                    break;

                case PanelMode.Add:
                    lblPanelTitle.Text = "إضافة مستخدم جديد";
                    ClearInputFields();
                    txtPassword.PlaceholderText = "كلمة المرور (إلزامية)";
                    break;

                case PanelMode.Edit:
                    lblPanelTitle.Text = "تعديل بيانات المستخدم";
                    FillInputFieldsWithSelectedUser();
                    txtPassword.PlaceholderText = "اتركه فارغاً لعدم التغيير";
                    break;
            }
        }

        private void SetupComboBoxes()
        {
            cmbRole.DataSource = Enum.GetValues(typeof(UserRole));
        }

        private void LoadUsersData()
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            var users = DataService.GetAllUsers()
                .Where(u => string.IsNullOrEmpty(searchTerm) ||
                            u.FullName.ToLower().Contains(searchTerm) ||
                            u.UserName.ToLower().Contains(searchTerm))
                .Select(u => new { u.EmployeeID, u.FullName, u.UserName, Role = u.Role.ToString() })
                .ToList();

            dgvUsersList.DataSource = users;
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            if (dgvUsersList.Columns.Count > 0)
            {
                dgvUsersList.Columns["EmployeeID"].HeaderText = "رقم الموظف";
                dgvUsersList.Columns["FullName"].HeaderText = "الاسم الكامل";
                dgvUsersList.Columns["UserName"].HeaderText = "اسم المستخدم";
                dgvUsersList.Columns["Role"].HeaderText = "الصلاحية";
                dgvUsersList.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void DisplayUserDetails(User user)
        {
            if (user != null)
            {
                lblFullNameText.Text = user.FullName;
                lblUsernameText.Text = user.UserName;
                lblRoleText.Text = user.Role.ToString();
            }
            else
            {
                lblFullNameText.Text = "----";
                lblUsernameText.Text = "----";
                lblRoleText.Text = "----";
            }
        }

        private void ClearInputFields()
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
        }

        private void FillInputFieldsWithSelectedUser()
        {
            if (_selectedUser != null)
            {
                txtFullName.Text = _selectedUser.FullName;
                txtUsername.Text = _selectedUser.UserName;
                txtPassword.Clear();
                cmbRole.SelectedItem = _selectedUser.Role;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsersData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadUsersData();
        }

        private void dgvUsersList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsersList.CurrentRow != null)
            {
                string selectedId = dgvUsersList.CurrentRow.Cells["EmployeeID"].Value.ToString();
                _selectedUser = DataService.GetUserById(selectedId);
            }
            else
            {
                _selectedUser = null;
            }

            if (_currentMode == PanelMode.View)
            {
                DisplayUserDetails(_selectedUser);
                btnEdit.Visible = (_selectedUser != null);
                btnDelete.Visible = (_selectedUser != null);
                btnResetPassword.Visible = (_selectedUser != null);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SetPanelMode(PanelMode.Add);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedUser != null)
            {
                SetPanelMode(PanelMode.Edit);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetPanelMode(PanelMode.View);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                new frmAlert("يجب إدخال الاسم الكامل واسم المستخدم.").ShowDialog();
                return;
            }

            if (_currentMode == PanelMode.Add)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    new frmAlert("يجب إدخال كلمة مرور للمستخدم الجديد.").ShowDialog();
                    return;
                }

                var newUser = new User
                {
                    FullName = txtFullName.Text.Trim(),
                    UserName = txtUsername.Text.Trim(),
                    Password = txtPassword.Text,
                    Role = (UserRole)Enum.Parse(typeof(UserRole), cmbRole.SelectedItem.ToString()),
                    IsActive = true,
                    CreatedDate = DateTime.Now
                };
                DataService.AddUser(newUser);
                new frmAlert("تمت إضافة المستخدم بنجاح.").ShowDialog();
            }
            else if (_currentMode == PanelMode.Edit)
            {
                _selectedUser.FullName = txtFullName.Text.Trim();
                _selectedUser.UserName = txtUsername.Text.Trim();
                _selectedUser.Role = (UserRole)Enum.Parse(typeof(UserRole), cmbRole.SelectedItem.ToString());

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    _selectedUser.Password = txtPassword.Text;
                }

                DataService.UpdateUser(_selectedUser);
                new frmAlert("تم تعديل بيانات المستخدم بنجاح.").ShowDialog();
            }

            LoadUsersData();
            SetPanelMode(PanelMode.View);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUser == null) return;

            var currentUser = SessionManager.GetCurrentUser();
            if (currentUser != null && currentUser.EmployeeID == _selectedUser.EmployeeID)
            {
                new frmAlert("لا يمكنك حذف حسابك الخاص.").ShowDialog();
                return;
            }

            frmConfirm confirmDialog = new frmConfirm($"هل أنت متأكد من أنك تريد حذف المستخدم '{_selectedUser.FullName}'؟");
            if (confirmDialog.ShowDialog() == DialogResult.Yes)
            {
                DataService.DeleteUser(_selectedUser.EmployeeID);
                new frmAlert("تم حذف المستخدم بنجاح.").ShowDialog();
                LoadUsersData();
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (_selectedUser == null) return;

            string newPassword = "Password123";

            frmConfirm confirmDialog = new frmConfirm($"هل أنت متأكد من أنك تريد إعادة تعيين كلمة مرور '{_selectedUser.FullName}' إلى '{newPassword}'؟");
            if (confirmDialog.ShowDialog() == DialogResult.Yes)
            {
                _selectedUser.Password = newPassword;
                DataService.UpdateUser(_selectedUser);
                new frmAlert("تم إعادة تعيين كلمة المرور بنجاح.").ShowDialog();
            }
        }
    }
}

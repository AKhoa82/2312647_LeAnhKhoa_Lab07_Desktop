using Lab09_EntityFramework.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Lab09_EntityFramework
{
    public partial class UpdateAccountForm : Form
    {
        private RestaurantContext _dbContext;
        private string _accountName;

        public UpdateAccountForm(string accountName = null)
        {
            InitializeComponent();
            _accountName = accountName;
            _dbContext = new RestaurantContext();
        }

        private void UpdateAccountForm_Load(object sender, EventArgs e)
        {
            LoadRoles();

            if (!string.IsNullOrEmpty(_accountName))
            {
                var acc = _dbContext.Accounts.Include(a => a.RoleAccounts)
                                             .FirstOrDefault(a => a.AccountName == _accountName);
                if (acc != null)
                {
                    txtAccountName.Text = acc.AccountName;
                    txtFullName.Text = acc.FullName;
                    txtEmail.Text = acc.Email;
                    txtTell.Text = acc.Tell;
                    txtPassword.Text = acc.Password;

                    txtAccountName.Enabled = false;

                    // Tick các role được gán
                    var roleIds = acc.RoleAccounts.Select(r => r.RoleID).ToList();
                    for (int i = 0; i < chkRoles.Items.Count; i++)
                    {
                        var role = chkRoles.Items[i] as Role;
                        if (roleIds.Contains(role.Id))
                            chkRoles.SetItemChecked(i, true);
                    }

                    this.Text = "Cập nhật tài khoản";
                }
            }
            else
                this.Text = "Thêm tài khoản mới";
        }

        private void LoadRoles()
        {
            chkRoles.Items.Clear();
            var roles = _dbContext.Roles.OrderBy(r => r.RoleName).ToList();
            foreach (var r in roles)
                chkRoles.Items.Add(r, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtAccountName.Text.Trim();
            var pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!");
                return;
            }

            if (_accountName == null) // thêm mới
            {
                // kiểm tra trùng
                if (_dbContext.Accounts.Any(a => a.AccountName == name))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                    return;
                }

                var newAcc = new Account()
                {
                    AccountName = name,
                    Password = string.IsNullOrEmpty(pass) ? "123" : pass,
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Tell = txtTell.Text.Trim(),
                    DateCreated = DateTime.Now
                };

                _dbContext.Accounts.Add(newAcc);
                _dbContext.SaveChanges();

                // Gán role
                foreach (var item in chkRoles.CheckedItems)
                {
                    var role = item as Role;
                    var ra = new RoleAccount
                    {
                        RoleID = role.Id,
                        AccountName = newAcc.AccountName,
                        Actived = true
                    };
                    _dbContext.RoleAccounts.Add(ra);
                }
            }
            else // cập nhật
            {
                var acc = _dbContext.Accounts.Include(a => a.RoleAccounts)
                                             .FirstOrDefault(a => a.AccountName == _accountName);
                if (acc != null)
                {
                    acc.FullName = txtFullName.Text.Trim();
                    acc.Email = txtEmail.Text.Trim();
                    acc.Tell = txtTell.Text.Trim();
                    if (!string.IsNullOrEmpty(pass))
                        acc.Password = pass;

                    // Cập nhật Role
                    var selectedRoles = chkRoles.CheckedItems.Cast<Role>().Select(r => r.Id).ToList();

                    // Xóa role cũ
                    var oldRoles = acc.RoleAccounts.ToList();
                    foreach (var r in oldRoles)
                        _dbContext.RoleAccounts.Remove(r);

                    // Thêm role mới
                    foreach (var roleId in selectedRoles)
                    {
                        var ra = new RoleAccount
                        {
                            RoleID = roleId,
                            AccountName = acc.AccountName,
                            Actived = true
                        };
                        _dbContext.RoleAccounts.Add(ra);
                    }
                }
            }

            _dbContext.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateRoleForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
                LoadRoles();
        }
    }
}
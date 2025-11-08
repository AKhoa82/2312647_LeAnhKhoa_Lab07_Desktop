using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Lab09_EntityFramework.Models;

namespace Lab09_EntityFramework
{
    public partial class AccountForm : Form
    {
        private RestaurantContext _db;

        public AccountForm()
        {
            InitializeComponent();
            _db = new RestaurantContext();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadRolesToFilter();
            LoadAccounts();
        }

        private void LoadRolesToFilter()
        {
            var roles = _db.Roles.OrderBy(r => r.RoleName).ToList();
            cboRoleFilter.Items.Clear();
            cboRoleFilter.Items.Add("-- Tất cả vai trò --");
            foreach (var role in roles)
                cboRoleFilter.Items.Add(role.RoleName);
            cboRoleFilter.SelectedIndex = 0;
        }

        private void LoadAccounts()
        {
            lvwAccount.Items.Clear();

            string keyword = txtSearch.Text == "Tìm theo tên người dùng..." ? "" : txtSearch.Text.Trim().ToLower();
            string selectedRole = cboRoleFilter.SelectedIndex > 0 ? cboRoleFilter.SelectedItem.ToString() : "";

            var accounts = _db.Accounts.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
                accounts = accounts.Where(a => a.FullName.ToLower().Contains(keyword));

            if (!string.IsNullOrEmpty(selectedRole))
                accounts = accounts.Where(a => a.RoleAccounts.Any(r => r.Role.RoleName == selectedRole));

            foreach (var acc in accounts.ToList())
            {
                var item = new ListViewItem(acc.AccountName);
                item.SubItems.Add(acc.FullName);
                item.SubItems.Add(acc.Email);
                item.SubItems.Add(acc.Tell);
                string status = string.IsNullOrEmpty(acc.Password) ? "Inactive" : "Active";
                item.SubItems.Add(status);
                item.Tag = acc;
                lvwAccount.Items.Add(item);
            }
        }

        // Search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Focused)
                LoadAccounts();
        }

        private void cboRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm theo tên người dùng...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Tìm theo tên người dùng...";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Thêm tài khoản
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new UpdateAccountForm();
            if (frm.ShowDialog() == DialogResult.OK)
                LoadAccounts();
        }

        // Reset mật khẩu
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0) return;
            var acc = lvwAccount.SelectedItems[0].Tag as Account;
            acc.Password = "123456"; // mặc định
            _db.SaveChanges();
            MessageBox.Show("Đã reset mật khẩu về 123456", "Thông báo");
            LoadAccounts();
        }

        // Đổi mật khẩu
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0) return;
            var acc = lvwAccount.SelectedItems[0].Tag as Account;
            var frm = new ChangePasswordForm(acc.AccountName);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadAccounts();
        }

        // Menu chuột phải: Xóa tài khoản
        private void mnuDeleteAccount_Click(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0) return;
            var acc = lvwAccount.SelectedItems[0].Tag as Account;
            acc.Password = "";
            _db.SaveChanges();
            MessageBox.Show("Tài khoản đã bị vô hiệu hóa (Inactive).", "Thông báo");
            LoadAccounts();
        }

        // Menu chuột phải: Xem vai trò
        private void mnuViewRoles_Click(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0) return;
            var acc = lvwAccount.SelectedItems[0].Tag as Account;
            var frm = new AccountRolesForm(acc.AccountName);
            frm.ShowDialog();
        }

        private void lvwAccount_DoubleClick(object sender, EventArgs e)
        {
            if (lvwAccount.SelectedItems.Count == 0) return;
            var acc = lvwAccount.SelectedItems[0].Tag as Account;
            var frm = new UpdateAccountForm(acc.AccountName);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadAccounts();
        }
    }
}
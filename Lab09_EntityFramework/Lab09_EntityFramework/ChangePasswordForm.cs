using Lab09_EntityFramework.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab09_EntityFramework
{
    public partial class ChangePasswordForm : Form
    {
        private readonly RestaurantContext _dbContext;
        private readonly string _accountName;

        public ChangePasswordForm(string accountName)
        {
            InitializeComponent();
            _dbContext = new RestaurantContext();
            _accountName = accountName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var acc = _dbContext.Accounts.FirstOrDefault(a => a.AccountName == _accountName);
            if (acc == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!");
                return;
            }

            if (acc.Password != txtOldPassword.Text.Trim())
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
                return;
            }

            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp!");
                return;
            }

            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("Mật khẩu mới không được để trống!");
                return;
            }

            acc.Password = txtNewPassword.Text.Trim();
            _dbContext.SaveChanges();
            MessageBox.Show("Đổi mật khẩu thành công!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
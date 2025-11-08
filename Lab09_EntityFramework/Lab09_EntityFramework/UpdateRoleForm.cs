using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab09_EntityFramework.Models;

namespace Lab09_EntityFramework
{
    public partial class UpdateRoleForm : Form
    {
        private int? _roleId;
        private RestaurantContext _dbContext;
        public UpdateRoleForm(int? roleId = null)
        {
            InitializeComponent();
            _roleId = roleId;
            _dbContext = new RestaurantContext();
        }

        private void UpdateRoleForm_Load(object sender, EventArgs e)
        {
            if (_roleId.HasValue)
            {
                var role = _dbContext.Roles.FirstOrDefault(r => r.Id == _roleId);
                if (role != null)
                {
                    txtRoleName.Text = role.RoleName;
                    txtNotes.Text = role.Notes;
                    this.Text = "Cập nhật nhóm người dùng";
                }
            }
            else
            {
                this.Text = "Thêm nhóm người dùng mới";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtRoleName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên nhóm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isDuplicate;
            if (_roleId == null)
                isDuplicate = _dbContext.Roles.Any(r => r.RoleName.ToLower() == name.ToLower());
            else
                isDuplicate = _dbContext.Roles.Any(r => r.RoleName.ToLower() == name.ToLower() && r.Id != _roleId);
            if (isDuplicate)
            {
                MessageBox.Show("Tên nhóm này đã tồn tại!\nVui lòng chọn tên khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoleName.Focus();
                txtRoleName.SelectAll();
                return;
            }

            if (_roleId == null)
            {
                var newRole = new Role()
                {
                    RoleName = name,
                    Notes = txtNotes.Text.Trim()
                };
                _dbContext.Roles.Add(newRole);
            }
            else
            {
                var role = _dbContext.Roles.FirstOrDefault(r => r.Id == _roleId);
                if (role != null)
                {
                    role.RoleName = name;
                    role.Notes = txtNotes.Text.Trim();
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
    }
}

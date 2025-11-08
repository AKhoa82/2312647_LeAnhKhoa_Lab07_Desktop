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
    public partial class RoleForm : Form
    {
        private RestaurantContext _dbContext;

        public RoleForm()
        {
            InitializeComponent();
            _dbContext = new RestaurantContext();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void LoadRoles()
        {
            lvwRole.Items.Clear();
            var roles = _dbContext.Roles.OrderBy(r => r.RoleName).ToList();

            foreach (var role in roles)
            {
                var item = new ListViewItem(role.Id.ToString());
                item.SubItems.Add(role.RoleName);
                item.SubItems.Add(role.Notes ?? "");
                item.Tag = role;
                lvwRole.Items.Add(item);
            }
            lvwAccount.Items.Clear();
        }

        private void lvwRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwRole.SelectedItems.Count == 0)
                return;

            var selectedRole = lvwRole.SelectedItems[0].Tag as Role;
            LoadAccountsByRole(selectedRole.Id);
        }

        private void LoadAccountsByRole(int roleId)
        {
            lvwAccount.Items.Clear();

            var accounts = _dbContext.RoleAccounts
                .Where(ra => ra.RoleID == roleId && ra.Actived)
                .Select(ra => ra.Account)
                .ToList();

            foreach (var acc in accounts)
            {
                var item = new ListViewItem(acc.AccountName);
                item.SubItems.Add(acc.FullName);
                lvwAccount.Items.Add(item);
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateRoleForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
                LoadRoles();
        }

        private void lvwRole_DoubleClick(object sender, EventArgs e)
        {
            if (lvwRole.SelectedItems.Count == 0)
                return;

            var selectedRole = lvwRole.SelectedItems[0].Tag as Role;
            var dialog = new UpdateRoleForm(selectedRole.Id);
            if (dialog.ShowDialog(this) == DialogResult.OK)
                LoadRoles();
        }

        private void btnReloadRole_Click(object sender, EventArgs e)
        {
            LoadRoles();
        }
    }
}

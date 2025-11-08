using Lab09_EntityFramework.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab09_EntityFramework
{
    public partial class AccountRolesForm : Form
    {
        private readonly RestaurantContext _dbContext;
        private readonly string _accountName;

        public AccountRolesForm(string accountName)
        {
            InitializeComponent();
            _dbContext = new RestaurantContext();
            _accountName = accountName;
        }

        private void AccountRolesForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void LoadRoles()
        {
            lvwRoles.Items.Clear();

            var roles = _dbContext.RoleAccounts
                .Where(ra => ra.AccountName == _accountName && ra.Actived)
                .Select(ra => ra.Role)
                .ToList();

            foreach (var role in roles)
            {
                var item = new ListViewItem(role.RoleName);
                item.SubItems.Add(role.Notes);
                lvwRoles.Items.Add(item);
            }

            this.Text = $"Vai trò của tài khoản: {_accountName}";
        }
    }
}
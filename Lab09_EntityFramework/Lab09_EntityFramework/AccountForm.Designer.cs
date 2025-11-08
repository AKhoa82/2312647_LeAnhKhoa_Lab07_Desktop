namespace Lab09_EntityFramework
{
    partial class AccountForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvwAccount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboRoleFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuViewRoles;
        private System.Windows.Forms.ColumnHeader colAccountName;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colTell;
        private System.Windows.Forms.ColumnHeader colStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboRoleFilter = new System.Windows.Forms.ComboBox();
            this.lvwAccount = new System.Windows.Forms.ListView();
            this.colAccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(30, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Tìm theo tên người dùng...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.GotFocus += new System.EventHandler(this.txtSearch_GotFocus);
            this.txtSearch.LostFocus += new System.EventHandler(this.txtSearch_LostFocus);
            // 
            // cboRoleFilter
            // 
            this.cboRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoleFilter.Location = new System.Drawing.Point(300, 25);
            this.cboRoleFilter.Name = "cboRoleFilter";
            this.cboRoleFilter.Size = new System.Drawing.Size(200, 25);
            this.cboRoleFilter.TabIndex = 1;
            this.cboRoleFilter.SelectedIndexChanged += new System.EventHandler(this.cboRoleFilter_SelectedIndexChanged);
            // 
            // lvwAccount
            // 
            this.lvwAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccountName,
            this.colFullName,
            this.colEmail,
            this.colTell,
            this.colStatus});
            this.lvwAccount.ContextMenuStrip = this.ctxMenu;
            this.lvwAccount.FullRowSelect = true;
            this.lvwAccount.GridLines = true;
            this.lvwAccount.HideSelection = false;
            this.lvwAccount.Location = new System.Drawing.Point(30, 70);
            this.lvwAccount.MultiSelect = false;
            this.lvwAccount.Name = "lvwAccount";
            this.lvwAccount.Size = new System.Drawing.Size(600, 300);
            this.lvwAccount.TabIndex = 2;
            this.lvwAccount.UseCompatibleStateImageBehavior = false;
            this.lvwAccount.View = System.Windows.Forms.View.Details;
            this.lvwAccount.DoubleClick += new System.EventHandler(this.lvwAccount_DoubleClick);
            // 
            // colAccountName
            // 
            this.colAccountName.Text = "Tên đăng nhập";
            this.colAccountName.Width = 120;
            // 
            // colFullName
            // 
            this.colFullName.Text = "Họ tên";
            this.colFullName.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 150;
            // 
            // colTell
            // 
            this.colTell.Text = "SĐT";
            this.colTell.Width = 100;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Trạng thái";
            this.colStatus.Width = 80;
            // 
            // ctxMenu
            // 
            this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeleteAccount,
            this.mnuViewRoles});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(199, 48);
            // 
            // mnuDeleteAccount
            // 
            this.mnuDeleteAccount.Name = "mnuDeleteAccount";
            this.mnuDeleteAccount.Size = new System.Drawing.Size(198, 22);
            this.mnuDeleteAccount.Text = "Xóa tài khoản (Inactive)";
            this.mnuDeleteAccount.Click += new System.EventHandler(this.mnuDeleteAccount_Click);
            // 
            // mnuViewRoles
            // 
            this.mnuViewRoles.Name = "mnuViewRoles";
            this.mnuViewRoles.Size = new System.Drawing.Size(198, 22);
            this.mnuViewRoles.Text = "Xem danh sách vai trò";
            this.mnuViewRoles.Click += new System.EventHandler(this.mnuViewRoles_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(650, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(650, 99);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(117, 23);
            this.btnResetPass.TabIndex = 2;
            this.btnResetPass.Text = "Reset mật khẩu";
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(650, 128);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(117, 23);
            this.btnChangePass.TabIndex = 1;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvwAccount);
            this.Controls.Add(this.cboRoleFilter);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý tài khoản người dùng";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

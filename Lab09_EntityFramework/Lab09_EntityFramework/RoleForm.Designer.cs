namespace Lab09_EntityFramework
{
    partial class RoleForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Dọn tài nguyên.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReloadRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.lvwRole = new System.Windows.Forms.ListView();
            this.colRoleId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoleNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwAccount = new System.Windows.Forms.ListView();
            this.colAccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnReloadRole
            // 
            this.btnReloadRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadRole.Location = new System.Drawing.Point(408, 11);
            this.btnReloadRole.Name = "btnReloadRole";
            this.btnReloadRole.Size = new System.Drawing.Size(35, 28);
            this.btnReloadRole.TabIndex = 0;
            this.btnReloadRole.Text = "R";
            this.toolTip1.SetToolTip(this.btnReloadRole, "Tải lại danh sách nhóm");
            this.btnReloadRole.UseVisualStyleBackColor = true;
            this.btnReloadRole.Click += new System.EventHandler(this.btnReloadRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRole.Location = new System.Drawing.Point(449, 11);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(35, 28);
            this.btnAddRole.TabIndex = 1;
            this.btnAddRole.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddRole, "Thêm nhóm mới");
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(12, 15);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(160, 17);
            this.labelRole.TabIndex = 4;
            this.labelRole.Text = "Danh sách nhóm (Role)";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccount.Location = new System.Drawing.Point(490, 15);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(232, 17);
            this.labelAccount.TabIndex = 5;
            this.labelAccount.Text = "Danh sách người dùng thuộc nhóm";
            // 
            // lvwRole
            // 
            this.lvwRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwRole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoleId,
            this.colRoleName,
            this.colRoleNotes});
            this.lvwRole.FullRowSelect = true;
            this.lvwRole.GridLines = true;
            this.lvwRole.HideSelection = false;
            this.lvwRole.Location = new System.Drawing.Point(16, 45);
            this.lvwRole.MultiSelect = false;
            this.lvwRole.Name = "lvwRole";
            this.lvwRole.Size = new System.Drawing.Size(470, 480);
            this.lvwRole.TabIndex = 6;
            this.lvwRole.UseCompatibleStateImageBehavior = false;
            this.lvwRole.View = System.Windows.Forms.View.Details;
            this.lvwRole.SelectedIndexChanged += new System.EventHandler(this.lvwRole_SelectedIndexChanged);
            this.lvwRole.DoubleClick += new System.EventHandler(this.lvwRole_DoubleClick);
            // 
            // colRoleId
            // 
            this.colRoleId.Text = "ID";
            this.colRoleId.Width = 50;
            // 
            // colRoleName
            // 
            this.colRoleName.Text = "Tên nhóm (RoleName)";
            this.colRoleName.Width = 220;
            // 
            // colRoleNotes
            // 
            this.colRoleNotes.Text = "Ghi chú";
            this.colRoleNotes.Width = 180;
            // 
            // lvwAccount
            // 
            this.lvwAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccountName,
            this.colFullName,
            this.colEmail,
            this.colTell});
            this.lvwAccount.FullRowSelect = true;
            this.lvwAccount.GridLines = true;
            this.lvwAccount.HideSelection = false;
            this.lvwAccount.Location = new System.Drawing.Point(493, 45);
            this.lvwAccount.MultiSelect = false;
            this.lvwAccount.Name = "lvwAccount";
            this.lvwAccount.Size = new System.Drawing.Size(500, 480);
            this.lvwAccount.TabIndex = 7;
            this.lvwAccount.UseCompatibleStateImageBehavior = false;
            this.lvwAccount.View = System.Windows.Forms.View.Details;
            // 
            // colAccountName
            // 
            this.colAccountName.Text = "Tên đăng nhập (AccountName)";
            this.colAccountName.Width = 180;
            // 
            // colFullName
            // 
            this.colFullName.Text = "Tên đầy đủ (FullName)";
            this.colFullName.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 120;
            // 
            // colTell
            // 
            this.colTell.Text = "Điện thoại";
            this.colTell.Width = 100;
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 541);
            this.Controls.Add(this.lvwAccount);
            this.Controls.Add(this.lvwRole);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnReloadRole);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1028, 580);
            this.Name = "RoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhóm người dùng (Role)";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReloadRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.ListView lvwRole;
        private System.Windows.Forms.ColumnHeader colRoleId;
        private System.Windows.Forms.ColumnHeader colRoleName;
        private System.Windows.Forms.ColumnHeader colRoleNotes;
        private System.Windows.Forms.ListView lvwAccount;
        private System.Windows.Forms.ColumnHeader colAccountName;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colTell;
    }
}
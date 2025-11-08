namespace Lab09_EntityFramework
{
    partial class AccountRolesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lvwRoles = new System.Windows.Forms.ListView();
            this.colRoleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwRoles
            // 
            this.lvwRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoleName,
            this.colNotes});
            this.lvwRoles.FullRowSelect = true;
            this.lvwRoles.GridLines = true;
            this.lvwRoles.Location = new System.Drawing.Point(20, 20);
            this.lvwRoles.Name = "lvwRoles";
            this.lvwRoles.Size = new System.Drawing.Size(400, 250);
            this.lvwRoles.TabIndex = 0;
            this.lvwRoles.View = System.Windows.Forms.View.Details;
            // 
            // colRoleName
            // 
            this.colRoleName.Text = "Tên vai trò";
            this.colRoleName.Width = 150;
            // 
            // colNotes
            // 
            this.colNotes.Text = "Ghi chú";
            this.colNotes.Width = 220;
            // 
            // AccountRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 300);
            this.Controls.Add(this.lvwRoles);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách vai trò";
            this.Load += new System.EventHandler(this.AccountRolesForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView lvwRoles;
        private System.Windows.Forms.ColumnHeader colRoleName, colNotes;

        #endregion
    }
}
namespace Lab09_EntityFramework
{
    partial class FoodForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvwCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.ListView lvwFood;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colNotes;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnReloadCategory;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnReloadFood;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tvwCategory = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.lvwFood = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnReloadCategory = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnReloadFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm món ăn:";
            // 
            // tvwCategory
            // 
            this.tvwCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwCategory.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.tvwCategory.Location = new System.Drawing.Point(15, 40);
            this.tvwCategory.Name = "tvwCategory";
            this.tvwCategory.Size = new System.Drawing.Size(250, 480);
            this.tvwCategory.TabIndex = 4;
            this.tvwCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategory_AfterSelect);
            this.tvwCategory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwCategory_NodeMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label2.Location = new System.Drawing.Point(270, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thực đơn:";
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtSearchFood.Location = new System.Drawing.Point(360, 9);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(250, 29);
            this.txtSearchFood.TabIndex = 6;
            this.txtSearchFood.Text = "Tìm kiếm theo tên món ăn...";
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            this.txtSearchFood.Enter += new System.EventHandler(this.txtSearchFood_Enter);
            this.txtSearchFood.Leave += new System.EventHandler(this.txtSearchFood_Leave);
            // 
            // lvwFood
            // 
            this.lvwFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colUnit,
            this.colPrice,
            this.colCategory,
            this.colNotes});
            this.lvwFood.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lvwFood.FullRowSelect = true;
            this.lvwFood.GridLines = true;
            this.lvwFood.HideSelection = false;
            this.lvwFood.Location = new System.Drawing.Point(274, 40);
            this.lvwFood.Name = "lvwFood";
            this.lvwFood.Size = new System.Drawing.Size(600, 480);
            this.lvwFood.TabIndex = 10;
            this.lvwFood.UseCompatibleStateImageBehavior = false;
            this.lvwFood.View = System.Windows.Forms.View.Details;
            this.lvwFood.DoubleClick += new System.EventHandler(this.lvwFood_DoubleClick);
            // 
            // colID
            // 
            this.colID.Text = "Mã số";
            // 
            // colName
            // 
            this.colName.Text = "Tên món ăn";
            this.colName.Width = 150;
            // 
            // colUnit
            // 
            this.colUnit.Text = "ĐV Tính";
            this.colUnit.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Giá bán";
            this.colPrice.Width = 90;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Nhóm";
            this.colCategory.Width = 100;
            // 
            // colNotes
            // 
            this.colNotes.Text = "Ghi chú";
            this.colNotes.Width = 100;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnAddCategory.Location = new System.Drawing.Point(232, 9);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(33, 29);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnReloadCategory
            // 
            this.btnReloadCategory.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnReloadCategory.Location = new System.Drawing.Point(193, 9);
            this.btnReloadCategory.Name = "btnReloadCategory";
            this.btnReloadCategory.Size = new System.Drawing.Size(33, 29);
            this.btnReloadCategory.TabIndex = 2;
            this.btnReloadCategory.Text = "R";
            this.btnReloadCategory.UseVisualStyleBackColor = true;
            this.btnReloadCategory.Click += new System.EventHandler(this.btnReloadCategory_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnAddFood.Location = new System.Drawing.Point(841, 9);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(33, 29);
            this.btnAddFood.TabIndex = 9;
            this.btnAddFood.Text = "+";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFood.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnDeleteFood.Location = new System.Drawing.Point(802, 9);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(33, 29);
            this.btnDeleteFood.TabIndex = 8;
            this.btnDeleteFood.Text = "-";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnReloadFood
            // 
            this.btnReloadFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadFood.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnReloadFood.Location = new System.Drawing.Point(763, 9);
            this.btnReloadFood.Name = "btnReloadFood";
            this.btnReloadFood.Size = new System.Drawing.Size(33, 29);
            this.btnReloadFood.TabIndex = 7;
            this.btnReloadFood.Text = "R";
            this.btnReloadFood.UseVisualStyleBackColor = true;
            this.btnReloadFood.Click += new System.EventHandler(this.btnReloadFood_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 532);
            this.Controls.Add(this.btnReloadFood);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnReloadCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lvwFood);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvwCategory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Name = "FoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thực đơn";
            this.Load += new System.EventHandler(this.FoodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

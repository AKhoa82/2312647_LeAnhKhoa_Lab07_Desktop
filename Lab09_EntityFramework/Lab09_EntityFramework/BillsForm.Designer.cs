namespace Lab09_EntityFramework
{
    partial class BillsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnViewBills;
        private System.Windows.Forms.ListView lvwBills;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colTableID;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colDiscount;
        private System.Windows.Forms.ColumnHeader colFinalAmount;
        private System.Windows.Forms.ColumnHeader colCheckoutDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalDiscount;
        private System.Windows.Forms.TextBox txtTotalDiscount;
        private System.Windows.Forms.Label lblTotalFinalAmount;
        private System.Windows.Forms.TextBox txtTotalFinalAmount;

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
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewBills = new System.Windows.Forms.Button();
            this.lvwBills = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTableID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFinalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckoutDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.txtTotalDiscount = new System.Windows.Forms.TextBox();
            this.lblTotalFinalAmount = new System.Windows.Forms.Label();
            this.txtTotalFinalAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblFromDate.Location = new System.Drawing.Point(30, 30);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(76, 21);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(110, 26);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(150, 29);
            this.dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblToDate.Location = new System.Drawing.Point(290, 30);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(85, 21);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "Đến ngày:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(370, 26);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(150, 29);
            this.dtpToDate.TabIndex = 3;
            // 
            // btnViewBills
            // 
            this.btnViewBills.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnViewBills.Location = new System.Drawing.Point(540, 25);
            this.btnViewBills.Name = "btnViewBills";
            this.btnViewBills.Size = new System.Drawing.Size(130, 30);
            this.btnViewBills.TabIndex = 4;
            this.btnViewBills.Text = "Xem hóa đơn";
            this.btnViewBills.UseVisualStyleBackColor = true;
            this.btnViewBills.Click += new System.EventHandler(this.btnViewBills_Click);
            // 
            // lvwBills
            // 
            this.lvwBills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colTableID,
            this.colAmount,
            this.colDiscount,
            this.colFinalAmount,
            this.colCheckoutDate});
            this.lvwBills.FullRowSelect = true;
            this.lvwBills.GridLines = true;
            this.lvwBills.HideSelection = false;
            this.lvwBills.Location = new System.Drawing.Point(30, 80);
            this.lvwBills.MultiSelect = false;
            this.lvwBills.Name = "lvwBills";
            this.lvwBills.Size = new System.Drawing.Size(740, 300);
            this.lvwBills.TabIndex = 5;
            this.lvwBills.UseCompatibleStateImageBehavior = false;
            this.lvwBills.View = System.Windows.Forms.View.Details;
            this.lvwBills.DoubleClick += new System.EventHandler(this.lvwBills_DoubleClick);
            // 
            // colID
            // 
            this.colID.Text = "Mã HĐ";
            // 
            // colName
            // 
            this.colName.Text = "Tên hóa đơn";
            this.colName.Width = 120;
            // 
            // colTableID
            // 
            this.colTableID.Text = "Bàn";
            this.colTableID.Width = 70;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Tổng tiền (Chưa giảm)";
            this.colAmount.Width = 150;
            // 
            // colDiscount
            // 
            this.colDiscount.Text = "Giảm giá (%)";
            this.colDiscount.Width = 90;
            // 
            // colFinalAmount
            // 
            this.colFinalAmount.Text = "Thực thu";
            this.colFinalAmount.Width = 130;
            // 
            // colCheckoutDate
            // 
            this.colCheckoutDate.Text = "Ngày thanh toán";
            this.colCheckoutDate.Width = 120;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblTotalAmount.Location = new System.Drawing.Point(30, 400);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(151, 21);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Tổng tiền hóa đơn:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtTotalAmount.Location = new System.Drawing.Point(160, 397);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(150, 29);
            this.txtTotalAmount.TabIndex = 7;
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblTotalDiscount.Location = new System.Drawing.Point(330, 400);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(120, 21);
            this.lblTotalDiscount.TabIndex = 8;
            this.lblTotalDiscount.Text = "Tổng giảm giá:";
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtTotalDiscount.Location = new System.Drawing.Point(440, 397);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.ReadOnly = true;
            this.txtTotalDiscount.Size = new System.Drawing.Size(100, 29);
            this.txtTotalDiscount.TabIndex = 9;
            // 
            // lblTotalFinalAmount
            // 
            this.lblTotalFinalAmount.AutoSize = true;
            this.lblTotalFinalAmount.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblTotalFinalAmount.Location = new System.Drawing.Point(550, 400);
            this.lblTotalFinalAmount.Name = "lblTotalFinalAmount";
            this.lblTotalFinalAmount.Size = new System.Drawing.Size(82, 21);
            this.lblTotalFinalAmount.TabIndex = 10;
            this.lblTotalFinalAmount.Text = "Thực thu:";
            // 
            // txtTotalFinalAmount
            // 
            this.txtTotalFinalAmount.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtTotalFinalAmount.Location = new System.Drawing.Point(630, 397);
            this.txtTotalFinalAmount.Name = "txtTotalFinalAmount";
            this.txtTotalFinalAmount.ReadOnly = true;
            this.txtTotalFinalAmount.Size = new System.Drawing.Size(140, 29);
            this.txtTotalFinalAmount.TabIndex = 11;
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalFinalAmount);
            this.Controls.Add(this.lblTotalFinalAmount);
            this.Controls.Add(this.txtTotalDiscount);
            this.Controls.Add(this.lblTotalDiscount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lvwBills);
            this.Controls.Add(this.btnViewBills);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Name = "BillsForm";
            this.Text = "Quản lý Hóa đơn";
            this.Load += new System.EventHandler(this.BillsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
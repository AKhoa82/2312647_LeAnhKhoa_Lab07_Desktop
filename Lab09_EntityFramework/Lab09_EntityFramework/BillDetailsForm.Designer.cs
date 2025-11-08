namespace Lab09_EntityFramework
{
    partial class BillDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvwBillDetails;
        private System.Windows.Forms.ColumnHeader colFoodName;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.TextBox txtBillID;

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
            this.lvwBillDetails = new System.Windows.Forms.ListView();
            this.colFoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBillID = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvwBillDetails
            // 
            this.lvwBillDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFoodName,
            this.colQuantity,
            this.colPrice,
            this.colTotal});
            this.lvwBillDetails.FullRowSelect = true;
            this.lvwBillDetails.GridLines = true;
            this.lvwBillDetails.HideSelection = false;
            this.lvwBillDetails.Location = new System.Drawing.Point(20, 70);
            this.lvwBillDetails.Name = "lvwBillDetails";
            this.lvwBillDetails.Size = new System.Drawing.Size(500, 300);
            this.lvwBillDetails.TabIndex = 0;
            this.lvwBillDetails.UseCompatibleStateImageBehavior = false;
            this.lvwBillDetails.View = System.Windows.Forms.View.Details;
            // 
            // colFoodName
            // 
            this.colFoodName.Text = "Tên món ăn";
            this.colFoodName.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Số lượng";
            this.colQuantity.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Đơn giá";
            this.colPrice.Width = 100;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Thành tiền";
            this.colTotal.Width = 110;
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblBillID.Location = new System.Drawing.Point(20, 30);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(104, 21);
            this.lblBillID.TabIndex = 1;
            this.lblBillID.Text = "Mã hóa đơn:";
            // 
            // txtBillID
            // 
            this.txtBillID.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtBillID.Location = new System.Drawing.Point(120, 27);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(100, 29);
            this.txtBillID.TabIndex = 2;
            // 
            // BillDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 400);
            this.Controls.Add(this.txtBillID);
            this.Controls.Add(this.lblBillID);
            this.Controls.Add(this.lvwBillDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Name = "BillDetailsForm";
            this.Text = "Chi tiết Hóa đơn";
            this.Load += new System.EventHandler(this.BillDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
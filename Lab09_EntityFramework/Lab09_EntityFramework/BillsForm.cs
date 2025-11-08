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
using System.Data.Entity;

namespace Lab09_EntityFramework
{
    public partial class BillsForm : Form
    {
        public BillsForm()
        {
            InitializeComponent();
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now.Date;
            LoadBills();
        }

        private void btnViewBills_Click(object sender, EventArgs e)
        {
            LoadBills();
        }

        private void LoadBills()
        {
            lvwBills.Items.Clear();
            long totalAmount = 0;
            double totalDiscountValue = 0;
            double totalFinalAmount = 0;

            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1);

            var dbContext = new RestaurantContext(); 

            var bills = dbContext.Bills
                                .Include(b => b.Table)
                                .Where(b => b.CheckoutDate >= fromDate && b.CheckoutDate <= toDate)
                                .ToList();

            foreach (var bill in bills)
            {
                double discountRate = bill.Discount ?? 0;
                int amount = bill.Amount;
                double finalAmount = amount - (amount * discountRate);

                var item = new ListViewItem(bill.Id.ToString()); 
                item.SubItems.Add(bill.Name);
                item.SubItems.Add(bill.Table?.Name ?? bill.TableID.ToString());
                item.SubItems.Add(amount.ToString("N0"));
                item.SubItems.Add($"{discountRate:P0}");
                item.SubItems.Add(finalAmount.ToString("N0"));
                item.SubItems.Add(bill.CheckoutDate?.ToString("dd/MM/yyyy HH:mm"));

                item.Tag = bill;
                lvwBills.Items.Add(item);

                totalAmount += amount;
                totalDiscountValue += (amount * discountRate);
                totalFinalAmount += finalAmount;
            }

            txtTotalAmount.Text = totalAmount.ToString("N0");
            txtTotalDiscount.Text = totalDiscountValue.ToString("N0");
            txtTotalFinalAmount.Text = totalFinalAmount.ToString("N0");
        }

        private void lvwBills_DoubleClick(object sender, EventArgs e)
        {
            if (lvwBills.SelectedItems.Count == 0)
                return;

            var selectedBill = lvwBills.SelectedItems[0].Tag as Bills;
            if (selectedBill == null)
                return;

            var detailsForm = new BillDetailsForm(selectedBill.Id);
            detailsForm.Text = $"Chi tiết Hóa đơn {selectedBill.Id} - {selectedBill.Name}";
            detailsForm.ShowDialog();
        }
    }
}

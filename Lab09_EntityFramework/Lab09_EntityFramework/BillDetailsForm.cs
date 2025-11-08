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
    public partial class BillDetailsForm : Form
    {
        private int _billID;
        public BillDetailsForm(int billID)
        {
            InitializeComponent();
            _billID = billID;
            txtBillID.Text = _billID.ToString();
        }

        private void BillDetailsForm_Load(object sender, EventArgs e)
        {
            LoadBillDetails();
        }

        private void LoadBillDetails()
        {
            lvwBillDetails.Items.Clear();
            var dbContext = new RestaurantContext();

            var details = dbContext.BillDetails
                .Include(bd => bd.Food)
                .Where(bd => bd.InvoiceID == _billID)
                .ToList();

            foreach (var detail in details)
            {
                string foodName = detail.Food?.Name ?? "N/A";
                int quantity = detail.Quantity;
                int price = detail.Food?.Price ?? 0;
                int total = quantity * price;

                var item = new ListViewItem(foodName);
                item.SubItems.Add(quantity.ToString());
                item.SubItems.Add(price.ToString("N0"));
                item.SubItems.Add(total.ToString("N0"));
                lvwBillDetails.Items.Add(item);
            }
        }
    }
}

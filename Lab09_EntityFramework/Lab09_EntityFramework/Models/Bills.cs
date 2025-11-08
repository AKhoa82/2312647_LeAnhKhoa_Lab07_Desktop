using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_EntityFramework.Models
{
    public class Bills
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int TableID { get; set; }
        public int Amount { get; set; }
        public double? Discount { get; set; }
        public double? Tax { get; set; }
        public bool Status { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public string Account { get; set; }

        public virtual Table Table { get; set; }
        public virtual ICollection<BillDetails> BillDetails { get; set; }
    }
}

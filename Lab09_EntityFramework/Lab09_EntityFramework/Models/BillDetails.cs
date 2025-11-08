using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_EntityFramework.Models
{
    public class BillDetails
    {
        [Key]
        public int Id { get; set; }
        public int InvoiceID { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }

        public virtual Bills Bill { get; set; }
        public virtual Food Food { get; set; }
    }
}

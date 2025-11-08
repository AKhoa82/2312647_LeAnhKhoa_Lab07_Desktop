using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_EntityFramework.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int? Capacity { get; set; }

        public virtual ICollection<Bills> Bills { get; set; }
    }
}

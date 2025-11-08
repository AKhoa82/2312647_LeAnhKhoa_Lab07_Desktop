using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_EntityFramework.Models
{
    public class RoleAccount
    {
        [Key, Column(Order = 0)]
        public int RoleID {  get; set; }
        [Key, Column(Order = 1)]
        public string AccountName {  get; set; }
        public bool Actived {  get; set; }
        public string Notes {  get; set; }

        public virtual Role Role { get; set; }
        public virtual Account Account { get; set; }
    }
}

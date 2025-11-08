using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab09_EntityFramework.Models
{
    public class Account
    {
        [Key]
        public string AccountName {  get; set; }
        public string Password { get; set; }
        public string FullName {  get; set; }
        public string Email { get; set; }
        public string Tell {  get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }
    }
}

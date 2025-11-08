using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_EntityFramework.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Path {  get; set; }
        public string Notes { get; set; }

        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }

        public override string ToString()
        {
            return RoleName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNTreeNode.Models
{
    public class User : BaseEntity<Guid>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Sex { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin = 1,
        User = 2
    }
}

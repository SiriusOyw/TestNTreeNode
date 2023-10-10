using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNTreeNode.Models
{
    public class UserTreeMapper : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid TreeId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNTreeNode.Models
{
    public class Tree:BaseEntity<Guid>
    {
        public int ParentId { get; set; }
        public string Name { get; set; }
    }
}

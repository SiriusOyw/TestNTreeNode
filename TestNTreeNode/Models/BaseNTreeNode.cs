using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNTreeNode.Models
{
    public class BaseNTreeNode<TKey> : BaseEntity<TKey>
    {
        public string CreatedAt { get; set; }
        public DateTime CreatedTime { get; set; }
        public string ModifiedAt { get; set; }
        public DateTime ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}

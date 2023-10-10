using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNTreeNode
{
    public class TestNTreeNodeDbContextFactory : IDesignTimeDbContextFactory<TestNTreeNodeDbContext>
    {
        public TestNTreeNodeDbContext CreateDbContext(string[] args)
        {
            var configuration = Program.InitConfiguration();
            var options = Program.InitDatabase(configuration);
            return new TestNTreeNodeDbContext(options);
        }
    }
}

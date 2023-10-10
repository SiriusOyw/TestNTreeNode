using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNTreeNode.Models;

namespace TestNTreeNode
{
    public class TestNTreeNodeDbContext : DbContext
    {
        public TestNTreeNodeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tree> Trees { get; set; }
        public DbSet<UserTreeMapper> UserTreeMappers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestNTreeNodeDbContext).Assembly);
        }
    }

}

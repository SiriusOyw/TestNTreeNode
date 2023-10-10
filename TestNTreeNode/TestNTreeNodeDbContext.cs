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
            //添加种子数据
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "Admin",
                    Password = "123456",
                    Sex = Sex.Other,
                    Role = Role.Admin
                }
                );

            modelBuilder.Entity<Tree>().HasData(
                new Tree
                {
                    Id = Guid.NewGuid(),
                    Name = "Root",
                    ParentId = 0
                }
                );
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestNTreeNodeDbContext).Assembly);
        }
    }

}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultexTest.Database {
    public class VaultexTestContext : DbContext {

        public VaultexTestContext(DbContextOptions options) : base(options) { }

        public DbSet<Organisation>? Organisations { get; set; }

        public DbSet<Employee>? Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Organisation>().HasNoKey();
            modelBuilder.Entity<Employee>().HasNoKey();
        }
    }
}

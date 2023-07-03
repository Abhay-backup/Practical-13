using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practical_13.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("Data Source=SF-CPU-310;Initial Catalog=Practical_13_2;User Id=sa;Password =Gondal@1234;Encrypt =false;") { }

        public DbSet<Designations> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Employee>()
                .HasRequired<Designations>(x => x.Designations)
                .WithMany(x => x.Employees)
                .HasForeignKey<int>(x => x.DesignationId);
        }
    }
}
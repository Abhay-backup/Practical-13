using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Practical_13.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        [DataType(dataType: DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        public int? Age { get; set; }
    }


    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Data Source=SF-CPU-310;Initial Catalog=Practical_13;User Id=sa;Password =Gondal@1234;Encrypt =false;") { }

        public DbSet<Employee> Employees { get; set; }
    }
}
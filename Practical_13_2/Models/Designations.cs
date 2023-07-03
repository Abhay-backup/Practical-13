using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_13.Models
{
    public class Designations
    {
       
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Designation { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }

}

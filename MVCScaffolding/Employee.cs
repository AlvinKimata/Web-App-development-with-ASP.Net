using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCScaffolding.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]

        public string name { get; set; }
        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime Joiningdate { get; set; }
        [Range(22, 60)]
        public int age { get; set; }

    }

    public class EmpDBContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
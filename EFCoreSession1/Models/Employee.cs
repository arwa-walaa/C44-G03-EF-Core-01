using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Models
{
    //model or entity or POCO class
    internal class Employee
    {
      
        public int Id { get; set; }
        public string? Name { get; set; }
      
        public decimal Salary { get; set; }
        public int Age { get; set; }

        //navigation property
        //represent the realtionship of 1

        //FK property

        //[ForeignKey("MangerDept")]
        //public int MangerDeptId { get; set; }

        public Department  MangeDept { get; set; }=null!; //Total


    }
}

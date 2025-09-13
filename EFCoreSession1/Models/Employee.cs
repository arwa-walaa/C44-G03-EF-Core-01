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

     

        [InverseProperty(nameof(Department.Manager))]
        public Department  MangeDept { get; set; }=null!; //Total


        //one to one [total - total]

        public Address EmpAddress { get; set; }



        //many to one 
        [ForeignKey("EmployeeDepartment")]
        public int? EmpDeptId { get; set; }

        [InverseProperty(nameof(Department.Employees))]
        public Department EmployeeDepartment { get; set; }

    }
}

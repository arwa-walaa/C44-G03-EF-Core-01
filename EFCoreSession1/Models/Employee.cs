using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Models
{
    //model or entity or POCO class
    internal class Employee
    {
        //maping by Convension
        //public numeric Property Named as [Id, EmployeeId]
        //Automaticlly Assumed to be Primary Key 
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        //nullable refrence type 
        //mapped to nvarchar(Max) allow null
        public decimal Salary { get; set; }
        public int Age { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Models
{
    [PrimaryKey(nameof(DebtId))]
    internal class Department
    {

        public int DebtId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string DeptName { get; set; }

        //navigation property
        //public Employee? Manager { get; set; } = null!; //parial

        public int? MangerId { get; set; }
        [InverseProperty(nameof(Employee.MangeDept))]
        public Employee? Manager { get; set; }
        //one to many

        [InverseProperty(nameof(Employee.EmployeeDepartment))]
        public ICollection< Employee> Employees { get; set; } =new HashSet< Employee >();

      

    }
}

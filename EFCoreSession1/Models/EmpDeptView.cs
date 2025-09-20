using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Models
{
    internal class EmpDeptView
    {
       
        public int EmployeeID { get; set; }
        public string Name { get; set; } = null!;
        public int DebtId { get; set; }
        public string DeptName { get; set; } = null!;
    }
}

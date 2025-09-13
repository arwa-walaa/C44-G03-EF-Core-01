using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        // Navigation properties
        public int Dep_Id { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Stud_Course> StudentCourses { get; set; }
    }
}

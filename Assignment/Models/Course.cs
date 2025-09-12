using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }

        // Navigation properties
        public virtual Topic Topic { get; set; }
        public virtual ICollection<Stud_Course> StudentCourses { get; set; }
        public virtual ICollection<Course_Inst> CourseInstructors { get; set; }

    }
}

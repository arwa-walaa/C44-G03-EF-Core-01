using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Models
{
    public class CourseStudent
    {
        public int StudentId { get; set; }  
       
        public int CourseId { get; set; }

        public int Grade { get; set; }

    }
}

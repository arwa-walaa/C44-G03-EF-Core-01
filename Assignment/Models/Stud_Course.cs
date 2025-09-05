using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Stud_Course
    {
        [Key]
        public int Id { get; set; }
        public int stud_ID { get; set; }

      
        public int Course_ID { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Grade { get; set; }
    }
}

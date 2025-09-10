using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [Column("HourRate", TypeName = "decimal(18,2)")]
        public decimal HourlyRate { get; set; }

        [Column("Bouns", TypeName = "decimal(18,2)")]
        public decimal Bonus { get; set; }

      
        public int Dept_ID { get; set; }

        public virtual Department Department { get; set; }
    }
}

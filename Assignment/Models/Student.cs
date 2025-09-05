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
        [Key]
     
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("FName")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("LName")]
        public string LastName { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public int Age { get; set; }

        
        public int Dep_Id { get; set; }
    }
}

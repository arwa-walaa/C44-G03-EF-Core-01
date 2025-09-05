using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Course_Inst
    {

        [Key]
        public int ID { get; set; }

        public int inst_ID { get; set; }

        public int Course_ID { get; set; }

        [MaxLength(500)]
        public string evaluate { get; set; }
    }
}

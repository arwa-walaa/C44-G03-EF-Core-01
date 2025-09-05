using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Models
{
    [Table("Users")]
    internal class User
    {
        //data Annotation
        [Key]
        public int SSN { get; set; }
        [Required]
        [Column("UserName",TypeName ="varchar(50)")]
        [MaxLength(50,ErrorMessage="Name must be less than 51 chars")]
        [MinLength(3, ErrorMessage = "Name must be more than 3 chars")]
        [StringLength(maximumLength:50 ,MinimumLength =3)]
        public /*required*/ string UName { get; set; }
        [Required]
        [Range(20,50)]
        public int Age { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

        [NotMapped]
        public string UserCar { get; set; }

    }
}

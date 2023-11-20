using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace UNI_Training_System.Models
{
    public class University
    {
        [Key]
        public int University_ID { get; set;}
        [Required]
        [MaxLength(50)]
        public string University_Name { get; set;}
        [Required]
        public int Student_ID { get; set; }
        [Required]
        public string Student_Name { get; set; }
        [Required]
        public string Student_Email { get; set; }
        [Required]
        public int Password_Student { get; set; }
        [Required]
        public int Company_ID { get; set; }
        [Required]
        public int Company_Name { get; set; }
        [Required]
        public int Training_Field { get; set; }



        //[Required]
        //public string Contact_Info { get; set;}





    }
}
//University_ID INT PRIMARY KEY,
//    Name NVARCHAR(100) NOT NULL,
//    Location NVARCHAR(100),
//    Created_At DATETIME DEFAULT GETDATE(),
//    Last_Updated_At DATETIME DEFAULT GETDATE()

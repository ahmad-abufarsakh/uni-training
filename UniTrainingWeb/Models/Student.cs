using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Linq;


namespace UNI_Training_System.Models
{
    public class Student
    {
        [Key]
        public int Student_ID { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="THE STUDENT NAME IS REQUIRED")]
        [MaxLength(100)]
        public string Student_Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "THE EMAIL OF STUDENT IS REQUIRED")]
        [MaxLength(100)]
        public string Student_Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "THE STUDENT PASSWORD IS REQUIRED")]
        [MaxLength(50)]
        public int Password_Student { get; set; }
        //public decimal GPA { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public DateTime? UpdatedDate { get; private set; }




    }
}
//CREATE TABLE Students (
//    Student_ID INT PRIMARY KEY,
//    Name NVARCHAR(100) NOT NULL,
//    Email NVARCHAR(100) UNIQUE NOT NULL,
//    Phone_Number NVARCHAR(20),
//    GPA DECIMAL(3, 2),
//    Created_At DATETIME DEFAULT GETDATE(),
//    Last_Updated_At DATETIME DEFAULT GETDATE()
//);


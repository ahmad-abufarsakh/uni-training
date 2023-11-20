using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using UNI_Training_System.Models;

namespace UNI_Training_System.Models
{
    public class Company
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]// Sequential ID 
        public int Company_ID { get; set; }
        [Required(AllowEmptyStrings =false ,ErrorMessage ="THE COMPANY NAME IS REQUIRED ")]//show error message for the user.
        [MaxLength(100)]
        public string Company_Name { get; set;}
        [Required(AllowEmptyStrings = false, ErrorMessage = "INSERT FIELD TRAINING IS REQUIRED ")]
        [MaxLength(100)]
        public string Training_Field { get; set;}
       
        public DateTime Last_updated_At { get; set;}





    }
}
//Companies Table
//CREATE TABLE Companies (
//    Company_ID INT PRIMARY KEY,
//   Name NVARCHAR(100) NOT NULL,
//   Industry NVARCHAR(100),
//    Contact_Person NVARCHAR(100),
//    Created_At DATETIME DEFAULT GETDATE(),
//    Last_Updated_At DATETIME DEFAULT GETDATE()
//);

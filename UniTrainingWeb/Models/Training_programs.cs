using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;

namespace UNI_Training_System.Models
{
    public class Training_programs
    {
        [Key]
        public int Program_ID { get; set; }
        //[ForeignKey]
        public int Company_ID { get; set; }
        //[ForeignKey]
        //public int University_ID { get; set; }
        public string Training_Field { get; set; }
        //[Optional]
        public string Program_Description { get; set; }
    }
}
//Training Programs Table
//CREATE TABLE TrainingPrograms (
//    Program_ID INT PRIMARY KEY,
//   Company_ID INT,
//   University_ID INT,
//   Program_Description NVARCHAR(MAX),
//   ................. Eligibility_Requirements NVARCHAR(MAX),
//    Application_Process NVARCHAR(MAX),
//    Created_At DATETIME DEFAULT GETDATE(),
//    Last_Updated_At DATETIME DEFAULT GETDATE(),
//    FOREIGN KEY(Company_ID) REFERENCES Companies(Company_ID),
//    FOREIGN KEY(University_ID) REFERENCES Universities(University_ID)
//);

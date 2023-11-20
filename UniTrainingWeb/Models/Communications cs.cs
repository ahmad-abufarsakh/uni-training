using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Xml;
using System.Linq;


namespace UNI_Training_System.Models
{
    public class Communications_cs
    {
        [Key]
        public int Communication_ID { get; set; }
        //[ForeignKey]
        public int Sender_ID { get; set; }
        //[ForeignKey]
        public int Reciver_ID { get;}
        public string Meassage { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
//Communications Table
//CREATE TABLE Communications (
//    Communication_ID INT PRIMARY KEY,
//    Sender_ID INT,
//    Receiver_ID INT,
//    Message NVARCHAR(MAX),
//    Timestamp DATETIME DEFAULT GETDATE(),
//    FOREIGN KEY(Sender_ID) REFERENCES Students(Student_ID) ON DELETE CASCADE,
//    FOREIGN KEY (Receiver_ID) REFERENCES Students(Student_ID) ON DELETE CASCADE,
//    Created_At DATETIME DEFAULT GETDATE()
//);


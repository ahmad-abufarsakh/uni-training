using Microsoft.EntityFrameworkCore;//DbContext exist in EntityFramworkCore.
using UNI_Training_System.Models;
using Microsoft.Extensions.Options;


namespace UNI_Training_System //this class will communicate with Data Base.
{
    public class UNITrainingDbContext :DbContext
    {
        public UNITrainingDbContext(DbContextOptions<UNITrainingDbContext> options): base(options) 
        {


        }
        public  DbSet<University> Universities { get; set; }//create TAble
        public  DbSet<Company> companies { get; set; }//create TAble
        public  DbSet<Student> Students { get; set; }//create TAble
        public  DbSet<Training_programs> training_Programs { get; set; }//create TAble
        public  DbSet<Communications_cs> communications { get; set; }//create TAble
    }
}

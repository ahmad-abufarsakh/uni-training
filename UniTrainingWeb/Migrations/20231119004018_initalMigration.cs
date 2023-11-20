using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNI_Training_System.Migrations
{
    /// <inheritdoc />
    public partial class initalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "communications",
                columns: table => new
                {
                    Communication_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender_ID = table.Column<int>(type: "int", nullable: false),
                    Meassage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_communications", x => x.Communication_ID);
                });

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    Company_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Training_Field = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Last_updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.Company_ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Student_Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password_Student = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Student_ID);
                });

            migrationBuilder.CreateTable(
                name: "training_Programs",
                columns: table => new
                {
                    Program_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_ID = table.Column<int>(type: "int", nullable: false),
                    Training_Field = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Program_Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_training_Programs", x => x.Program_ID);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    University_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    University_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Student_ID = table.Column<int>(type: "int", nullable: false),
                    Student_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password_Student = table.Column<int>(type: "int", nullable: false),
                    Company_ID = table.Column<int>(type: "int", nullable: false),
                    Company_Name = table.Column<int>(type: "int", nullable: false),
                    Training_Field = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.University_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "communications");

            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "training_Programs");

            migrationBuilder.DropTable(
                name: "Universities");
        }
    }
}

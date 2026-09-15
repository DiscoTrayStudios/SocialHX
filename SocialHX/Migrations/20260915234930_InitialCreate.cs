using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialHX.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Event_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Event_ID);
                });

            migrationBuilder.CreateTable(
                name: "Follow_Up",
                columns: table => new
                {
                    Follow_Up_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Case_Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Response = table.Column<bool>(type: "INTEGER", nullable: false),
                    Student_Report = table.Column<string>(type: "TEXT", nullable: false),
                    Student_Adjustments = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follow_Up", x => x.Follow_Up_ID);
                });

            migrationBuilder.CreateTable(
                name: "Prescribed_Event",
                columns: table => new
                {
                    Prescribed_Event_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    Other_Person = table.Column<string>(type: "TEXT", nullable: false),
                    Event_ID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescribed_Event", x => x.Prescribed_Event_ID);
                });

            migrationBuilder.CreateTable(
                name: "Prescriber",
                columns: table => new
                {
                    Prescriber_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Department = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriber", x => x.Prescriber_ID);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    Case_Number = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Student_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Prescriber_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Date_Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Event1_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Event2_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Event3_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Event4_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Follow_Up_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Follow_Up_Refill_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.Case_Number);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Student_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Follow_Up");

            migrationBuilder.DropTable(
                name: "Prescribed_Event");

            migrationBuilder.DropTable(
                name: "Prescriber");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class ver3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    OptionName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.OptionId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "QuizUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    ResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.ResultId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    User_Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerText", "QuestionId" },
                values: new object[,]
                {
                    { 1, "GC.Collect();", 1 },
                    { 18, "14", 18 },
                    { 17, "12", 17 },
                    { 15, "6", 15 },
                    { 14, "11", 14 },
                    { 13, "60", 13 },
                    { 12, "4", 12 },
                    { 11, "10", 11 },
                    { 10, "20", 10 },
                    { 16, "8", 16 },
                    { 8, "виртуальным", 8 },
                    { 7, "Type", 7 },
                    { 6, "XmlSerializer", 6 },
                    { 5, "применить атрибут NonSerialized", 5 },
                    { 4, "приводит к остановке его работы", 4 },
                    { 3, "3", 3 },
                    { 2, "OutOfMemoryflowException", 2 },
                    { 9, "2", 9 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "c#" },
                    { 2, "Алгебра" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "OptionId", "OptionName", "QuestionId" },
                values: new object[,]
                {
                    { 40, "12", 14 },
                    { 39, "20", 13 },
                    { 38, "60", 13 },
                    { 37, "40", 13 },
                    { 36, "4", 12 },
                    { 31, "10", 11 },
                    { 34, "1", 12 },
                    { 33, "9", 11 },
                    { 32, "2", 11 },
                    { 41, "11", 14 },
                    { 35, "2", 12 },
                    { 42, "13", 14 },
                    { 52, "5", 18 },
                    { 44, "5", 15 },
                    { 45, "16", 15 },
                    { 46, "2", 16 },
                    { 47, "8", 16 },
                    { 48, "6", 16 },
                    { 49, "12", 17 },
                    { 50, "22", 17 },
                    { 51, "21", 17 },
                    { 30, "22", 10 }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "OptionId", "OptionName", "QuestionId" },
                values: new object[,]
                {
                    { 53, "16", 18 },
                    { 54, "14", 18 },
                    { 43, "6", 15 },
                    { 29, "20", 10 },
                    { 28, "34", 10 },
                    { 3, "GC.SeppressFinalize();", 1 },
                    { 1, "GC.Collect();", 1 },
                    { 2, "GC.KeepAlive();", 1 },
                    { 27, "2", 9 },
                    { 4, "OutOfMemoryflowException", 2 },
                    { 6, "StackOverflowExeption", 2 },
                    { 7, "4", 3 },
                    { 8, "1", 3 },
                    { 9, "3", 3 },
                    { 10, "игнорируется", 4 },
                    { 11, "приводит к остановке его работы", 4 },
                    { 12, "обрабатывается", 4 },
                    { 13, "применить метод OnDeserialization()", 5 },
                    { 5, "HeepOverflowException", 2 },
                    { 15, "применить атрибут NonSerialized", 5 },
                    { 14, "применить атрибут NonSerializing", 5 },
                    { 26, "-1", 9 },
                    { 25, "3", 9 },
                    { 23, "абстрактным", 8 },
                    { 22, "виртуальным", 8 },
                    { 24, "запечатаный", 8 },
                    { 20, "Type", 7 },
                    { 19, "Assembly", 7 },
                    { 18, "XmlSerializer", 6 },
                    { 17, "XmlSerialization", 6 },
                    { 16, "XmlSerialisable", 6 },
                    { 21, "Reflector", 7 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "CategoryId", "QuestionText" },
                values: new object[,]
                {
                    { 17, 2, "6 + 6 = ?" },
                    { 11, 2, "5 + 5 = ?" },
                    { 16, 2, "4 + 4 = ?" },
                    { 15, 2, "3 + 3 = ?" },
                    { 14, 2, "10 + 1 = ?" },
                    { 13, 2, "100 - 50 + 10 = ?" },
                    { 12, 2, "2 + 2 = ?" },
                    { 10, 2, "10 + 10 = ?" },
                    { 3, 1, "Сколько поколений поддерживает GarbageCollector?" },
                    { 8, 1, "Метод ToString() базового класа object является:" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "CategoryId", "QuestionText" },
                values: new object[,]
                {
                    { 7, 1, "Основным классом в пространстве имен System.Reflaction является класс:" },
                    { 6, 1, "Какой объект используеться при XML сериализации?" },
                    { 5, 1, "Для отключения сериализации ненужных членов нужно:" },
                    { 4, 1, "Необработанное исключение в деструкторе:" },
                    { 2, 1, "Исключение при переполнении памяти в управляемой куче?" },
                    { 1, 1, "Как можно принудительно запустить сборку мусора?" },
                    { 18, 2, "7 + 7 = ?" },
                    { 9, 2, "1 + 1 = ?" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "User_Name" },
                values: new object[,]
                {
                    { 2, "Ivan@gmail.com", "Aaaaa6aa", "Vova" },
                    { 3, "Vlad@gmail.com", "PrOfi4ek3", "Liza" },
                    { 1, "gregor@gmail.com", "Aaaaa6aa", "Jhon" },
                    { 4, "Dima@gmail.com", "GjRf563K", "Kto-to" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "QuizUsers");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class MyDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<QuizUser> QuizUsers { get; set; }
       /* public MyDBContext()
        {
           
        }*/
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
            Database.Migrate();
            
        }
      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=userwebdb;Trusted_Connection=True");
            }
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answers");
                entity.Property(e => e.AnswerText).IsRequired().HasMaxLength(400);

                entity.HasOne(q => q.Question)
                .WithMany(a => a.Answers)
                .HasForeignKey(f => f.QuestionId);

            });
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Categories");
                entity.Property(e => e.CategoryName).IsRequired().HasMaxLength(400);
            });
            modelBuilder.Entity<Option>(entity =>
            {
                entity.ToTable("Options");
                entity.Property(e => e.OptionName).IsRequired().HasMaxLength(400);

                entity.HasOne(q => q.Question)
                .WithMany(o => o.Options)
                .HasForeignKey(f => f.QuestionId);
            });
            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Questions");
                entity.Property(e => e.QuestionText).IsRequired().HasMaxLength(400);

                entity.HasOne(c => c.Category)
                .WithMany(q => q.Questions)
                .HasForeignKey(f => f.CategoryId);

            });
            modelBuilder.Entity<Result>(entity =>
            {
                entity.ToTable("Results");
                entity.Property(e => e.AnswerText).IsRequired().HasMaxLength(400);
            });
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category{CategoryId = 1,CategoryName ="c#"},
                new Category{CategoryId = 2,CategoryName = "Алгебра"}
            });
            modelBuilder.Entity<Question>().HasData(new Question[] 
            {
                //c#
                new Question{QuestionId = 1,CategoryId = 1,QuestionText ="Как можно принудительно запустить сборку мусора?"},
                new Question{QuestionId = 2,CategoryId = 1,QuestionText ="Исключение при переполнении памяти в управляемой куче?"},
                new Question{QuestionId = 3,CategoryId = 1,QuestionText ="Сколько поколений поддерживает GarbageCollector?"},
                new Question{QuestionId = 4,CategoryId = 1,QuestionText ="Необработанное исключение в деструкторе:"},
                new Question{QuestionId = 5,CategoryId = 1,QuestionText ="Для отключения сериализации ненужных членов нужно:"},
                new Question{QuestionId = 6,CategoryId = 1,QuestionText ="Какой объект используеться при XML сериализации?"},
                new Question{QuestionId = 7,CategoryId = 1,QuestionText ="Основным классом в пространстве имен System.Reflaction является класс:"},
                new Question{QuestionId = 8,CategoryId = 1,QuestionText ="Метод ToString() базового класа object является:"},
 
                //Math
                new Question{QuestionId = 9,CategoryId = 2,QuestionText ="1 + 1 = ?"},
                new Question{QuestionId = 10,CategoryId = 2,QuestionText ="10 + 10 = ?"},
                new Question{QuestionId = 11,CategoryId = 2,QuestionText ="5 + 5 = ?"},
                new Question{QuestionId = 12,CategoryId = 2,QuestionText ="2 + 2 = ?"},
                new Question{QuestionId = 13,CategoryId = 2,QuestionText ="100 - 50 + 10 = ?"},
                new Question{QuestionId = 14,CategoryId = 2,QuestionText ="10 + 1 = ?"},
                new Question{QuestionId = 15,CategoryId = 2,QuestionText ="3 + 3 = ?"},
                new Question{QuestionId = 16,CategoryId = 2,QuestionText ="4 + 4 = ?"},
                new Question{QuestionId = 17,CategoryId = 2,QuestionText ="6 + 6 = ?"},
                new Question{QuestionId = 18,CategoryId = 2,QuestionText ="7 + 7 = ?"},

            });
            modelBuilder.Entity<Option>().HasData(new Option[]
            {   
                //c#

                //Как можно принудительно запустить сборку мусора? 1
                new Option{OptionId = 1,QuestionId = 1,OptionName = "GC.Collect();"},//*
                new Option{OptionId = 2,QuestionId = 1,OptionName = "GC.KeepAlive();"},
                new Option{OptionId = 3,QuestionId = 1,OptionName = "GC.SeppressFinalize();"},
                //Исключение при переполнении памяти в управляемой куче? 2
                new Option{OptionId = 4,QuestionId = 2,OptionName = "OutOfMemoryflowException"},//*
                new Option{OptionId = 5,QuestionId = 2,OptionName = "HeepOverflowException"},
                new Option{OptionId = 6,QuestionId = 2,OptionName = "StackOverflowExeption"},
                //Сколько поколений поддерживает GarbageCollector? 3
                new Option{OptionId = 7,QuestionId = 3,OptionName = "4"},
                new Option{OptionId = 8,QuestionId = 3,OptionName = "1"},
                new Option{OptionId = 9,QuestionId = 3,OptionName = "3"},//*
                //Необработанное исключение в деструкторе: 4
                new Option{OptionId = 10,QuestionId = 4,OptionName = "игнорируется"},
                new Option{OptionId = 11,QuestionId = 4,OptionName = "приводит к остановке его работы"},//*
                new Option{OptionId = 12,QuestionId = 4,OptionName = "обрабатывается"},
                //Для отключения сериализации ненужных членов нужно: 5
                new Option{OptionId = 13,QuestionId = 5,OptionName ="применить метод OnDeserialization()"},
                new Option{OptionId = 14,QuestionId = 5,OptionName = "применить атрибут NonSerializing"},
                new Option{OptionId = 15,QuestionId = 5,OptionName ="применить атрибут NonSerialized"},//*
                //Какой объект используеться при XML сериализации? 6
                new Option{OptionId = 16,QuestionId = 6,OptionName = "XmlSerialisable"},
                new Option{OptionId = 17,QuestionId = 6,OptionName ="XmlSerialization"},
                new Option{OptionId = 18,QuestionId = 6,OptionName = "XmlSerializer"},//*
                //Основным классом в пространстве имен System.Reflaction является класс: 7
                new Option{OptionId = 19,QuestionId = 7,OptionName = "Assembly"},
                new Option{OptionId = 20,QuestionId = 7,OptionName = "Type"},//*
                new Option{OptionId = 21,QuestionId = 7,OptionName = "Reflector"},
                //Метод ToString() базового класа object является: 8
                new Option{OptionId = 22,QuestionId = 8,OptionName = "виртуальным"},//*
                new Option{OptionId = 23,QuestionId = 8,OptionName = "абстрактным"},
                new Option{OptionId = 24,QuestionId = 8,OptionName = "запечатаный"},
                


                //Math
                

                //1 + 1 = ? 9
                new Option{OptionId = 25,QuestionId = 9, OptionName = "3"},
                new Option{OptionId = 26,QuestionId = 9, OptionName = "-1"},
                new Option{OptionId = 27,QuestionId = 9, OptionName = "2"},//*
                //10 + 10 = ? 10
                new Option{OptionId = 28,QuestionId = 10,OptionName = "34"},
                new Option{OptionId = 29,QuestionId = 10,OptionName = "20"},//*
                new Option{OptionId = 30,QuestionId = 10,OptionName = "22"},
                //5 + 5 = ? 11
                new Option{OptionId = 31,QuestionId = 11,OptionName = "10"},//*
                new Option{OptionId = 32,QuestionId = 11,OptionName = "2"},
                new Option{OptionId = 33,QuestionId = 11,OptionName = "9"},
                //2 + 2 = ? 12
                new Option{OptionId = 34,QuestionId = 12,OptionName = "1"},
                new Option{OptionId = 35,QuestionId = 12,OptionName = "2"},
                new Option{OptionId = 36,QuestionId = 12,OptionName = "4"},//*
                //100 - 50 + 10 = ? 13
                new Option{OptionId = 37,QuestionId = 13,OptionName = "40"},
                new Option{OptionId = 38,QuestionId = 13,OptionName = "60"},//*
                new Option{OptionId = 39,QuestionId = 13,OptionName = "20"},
                //10 + 1 = ? 14
                new Option{OptionId = 40,QuestionId = 14,OptionName = "12"},
                new Option{OptionId = 41,QuestionId = 14,OptionName = "11"},//*
                new Option{OptionId = 42,QuestionId = 14,OptionName = "13"},
                //3 + 3 = ? 15
                new Option{OptionId = 43,QuestionId = 15,OptionName = "6"},//*
                new Option{OptionId = 44,QuestionId = 15,OptionName = "5"},
                new Option{OptionId = 45,QuestionId = 15,OptionName = "16"},
                //4 + 4 = ? 16
                new Option{OptionId = 46,QuestionId = 16,OptionName = "2"},
                new Option{OptionId = 47,QuestionId = 16,OptionName = "8"},//*
                new Option{OptionId = 48,QuestionId = 16,OptionName = "6"},
                //6 + 6 = ? 17
                new Option{OptionId = 49,QuestionId = 17,OptionName = "12"},//*
                new Option{OptionId = 50,QuestionId = 17,OptionName = "22"},
                new Option{OptionId = 51,QuestionId = 17,OptionName = "21"},
                //7 + 7 = ? 18
                new Option{OptionId = 52,QuestionId = 18,OptionName = "5"},
                new Option{OptionId = 53,QuestionId = 18,OptionName = "16"},
                new Option{OptionId = 54,QuestionId = 18,OptionName = "14"},//*
                



            });
            modelBuilder.Entity<Answer>().HasData(new Answer[]
            {
                //c#
                new Answer{AnswerId = 1,QuestionId = 1,AnswerText = "GC.Collect();"},
                new Answer{AnswerId = 2,QuestionId = 2,AnswerText = "OutOfMemoryflowException"},
                new Answer{AnswerId = 3,QuestionId = 3,AnswerText = "3"},
                new Answer{AnswerId = 4,QuestionId = 4,AnswerText = "приводит к остановке его работы"},
                new Answer{AnswerId = 5,QuestionId = 5,AnswerText = "применить атрибут NonSerialized"},
                new Answer{AnswerId = 6,QuestionId = 6,AnswerText = "XmlSerializer"},
                new Answer{AnswerId = 7,QuestionId = 7,AnswerText = "Type"},
                new Answer{AnswerId = 8,QuestionId = 8,AnswerText = "виртуальным"},

                //Math
                new Answer{AnswerId = 9,QuestionId = 9,AnswerText = "2"},
                new Answer{AnswerId = 10,QuestionId = 10,AnswerText = "20"},
                new Answer{AnswerId = 11,QuestionId = 11,AnswerText = "10"},
                new Answer{AnswerId = 12,QuestionId = 12,AnswerText = "4"},
                new Answer{AnswerId = 13,QuestionId = 13,AnswerText = "60"},
                new Answer{AnswerId = 14,QuestionId = 14,AnswerText = "11"},
                new Answer{AnswerId = 15,QuestionId = 15,AnswerText = "6"},
                new Answer{AnswerId = 16,QuestionId = 16,AnswerText = "8"},
                new Answer{AnswerId = 17,QuestionId = 17,AnswerText = "12"},
                new Answer{AnswerId = 18,QuestionId = 18,AnswerText = "14"},
            });
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User{Id = 1,Email = "gregor@gmail.com",Password = "Aaaaa6aa", User_Name = "Jhon"},
                new User{Id = 2,Email = "Ivan@gmail.com",Password = "Aaaaa6aa",User_Name="Vova"},
                new User{Id = 3,Email = "Vlad@gmail.com",Password = "PrOfi4ek3",User_Name ="Liza"},
                new User{Id = 4,Email = "Dima@gmail.com",Password = "GjRf563K",User_Name ="Kto-to"},
            });

        }
        //Ktoto445@gmail.com  pass - gjrfgjRF5
    }
}

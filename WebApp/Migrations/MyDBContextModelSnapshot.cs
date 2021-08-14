﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Models;

namespace WebApp.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            AnswerId = 1,
                            AnswerText = "GC.Collect();",
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 2,
                            AnswerText = "OutOfMemoryflowException",
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 3,
                            AnswerText = "3",
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 4,
                            AnswerText = "приводит к остановке его работы",
                            QuestionId = 4
                        },
                        new
                        {
                            AnswerId = 5,
                            AnswerText = "применить атрибут NonSerialized",
                            QuestionId = 5
                        },
                        new
                        {
                            AnswerId = 6,
                            AnswerText = "XmlSerializer",
                            QuestionId = 6
                        },
                        new
                        {
                            AnswerId = 7,
                            AnswerText = "Type",
                            QuestionId = 7
                        },
                        new
                        {
                            AnswerId = 8,
                            AnswerText = "виртуальным",
                            QuestionId = 8
                        },
                        new
                        {
                            AnswerId = 9,
                            AnswerText = "2",
                            QuestionId = 9
                        },
                        new
                        {
                            AnswerId = 10,
                            AnswerText = "20",
                            QuestionId = 10
                        },
                        new
                        {
                            AnswerId = 11,
                            AnswerText = "10",
                            QuestionId = 11
                        },
                        new
                        {
                            AnswerId = 12,
                            AnswerText = "4",
                            QuestionId = 12
                        },
                        new
                        {
                            AnswerId = 13,
                            AnswerText = "60",
                            QuestionId = 13
                        },
                        new
                        {
                            AnswerId = 14,
                            AnswerText = "11",
                            QuestionId = 14
                        },
                        new
                        {
                            AnswerId = 15,
                            AnswerText = "6",
                            QuestionId = 15
                        },
                        new
                        {
                            AnswerId = 16,
                            AnswerText = "8",
                            QuestionId = 16
                        },
                        new
                        {
                            AnswerId = 17,
                            AnswerText = "12",
                            QuestionId = 17
                        },
                        new
                        {
                            AnswerId = 18,
                            AnswerText = "14",
                            QuestionId = 18
                        });
                });

            modelBuilder.Entity("WebApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "c#"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Алгебра"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Option", b =>
                {
                    b.Property<int>("OptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OptionName")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("OptionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Options");

                    b.HasData(
                        new
                        {
                            OptionId = 1,
                            OptionName = "GC.Collect();",
                            QuestionId = 1
                        },
                        new
                        {
                            OptionId = 2,
                            OptionName = "GC.KeepAlive();",
                            QuestionId = 1
                        },
                        new
                        {
                            OptionId = 3,
                            OptionName = "GC.SeppressFinalize();",
                            QuestionId = 1
                        },
                        new
                        {
                            OptionId = 4,
                            OptionName = "OutOfMemoryflowException",
                            QuestionId = 2
                        },
                        new
                        {
                            OptionId = 5,
                            OptionName = "HeepOverflowException",
                            QuestionId = 2
                        },
                        new
                        {
                            OptionId = 6,
                            OptionName = "StackOverflowExeption",
                            QuestionId = 2
                        },
                        new
                        {
                            OptionId = 7,
                            OptionName = "4",
                            QuestionId = 3
                        },
                        new
                        {
                            OptionId = 8,
                            OptionName = "1",
                            QuestionId = 3
                        },
                        new
                        {
                            OptionId = 9,
                            OptionName = "3",
                            QuestionId = 3
                        },
                        new
                        {
                            OptionId = 10,
                            OptionName = "игнорируется",
                            QuestionId = 4
                        },
                        new
                        {
                            OptionId = 11,
                            OptionName = "приводит к остановке его работы",
                            QuestionId = 4
                        },
                        new
                        {
                            OptionId = 12,
                            OptionName = "обрабатывается",
                            QuestionId = 4
                        },
                        new
                        {
                            OptionId = 13,
                            OptionName = "применить метод OnDeserialization()",
                            QuestionId = 5
                        },
                        new
                        {
                            OptionId = 14,
                            OptionName = "применить атрибут NonSerializing",
                            QuestionId = 5
                        },
                        new
                        {
                            OptionId = 15,
                            OptionName = "применить атрибут NonSerialized",
                            QuestionId = 5
                        },
                        new
                        {
                            OptionId = 16,
                            OptionName = "XmlSerialisable",
                            QuestionId = 6
                        },
                        new
                        {
                            OptionId = 17,
                            OptionName = "XmlSerialization",
                            QuestionId = 6
                        },
                        new
                        {
                            OptionId = 18,
                            OptionName = "XmlSerializer",
                            QuestionId = 6
                        },
                        new
                        {
                            OptionId = 19,
                            OptionName = "Assembly",
                            QuestionId = 7
                        },
                        new
                        {
                            OptionId = 20,
                            OptionName = "Type",
                            QuestionId = 7
                        },
                        new
                        {
                            OptionId = 21,
                            OptionName = "Reflector",
                            QuestionId = 7
                        },
                        new
                        {
                            OptionId = 22,
                            OptionName = "виртуальным",
                            QuestionId = 8
                        },
                        new
                        {
                            OptionId = 23,
                            OptionName = "абстрактным",
                            QuestionId = 8
                        },
                        new
                        {
                            OptionId = 24,
                            OptionName = "запечатаный",
                            QuestionId = 8
                        },
                        new
                        {
                            OptionId = 25,
                            OptionName = "3",
                            QuestionId = 9
                        },
                        new
                        {
                            OptionId = 26,
                            OptionName = "-1",
                            QuestionId = 9
                        },
                        new
                        {
                            OptionId = 27,
                            OptionName = "2",
                            QuestionId = 9
                        },
                        new
                        {
                            OptionId = 28,
                            OptionName = "34",
                            QuestionId = 10
                        },
                        new
                        {
                            OptionId = 29,
                            OptionName = "20",
                            QuestionId = 10
                        },
                        new
                        {
                            OptionId = 30,
                            OptionName = "22",
                            QuestionId = 10
                        },
                        new
                        {
                            OptionId = 31,
                            OptionName = "10",
                            QuestionId = 11
                        },
                        new
                        {
                            OptionId = 32,
                            OptionName = "2",
                            QuestionId = 11
                        },
                        new
                        {
                            OptionId = 33,
                            OptionName = "9",
                            QuestionId = 11
                        },
                        new
                        {
                            OptionId = 34,
                            OptionName = "1",
                            QuestionId = 12
                        },
                        new
                        {
                            OptionId = 35,
                            OptionName = "2",
                            QuestionId = 12
                        },
                        new
                        {
                            OptionId = 36,
                            OptionName = "4",
                            QuestionId = 12
                        },
                        new
                        {
                            OptionId = 37,
                            OptionName = "40",
                            QuestionId = 13
                        },
                        new
                        {
                            OptionId = 38,
                            OptionName = "60",
                            QuestionId = 13
                        },
                        new
                        {
                            OptionId = 39,
                            OptionName = "20",
                            QuestionId = 13
                        },
                        new
                        {
                            OptionId = 40,
                            OptionName = "12",
                            QuestionId = 14
                        },
                        new
                        {
                            OptionId = 41,
                            OptionName = "11",
                            QuestionId = 14
                        },
                        new
                        {
                            OptionId = 42,
                            OptionName = "13",
                            QuestionId = 14
                        },
                        new
                        {
                            OptionId = 43,
                            OptionName = "6",
                            QuestionId = 15
                        },
                        new
                        {
                            OptionId = 44,
                            OptionName = "5",
                            QuestionId = 15
                        },
                        new
                        {
                            OptionId = 45,
                            OptionName = "16",
                            QuestionId = 15
                        },
                        new
                        {
                            OptionId = 46,
                            OptionName = "2",
                            QuestionId = 16
                        },
                        new
                        {
                            OptionId = 47,
                            OptionName = "8",
                            QuestionId = 16
                        },
                        new
                        {
                            OptionId = 48,
                            OptionName = "6",
                            QuestionId = 16
                        },
                        new
                        {
                            OptionId = 49,
                            OptionName = "12",
                            QuestionId = 17
                        },
                        new
                        {
                            OptionId = 50,
                            OptionName = "22",
                            QuestionId = 17
                        },
                        new
                        {
                            OptionId = 51,
                            OptionName = "21",
                            QuestionId = 17
                        },
                        new
                        {
                            OptionId = 52,
                            OptionName = "5",
                            QuestionId = 18
                        },
                        new
                        {
                            OptionId = 53,
                            OptionName = "16",
                            QuestionId = 18
                        },
                        new
                        {
                            OptionId = 54,
                            OptionName = "14",
                            QuestionId = 18
                        });
                });

            modelBuilder.Entity("WebApp.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("QuestionId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            CategoryId = 1,
                            QuestionText = "Как можно принудительно запустить сборку мусора?"
                        },
                        new
                        {
                            QuestionId = 2,
                            CategoryId = 1,
                            QuestionText = "Исключение при переполнении памяти в управляемой куче?"
                        },
                        new
                        {
                            QuestionId = 3,
                            CategoryId = 1,
                            QuestionText = "Сколько поколений поддерживает GarbageCollector?"
                        },
                        new
                        {
                            QuestionId = 4,
                            CategoryId = 1,
                            QuestionText = "Необработанное исключение в деструкторе:"
                        },
                        new
                        {
                            QuestionId = 5,
                            CategoryId = 1,
                            QuestionText = "Для отключения сериализации ненужных членов нужно:"
                        },
                        new
                        {
                            QuestionId = 6,
                            CategoryId = 1,
                            QuestionText = "Какой объект используеться при XML сериализации?"
                        },
                        new
                        {
                            QuestionId = 7,
                            CategoryId = 1,
                            QuestionText = "Основным классом в пространстве имен System.Reflaction является класс:"
                        },
                        new
                        {
                            QuestionId = 8,
                            CategoryId = 1,
                            QuestionText = "Метод ToString() базового класа object является:"
                        },
                        new
                        {
                            QuestionId = 9,
                            CategoryId = 2,
                            QuestionText = "1 + 1 = ?"
                        },
                        new
                        {
                            QuestionId = 10,
                            CategoryId = 2,
                            QuestionText = "10 + 10 = ?"
                        },
                        new
                        {
                            QuestionId = 11,
                            CategoryId = 2,
                            QuestionText = "5 + 5 = ?"
                        },
                        new
                        {
                            QuestionId = 12,
                            CategoryId = 2,
                            QuestionText = "2 + 2 = ?"
                        },
                        new
                        {
                            QuestionId = 13,
                            CategoryId = 2,
                            QuestionText = "100 - 50 + 10 = ?"
                        },
                        new
                        {
                            QuestionId = 14,
                            CategoryId = 2,
                            QuestionText = "10 + 1 = ?"
                        },
                        new
                        {
                            QuestionId = 15,
                            CategoryId = 2,
                            QuestionText = "3 + 3 = ?"
                        },
                        new
                        {
                            QuestionId = 16,
                            CategoryId = 2,
                            QuestionText = "4 + 4 = ?"
                        },
                        new
                        {
                            QuestionId = 17,
                            CategoryId = 2,
                            QuestionText = "6 + 6 = ?"
                        },
                        new
                        {
                            QuestionId = 18,
                            CategoryId = 2,
                            QuestionText = "7 + 7 = ?"
                        });
                });

            modelBuilder.Entity("WebApp.Models.QuizUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("UserId");

                    b.ToTable("QuizUsers");
                });

            modelBuilder.Entity("WebApp.Models.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ResultId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("WebApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("User_Name")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "gregor@gmail.com",
                            Password = "Aaaaa6aa",
                            User_Name = "Jhon"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Ivan@gmail.com",
                            Password = "Aaaaa6aa",
                            User_Name = "Vova"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Vlad@gmail.com",
                            Password = "PrOfi4ek3",
                            User_Name = "Liza"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Dima@gmail.com",
                            Password = "GjRf563K",
                            User_Name = "Kto-to"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Answer", b =>
                {
                    b.HasOne("WebApp.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("WebApp.Models.Option", b =>
                {
                    b.HasOne("WebApp.Models.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("WebApp.Models.Question", b =>
                {
                    b.HasOne("WebApp.Models.Category", "Category")
                        .WithMany("Questions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebApp.Models.Category", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("WebApp.Models.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Options");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Demo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.Migrations
{
    [DbContext(typeof(DemoDBContext))]
    [Migration("20211122012412_Alter_Table_Student")]
    partial class Alter_Table_Student
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Demo.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Customer");
                });

            modelBuilder.Entity("Demo.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Demo.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonName")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Demo.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Demo.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Demo.Models.Student1", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.ToTable("Student");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Student1");
                });

            modelBuilder.Entity("Demo.Models.Teacher", b =>
                {
                    b.HasBaseType("Demo.Models.Customer");

                    b.Property<int>("TeacherID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.ToTable("People");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("Demo.Models.School", b =>
                {
                    b.HasBaseType("Demo.Models.Student1");

                    b.Property<int>("TeacherID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.ToTable("Student");

                    b.HasDiscriminator().HasValue("School");
                });
#pragma warning restore 612, 618
        }
    }
}

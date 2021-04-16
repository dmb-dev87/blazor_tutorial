﻿// <auto-generated />
using System;
using BlazorServerCRUD.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorServerCRUD.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorServerCRUD.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            DepartmentName = "Admin"
                        },
                        new
                        {
                            DepartmentID = 2,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentID = 3,
                            DepartmentName = "Payroll"
                        });
                });

            modelBuilder.Entity("BlazorServerCRUD.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            DateOfBirth = new DateTime(1992, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 1,
                            EmployeeName = "John",
                            Gender = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Week_10_Project.Entities;

namespace Week_10_Project.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("Week_10_Project.Models.Car", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<int>("BuildYear");

                    b.Property<string>("CarBody");

                    b.Property<string>("Color");

                    b.Property<string>("FuelType");

                    b.Property<int>("HorsePower");

                    b.Property<string>("Model");

                    b.Property<int>("Seats");

                    b.Property<int>("Torque");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });
        }
    }
}

﻿using System;
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Acceleration");

                    b.Property<int>("BuildYear");

                    b.Property<int>("HorsePower");

                    b.Property<string>("ImageLink");

                    b.Property<string>("Model");

                    b.Property<int>("TopSpeed");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });
        }
    }
}

﻿// <auto-generated />
using ExamApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace ExamApp.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("ExamApp.Models.Car", b =>
                {
                    b.Property<string>("Plate")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(7);

                    b.Property<string>("Car_brand");

                    b.Property<string>("Car_model");

                    b.Property<string>("Color");

                    b.Property<int>("Year");

                    b.HasKey("Plate");

                    b.ToTable("licence_plates");
                });
#pragma warning restore 612, 618
        }
    }
}

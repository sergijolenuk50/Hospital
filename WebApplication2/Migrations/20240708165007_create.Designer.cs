﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20240708165007_create")]
    partial class create
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication2.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Otorhinolaryngologist"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Therapist"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Surgeon"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bacteriologist"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Homeopath"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Endoscopist"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Podiatrist"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Narcologist"
                        });
                });

            modelBuilder.Entity("WebApplication2.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Work_experience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Archived = false,
                            Birthday = new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 3,
                            FirstName = "Grec",
                            ImageUrl = "https://img.freepik.com/free-photo/portrait-of-handsome-bearded-man-outside_23-2150266915.jpg",
                            LastName = "Ivanivuch",
                            Name = "Stepan",
                            Work_experience = 5
                        },
                        new
                        {
                            Id = 2,
                            Archived = false,
                            Birthday = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 8,
                            FirstName = "Ivanov",
                            ImageUrl = "https://cdn.pixabay.com/photo/2016/11/23/00/57/adult-1851571_640.jpg",
                            LastName = "Ivanivuch",
                            Name = "Stanislav",
                            Work_experience = 6
                        },
                        new
                        {
                            Id = 3,
                            Archived = false,
                            Birthday = new DateTime(1981, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 2,
                            FirstName = "Sidorov",
                            ImageUrl = "https://st4.depositphotos.com/1325771/39150/i/450/depositphotos_391507238-stock-photo-confident-smiling-doctor-posing-in.jpg",
                            LastName = "Romanovich",
                            Name = "Sergii",
                            Work_experience = 10
                        });
                });

            modelBuilder.Entity("WebApplication2.Entities.Doctor", b =>
                {
                    b.HasOne("WebApplication2.Entities.Category", "Category")
                        .WithMany("Doctors")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebApplication2.Entities.Category", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
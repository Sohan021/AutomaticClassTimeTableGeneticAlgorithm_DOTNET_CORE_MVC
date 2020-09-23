﻿// <auto-generated />
using ClassTimeTable.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassTimeTable.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200628143744_listas")]
    partial class listas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClassTimeTable.Models.Domain.Batch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BatchCode");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("ClassTimeTable.Models.Domain.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BatchId");

                    b.Property<string>("ClassName");

                    b.Property<int>("CourseId");

                    b.Property<int>("MeetingTimeId");

                    b.Property<int>("RoomId");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("CourseId");

                    b.HasIndex("MeetingTimeId");

                    b.HasIndex("RoomId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("ClassTimeTable.Models.Domain.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BatchId");

                    b.Property<string>("CourseCode");

                    b.Property<string>("CourseTitle");

                    b.Property<int>("InstructorId");

                    b.Property<int>("MaxNumOfStudents");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ClassTimeTable.Models.Domain.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("ClassTimeTable.Models.Domain.MeetingTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Time");

                    b.HasKey("Id");

                    b.ToTable("MeetingTimes");
                });

            modelBuilder.Entity("ClassTimeTable.Models.Domain.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<int>("StudentCapacity");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ClassTimeTable.Models.Domain.Class", b =>
                {
                    b.HasOne("ClassTimeTable.Models.Domain.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClassTimeTable.Models.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClassTimeTable.Models.Domain.MeetingTime", "MeetingTime")
                        .WithMany()
                        .HasForeignKey("MeetingTimeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClassTimeTable.Models.Domain.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClassTimeTable.Models.Domain.Course", b =>
                {
                    b.HasOne("ClassTimeTable.Models.Domain.Batch", "Batch")
                        .WithMany("Courses")
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClassTimeTable.Models.Domain.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

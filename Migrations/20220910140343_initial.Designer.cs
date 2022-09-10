﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductivityWebPage.Model;

#nullable disable

namespace ProductivityWebPage.Migrations
{
    [DbContext(typeof(ScheduleContext))]
    [Migration("20220910140343_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Project", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int>("progress")
                        .HasColumnType("INTEGER");

                    b.Property<int>("streak")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TimeTable", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("project_id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("time")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("TimeTable");
                });

            modelBuilder.Entity("TodoItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Projectid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("project_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Projectid");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("TodoItem", b =>
                {
                    b.HasOne("Project", null)
                        .WithMany("TodoList")
                        .HasForeignKey("Projectid");
                });

            modelBuilder.Entity("Project", b =>
                {
                    b.Navigation("TodoList");
                });
#pragma warning restore 612, 618
        }
    }
}

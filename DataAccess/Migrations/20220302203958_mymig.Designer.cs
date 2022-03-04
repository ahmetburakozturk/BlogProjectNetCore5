﻿// <auto-generated />
using System;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220302203958_mymig")]
    partial class mymig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Entities.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("text");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("text");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("text");

                    b.Property<string>("AboutImage2")
                        .HasColumnType("text");

                    b.Property<string>("AboutMapLocation")
                        .HasColumnType("text");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("boolean");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("Entities.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BlogContent")
                        .HasColumnType("text");

                    b.Property<DateTime>("BlogCreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("BlogImage")
                        .HasColumnType("text");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("BlogThumbnailImage")
                        .HasColumnType("text");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("text");

                    b.Property<int>("CategoryID")
                        .HasColumnType("integer");

                    b.HasKey("BlogID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("text");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("boolean");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BlogID")
                        .HasColumnType("integer");

                    b.Property<string>("CommentContent")
                        .HasColumnType("text");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("text");

                    b.Property<string>("CommentUserName")
                        .HasColumnType("text");

                    b.HasKey("CommentID");

                    b.HasIndex("BlogID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Entities.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ContactMail")
                        .HasColumnType("text");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("text");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("text");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("text");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entities.Concrete.Writer", b =>
                {
                    b.Property<int>("WriterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("WriterAbout")
                        .HasColumnType("text");

                    b.Property<string>("WriterImage")
                        .HasColumnType("text");

                    b.Property<string>("WriterMail")
                        .HasColumnType("text");

                    b.Property<string>("WriterName")
                        .HasColumnType("text");

                    b.Property<string>("WriterPassword")
                        .HasColumnType("text");

                    b.Property<bool>("WriterStatus")
                        .HasColumnType("boolean");

                    b.HasKey("WriterID");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("Entities.Concrete.Blog", b =>
                {
                    b.HasOne("Entities.Concrete.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Concrete.Comment", b =>
                {
                    b.HasOne("Entities.Concrete.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Entities.Concrete.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
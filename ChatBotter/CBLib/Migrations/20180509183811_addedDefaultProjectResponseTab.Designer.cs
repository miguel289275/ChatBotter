﻿// <auto-generated />
using CBLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CBLib.Migrations
{
    [DbContext(typeof(ChatBotContext))]
    [Migration("20180509183811_addedDefaultProjectResponseTab")]
    partial class addedDefaultProjectResponseTab
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("CBLib.Entities.BotResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("PatternId")
                        .HasColumnName("PatternId");

                    b.Property<int>("Priority")
                        .HasColumnName("Priority");

                    b.Property<string>("ResponseText")
                        .HasColumnName("ResponseText");

                    b.Property<int>("TheProjectId")
                        .HasColumnName("TheProjectId");

                    b.HasKey("Id");

                    b.HasIndex("PatternId");

                    b.HasIndex("TheProjectId");

                    b.ToTable("BotResponses");
                });

            modelBuilder.Entity("CBLib.Entities.ContextWrapper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("ExpressionRawStr")
                        .HasColumnName("ExpressionRawStr");

                    b.Property<string>("ExpressionResStr")
                        .HasColumnName("ExpressionResStr");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive");

                    b.Property<int>("Priority")
                        .HasColumnName("Priority");

                    b.Property<int>("ProjectId")
                        .HasColumnName("ProjectId");

                    b.Property<string>("Title")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Contexts");
                });

            modelBuilder.Entity("CBLib.Entities.DefaultBotResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("ResponseText")
                        .IsRequired()
                        .HasColumnName("ResponseText");

                    b.Property<int>("TheProjectId")
                        .HasColumnName("TheProjectId");

                    b.HasKey("Id");

                    b.HasIndex("TheProjectId");

                    b.ToTable("DefaultBotResponses");
                });

            modelBuilder.Entity("CBLib.Entities.Farewell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("MainFarewell")
                        .HasColumnName("MainFarewell");

                    b.Property<int>("ProjectId")
                        .HasColumnName("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Farewells");
                });

            modelBuilder.Entity("CBLib.Entities.Greeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("MainGreeting")
                        .HasColumnName("MainGreeting");

                    b.Property<int>("ProjectId")
                        .HasColumnName("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Greetings");
                });

            modelBuilder.Entity("CBLib.Entities.TheProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("CreatedAt");

                    b.Property<int>("OwnerId")
                        .HasColumnName("OwnerId");

                    b.Property<string>("ProjectDescription")
                        .HasColumnName("ProjectDescription");

                    b.Property<string>("ProjectTitle")
                        .HasColumnName("ProjectTitle");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CBLib.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<bool>("AppAdmin")
                        .HasColumnName("AppAdmin");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnName("PasswordSalt");

                    b.Property<string>("UserName")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CBLib.Entities.BotResponse", b =>
                {
                    b.HasOne("CBLib.Entities.ContextWrapper", "Pattern")
                        .WithMany()
                        .HasForeignKey("PatternId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CBLib.Entities.TheProject", "TheProject")
                        .WithMany()
                        .HasForeignKey("TheProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBLib.Entities.ContextWrapper", b =>
                {
                    b.HasOne("CBLib.Entities.TheProject", "TheProject")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBLib.Entities.DefaultBotResponse", b =>
                {
                    b.HasOne("CBLib.Entities.TheProject", "TheProject")
                        .WithMany()
                        .HasForeignKey("TheProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBLib.Entities.Farewell", b =>
                {
                    b.HasOne("CBLib.Entities.TheProject", "TheProject")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBLib.Entities.Greeting", b =>
                {
                    b.HasOne("CBLib.Entities.TheProject", "TheProject")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CBLib.Entities.TheProject", b =>
                {
                    b.HasOne("CBLib.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

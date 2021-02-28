﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication.Data;

namespace WebApplication.Migrations
{
    [DbContext(typeof(Data.ApplicContext))]
    [Migration("20210228005759_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication.Data.Models.Event", b =>
                {
                    b.Property<int>("eventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isFullDay")
                        .HasColumnType("bit");

                    b.Property<DateTime>("start")
                        .HasColumnType("datetime2");

                    b.Property<string>("subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("themeColor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("eventId");

                    b.ToTable("Event");
                });
#pragma warning restore 612, 618
        }
    }
}

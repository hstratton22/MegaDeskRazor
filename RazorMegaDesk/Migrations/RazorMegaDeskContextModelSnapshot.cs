﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorMegaDesk.Data;

namespace RazorMegaDesk.Migrations
{
    [DbContext(typeof(RazorMegaDeskContext))]
    partial class RazorMegaDeskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorMegaDesk.Models.Deskquote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<int>("DrawerCount")
                        .HasColumnType("int");

                    b.Property<int>("RushDays")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.Property<int>("desktopMaterial")
                        .HasColumnType("int");

                    b.Property<DateTime>("quoteDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Deskquote");
                });
#pragma warning restore 612, 618
        }
    }
}

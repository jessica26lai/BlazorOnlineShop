﻿// <auto-generated />
using System;
using BlazorOnlineShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorOnlineShop.Migrations
{
    [DbContext(typeof(BlazorOnlineShopContext))]
    partial class BlazorOnlineShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorOnlineShop.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateOnly>("AddedDate")
                        .HasColumnType("date");

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("lastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("lastUpdatedDate")
                        .HasColumnType("date");

                    b.Property<int>("viewedCount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}

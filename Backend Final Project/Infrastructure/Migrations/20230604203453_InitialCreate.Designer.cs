﻿// <auto-generated />
using System;
using Infrastructure.Persistence.Configurations.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230604203453_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ModifiedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProductCrawlType")
                        .HasColumnType("int");

                    b.Property<int>("RequestedAmount")
                        .HasColumnType("int");

                    b.Property<int>("TotalFoundAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OrderEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ModifiedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderEvents", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ModifiedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(11,8)");

                    b.Property<decimal?>("SalePrice")
                        .IsRequired()
                        .HasColumnType("decimal(11,8)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("OrderId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OrderEvent", b =>
                {
                    b.HasOne("Domain.Entities.Order", "Order")
                        .WithMany("OrderEvents")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.HasOne("Domain.Entities.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderEvents");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
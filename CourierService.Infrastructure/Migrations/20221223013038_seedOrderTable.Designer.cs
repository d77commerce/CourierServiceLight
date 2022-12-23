﻿// <auto-generated />
using System;
using CourierService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourierService.Infrastructure.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20221223013038_seedOrderTable")]
    partial class seedOrderTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourierService.Infrastructure.Data.Models.Orders.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("TrackingId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("CourierService.Infrastructure.Data.Models.Orders.GetQuickQuote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("ParcelKg")
                        .HasColumnType("float");

                    b.Property<int>("Parts")
                        .HasColumnType("int");

                    b.Property<string>("ReceiverCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GetQuickQuotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ParcelKg = 10.0,
                            Parts = 2,
                            ReceiverCity = "Lovech",
                            ReceiverCountry = "Bulgaria",
                            SenderCity = "Sofia",
                            SenderCountry = "Bulgaria"
                        });
                });

            modelBuilder.Entity("CourierService.Infrastructure.Data.Models.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CustomerMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsFragile")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<double>("ParcelKg")
                        .HasColumnType("float");

                    b.Property<int>("Parts")
                        .HasColumnType("int");

                    b.Property<string>("ReceiverAddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverAddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverPostcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverStreet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderAddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderAddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderPostcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderStreet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerMessage = "Delivery all day before 12:00 !",
                            DateTime = new DateTime(2022, 12, 23, 1, 30, 37, 857, DateTimeKind.Local).AddTicks(6831),
                            IsFragile = true,
                            ParcelKg = 2.456,
                            Parts = 2,
                            ReceiverCity = "Pleven",
                            ReceiverCountry = "Bulgaria",
                            ReceiverFirstName = "Radka",
                            ReceiverLastName = "Piratka",
                            ReceiverPhone = "+359896121478",
                            ReceiverPostcode = "5400",
                            ReceiverStreet = "Nezabravka 4",
                            SenderCity = "Sofia",
                            SenderCountry = "Bulgaria",
                            SenderFirstName = "Pepo",
                            SenderLastName = "Ivanov",
                            SenderMail = "kakapepa@abv.bg",
                            SenderPhone = "+4478976746",
                            SenderPostcode = "1000",
                            SenderStreet = "Vitosha 23"
                        });
                });

            modelBuilder.Entity("CourierService.Infrastructure.Data.Models.Orders.Delivery", b =>
                {
                    b.HasOne("CourierService.Infrastructure.Data.Models.Orders.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}

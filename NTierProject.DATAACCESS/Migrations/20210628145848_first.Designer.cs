﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NTierProject.DATAACCESS.Context;

namespace NTierProject.DATAACCESS.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20210628145848_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD UserName");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD UserName");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD UserName");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<Guid?>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<short?>("Quantity")
                        .HasColumnType("smallint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD UserName");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("QuantityPerUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<short?>("Stock")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD UserName");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.Order", b =>
                {
                    b.HasOne("NTierProject.ENTITIES.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.OrderDetail", b =>
                {
                    b.HasOne("NTierProject.ENTITIES.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID");

                    b.HasOne("NTierProject.ENTITIES.Entities.Product", "Product")
                        .WithMany("OrderDetail")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.Product", b =>
                {
                    b.HasOne("NTierProject.ENTITIES.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.Product", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("NTierProject.ENTITIES.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}

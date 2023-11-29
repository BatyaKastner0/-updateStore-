﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.model;

#nullable disable

namespace Store.model.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20231128175945_ii")]
    partial class ii
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Store.Model.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ClubStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Store.Model.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomersCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("date");

                    b.Property<string>("PaymentMethods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SumPayment")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomersCode");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Store.Model.Products", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"));

                    b.Property<int>("MaxSize")
                        .HasColumnType("int");

                    b.Property<int>("MinSize")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("QtyInventory")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Store.Model.ProductsOrders", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductOrder")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductOrder");

                    b.ToTable("ProductsOrders");
                });

            modelBuilder.Entity("Store.Model.Orders", b =>
                {
                    b.HasOne("Store.Model.Customers", "CustomerCode")
                        .WithMany()
                        .HasForeignKey("CustomersCode");

                    b.Navigation("CustomerCode");
                });

            modelBuilder.Entity("Store.Model.ProductsOrders", b =>
                {
                    b.HasOne("Store.Model.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("Store.Model.Orders", "ProductofOrder")
                        .WithMany("ProductList")
                        .HasForeignKey("ProductOrder");

                    b.Navigation("ProductofOrder");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Store.Model.Orders", b =>
                {
                    b.Navigation("ProductList");
                });
#pragma warning restore 612, 618
        }
    }
}

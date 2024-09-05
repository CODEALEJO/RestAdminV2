﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAdminV2.Models;

#nullable disable

namespace RestAdminV2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240903145800_FieldPdfFileWasAdded")]
    partial class FieldPdfFileWasAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("RestAdmin.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("RestAdmin.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("name");

                    b.Property<string>("Role")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("role");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("schedule");

                    b.HasKey("Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("RestAdminV2.Models.Invoice", b =>
                {
                    b.Property<int>("IdInvoice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_invoice");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdInvoice"));

                    b.Property<DateTime>("DateInvoice")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_invoice");

                    b.Property<int>("OrderedId")
                        .HasColumnType("int")
                        .HasColumnName("id_order");

                    b.Property<byte[]>("PdfFile")
                        .HasColumnType("longblob")
                        .HasColumnName("pdf_file");

                    b.Property<double>("Total")
                        .HasColumnType("double")
                        .HasColumnName("total");

                    b.HasKey("IdInvoice");

                    b.HasIndex("OrderedId");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("RestAdminV2.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderedIded")
                        .HasColumnType("int")
                        .HasColumnName("id_ordered");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int")
                        .HasColumnName("id_product");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double")
                        .HasColumnName("unit_price");

                    b.HasKey("Id");

                    b.HasIndex("OrderedIded");

                    b.HasIndex("IdProduct");

                    b.ToTable("order_details");
                });

            modelBuilder.Entity("RestAdminV2.Models.Ordered", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Employee")
                        .HasColumnType("int")
                        .HasColumnName("employee");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int")
                        .HasColumnName("id_customer");

                    b.Property<int>("IdTable")
                        .HasColumnType("int")
                        .HasColumnName("id_table");

                    b.Property<string>("Name")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdTable");

                    b.ToTable("ordereds");
                });

            modelBuilder.Entity("RestAdminV2.Models.Payment", b =>
                {
                    b.Property<int>("IdPayment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdPayment"));

                    b.Property<double>("Amount")
                        .HasColumnType("double")
                        .HasColumnName("amount");

                    b.Property<DateTime>("DatePayment")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_payment");

                    b.Property<int>("IdInvoice")
                        .HasColumnType("int")
                        .HasColumnName("id_invoice");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("payment_method");

                    b.HasKey("IdPayment");

                    b.HasIndex("IdInvoice");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("RestAdminV2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("RestAdminV2.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("capacity");

                    b.Property<string>("TableNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("table_number");

                    b.HasKey("Id");

                    b.ToTable("tables");
                });

            modelBuilder.Entity("RestAdminV2.Models.Invoice", b =>
                {
                    b.HasOne("RestAdminV2.Models.Ordered", "Ordered")
                        .WithMany()
                        .HasForeignKey("OrderedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ordered");
                });

            modelBuilder.Entity("RestAdminV2.Models.OrderDetails", b =>
                {
                    b.HasOne("RestAdminV2.Models.Ordered", "Ordered")
                        .WithMany()
                        .HasForeignKey("OrderedIded")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestAdminV2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ordered");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RestAdminV2.Models.Ordered", b =>
                {
                    b.HasOne("RestAdmin.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestAdminV2.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("IdTable")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestAdminV2.Models.Payment", b =>
                {
                    b.HasOne("RestAdminV2.Models.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("IdInvoice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");
                });
#pragma warning restore 612, 618
        }
    }
}

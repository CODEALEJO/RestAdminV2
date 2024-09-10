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
    [Migration("20240905152736_AddCategoriesAndCompany")]
    partial class AddCategoriesAndCompany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("RestAdminV2.Models.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_administrator");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTables("administrators");
                });

            modelBuilder.Entity("RestAdminV2.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdProduct")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("IdProduct");

                    b.ToTables("Categories");
                });

            modelBuilder.Entity("RestAdminV2.Models.Customer", b =>
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

                    b.Property<int?>("OrderedId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.HasIndex("OrderedId");

                    b.ToTables("customers");
                });

            modelBuilder.Entity("RestAdminV2.Models.Users", b =>
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

                    b.ToTables("Users");
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

                    b.Property<int?>("PaymentIdPayment")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("double")
                        .HasColumnName("total");

                    b.HasKey("IdInvoice");

                    b.HasIndex("OrderedId");

                    b.HasIndex("PaymentIdPayment");

                    b.ToTables("invoices");
                });

            modelBuilder.Entity("RestAdminV2.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdProduct")
                        .HasColumnType("int")
                        .HasColumnName("id_product");

                    b.Property<int>("OrderedIded")
                        .HasColumnType("int")
                        .HasColumnName("id_ordered");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double")
                        .HasColumnName("unit_price");

                    b.HasKey("Id");

                    b.HasIndex("IdProduct");

                    b.HasIndex("OrderedIded");

                    b.ToTables("order_details");
                });

            modelBuilder.Entity("RestAdminV2.Models.Ordered", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Users")
                        .HasColumnType("int")
                        .HasColumnName("Users");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int")
                        .HasColumnName("id_customer");

                    b.Property<int>("IdTables")
                        .HasColumnType("int")
                        .HasColumnName("id_Tables");

                    b.Property<int?>("InvoiceIdInvoice")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("name");

                    b.Property<int?>("OrderDetailsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdTables");

                    b.HasIndex("InvoiceIdInvoice");

                    b.HasIndex("OrderDetailsId");

                    b.ToTables("ordereds");
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

                    b.ToTables("payments");
                });

            modelBuilder.Entity("RestAdminV2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

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

                    b.Property<int?>("OrderDetailsId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("OrderDetailsId");

                    b.ToTables("products");
                });

            modelBuilder.Entity("RestAdminV2.Models.Tables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("capacity");

                    b.Property<int?>("OrderedId")
                        .HasColumnType("int");

                    b.Property<string>("TablesNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Tables_number");

                    b.HasKey("Id");

                    b.HasIndex("OrderedId");

                    b.ToTables("Tables");
                });

            modelBuilder.Entity("RestAdminV2.Models.Categories", b =>
                {
                    b.HasOne("RestAdminV2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RestAdminV2.Models.Customer", b =>
                {
                    b.HasOne("RestAdminV2.Models.Ordered", null)
                        .WithMany("Customers")
                        .HasForeignKey("OrderedId");
                });

            modelBuilder.Entity("RestAdminV2.Models.Invoice", b =>
                {
                    b.HasOne("RestAdminV2.Models.Ordered", "Ordered")
                        .WithMany()
                        .HasForeignKey("OrderedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAdminV2.Models.Payment", null)
                        .WithMany("Invoices")
                        .HasForeignKey("PaymentIdPayment");

                    b.Navigation("Ordered");
                });

            modelBuilder.Entity("RestAdminV2.Models.OrderDetails", b =>
                {
                    b.HasOne("RestAdminV2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestAdminV2.Models.Ordered", "Ordered")
                        .WithMany()
                        .HasForeignKey("OrderedIded")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ordered");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RestAdminV2.Models.Ordered", b =>
                {
                    b.HasOne("RestAdminV2.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAdminV2.Models.Tables", "Tables")
                        .WithMany()
                        .HasForeignKey("IdTables")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAdminV2.Models.Invoice", null)
                        .WithMany("Ordereds")
                        .HasForeignKey("InvoiceIdInvoice");

                    b.HasOne("RestAdminV2.Models.OrderDetails", null)
                        .WithMany("Ordereds")
                        .HasForeignKey("OrderDetailsId");

                    b.Navigation("Customer");

                    b.Navigation("Tables");
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

            modelBuilder.Entity("RestAdminV2.Models.Product", b =>
                {
                    b.HasOne("RestAdminV2.Models.Categories", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoriesId");

                    b.HasOne("RestAdminV2.Models.OrderDetails", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderDetailsId");
                });

            modelBuilder.Entity("RestAdminV2.Models.Tables", b =>
                {
                    b.HasOne("RestAdminV2.Models.Ordered", null)
                        .WithMany("Tables")
                        .HasForeignKey("OrderedId");
                });

            modelBuilder.Entity("RestAdminV2.Models.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("RestAdminV2.Models.Invoice", b =>
                {
                    b.Navigation("Ordereds");
                });

            modelBuilder.Entity("RestAdminV2.Models.OrderDetails", b =>
                {
                    b.Navigation("Ordereds");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("RestAdminV2.Models.Ordered", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("RestAdminV2.Models.Payment", b =>
                {
                    b.Navigation("Invoices");
                });
#pragma warning restore 612, 618
        }
    }
}

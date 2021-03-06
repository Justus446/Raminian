// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RaminianAPI;

namespace RaminianAPI.Migrations
{
    [DbContext(typeof(ApiDBContext))]
    [Migration("20211101132738_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RaminianAPI.Models.eComm_non_eComm", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("B64Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Breadcrumb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("L1Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("L2Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("L3Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("L4Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("LastMove")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("OfferExpiry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("OfferStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VATCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("VATPercent")
                        .HasColumnType("float");

                    b.Property<int?>("Warehouse")
                        .HasColumnType("int");

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("is_in_stock")
                        .HasColumnType("int");

                    b.Property<int>("manage_stock")
                        .HasColumnType("int");

                    b.Property<string>("offername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("offerprice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("qty")
                        .HasColumnType("int");

                    b.Property<int>("sku")
                        .HasColumnType("int");

                    b.Property<int?>("weight")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Ecommerce");
                });
#pragma warning restore 612, 618
        }
    }
}

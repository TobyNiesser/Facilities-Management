﻿// <auto-generated />
using FACILITIES.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FACILITIES.Migrations
{
    [DbContext(typeof(FACILITIESContext))]
    [Migration("20191009161027_Manager")]
    partial class Manager
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FACILITIES.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addr1");

                    b.Property<string>("Addr2");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.Property<string>("Postcode");

                    b.Property<string>("Supplier");

                    b.Property<string>("Telephone");

                    b.Property<string>("Town");

                    b.Property<string>("VatNumber");

                    b.HasKey("CompanyID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("FACILITIES.Models.File", b =>
                {
                    b.Property<int>("FileID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Extension");

                    b.Property<string>("FileName");

                    b.Property<string>("FileSize");

                    b.Property<string>("MimeType");

                    b.Property<string>("StoreLocation");

                    b.HasKey("FileID");

                    b.ToTable("File");
                });

            modelBuilder.Entity("FACILITIES.Models.Frequency", b =>
                {
                    b.Property<int>("FrequencyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FrequencyAmount");

                    b.HasKey("FrequencyID");

                    b.ToTable("Frequency");
                });

            modelBuilder.Entity("FACILITIES.Models.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName");

                    b.HasKey("ItemID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("FACILITIES.Models.Manager", b =>
                {
                    b.Property<int>("ManagerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyID");

                    b.Property<int>("OfficeID");

                    b.Property<int>("PermissionID");

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserName");

                    b.HasKey("ManagerID");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("FACILITIES.Models.Office", b =>
                {
                    b.Property<int>("OfficeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addr1");

                    b.Property<string>("Addr2");

                    b.Property<string>("City");

                    b.Property<int>("CompanyID");

                    b.Property<string>("Country");

                    b.Property<int>("ManagerID");

                    b.Property<string>("Name");

                    b.Property<string>("Postcode");

                    b.Property<string>("Telephone");

                    b.Property<string>("Town");

                    b.HasKey("OfficeID");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("FACILITIES.Models.Permission", b =>
                {
                    b.Property<int>("PermissionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountType");

                    b.Property<string>("Name");

                    b.HasKey("PermissionID");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("FACILITIES.Models.Responsibility", b =>
                {
                    b.Property<int>("ResponsibilityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Responsible");

                    b.HasKey("ResponsibilityID");

                    b.ToTable("Responsibility");
                });

            modelBuilder.Entity("FACILITIES.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusIndicator");

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });
#pragma warning restore 612, 618
        }
    }
}

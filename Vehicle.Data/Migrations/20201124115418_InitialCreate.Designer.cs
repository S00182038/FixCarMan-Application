﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vehicle.Data.DBContexts;

namespace Vehicle.Data.Migrations
{
    [DbContext(typeof(VehicleContext))]
    [Migration("20201124115418_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vehicle.Data.Models.Garage", b =>
                {
                    b.Property<int>("GarageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("County");

                    b.Property<string>("Street");

                    b.Property<string>("URL");

                    b.Property<int?>("VehicleProfileId");

                    b.HasKey("GarageId");

                    b.HasIndex("VehicleProfileId");

                    b.ToTable("Garages");
                });

            modelBuilder.Entity("Vehicle.Data.Models.NCTResult", b =>
                {
                    b.Property<int>("NctResultId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Odometer");

                    b.Property<DateTime>("ValidUntil");

                    b.Property<int?>("VehicleProfileNCTId");

                    b.HasKey("NctResultId");

                    b.HasIndex("VehicleProfileNCTId");

                    b.ToTable("NCTResults");
                });

            modelBuilder.Entity("Vehicle.Data.Models.VehicleOwner", b =>
                {
                    b.Property<int>("VehicleOwnerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("VehicleOwnerId");

                    b.ToTable("VehicleOwners");
                });

            modelBuilder.Entity("Vehicle.Data.Models.VehicleProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyStyle");

                    b.Property<string>("CarMake");

                    b.Property<string>("CarModel");

                    b.Property<string>("County");

                    b.Property<string>("Description");

                    b.Property<double>("EngineSize");

                    b.Property<string>("FuelType");

                    b.Property<string>("ImageUrl");

                    b.Property<int>("NumberOfDoors");

                    b.Property<int>("NumberOfSeats");

                    b.Property<string>("RegistrationNumber");

                    b.Property<string>("RegistrationYear");

                    b.Property<string>("Transmission");

                    b.Property<int?>("VehicleOwnerId");

                    b.Property<string>("Vin");

                    b.HasKey("Id");

                    b.HasIndex("VehicleOwnerId");

                    b.ToTable("VehicleProfiles");
                });

            modelBuilder.Entity("Vehicle.Data.Models.VehicleService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InvoiceURL");

                    b.Property<string>("ServiceDetails");

                    b.Property<int>("ServiceType");

                    b.Property<int?>("VehicleProfileId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleProfileId");

                    b.ToTable("VehicleServices");
                });

            modelBuilder.Entity("Vehicle.Data.Models.Garage", b =>
                {
                    b.HasOne("Vehicle.Data.Models.VehicleProfile")
                        .WithMany("Garages")
                        .HasForeignKey("VehicleProfileId");
                });

            modelBuilder.Entity("Vehicle.Data.Models.NCTResult", b =>
                {
                    b.HasOne("Vehicle.Data.Models.VehicleProfile", "VehicleProfileNCT")
                        .WithMany("NCTResults")
                        .HasForeignKey("VehicleProfileNCTId");
                });

            modelBuilder.Entity("Vehicle.Data.Models.VehicleProfile", b =>
                {
                    b.HasOne("Vehicle.Data.Models.VehicleOwner", "VehicleOwner")
                        .WithMany("VehicleProfiles")
                        .HasForeignKey("VehicleOwnerId");
                });

            modelBuilder.Entity("Vehicle.Data.Models.VehicleService", b =>
                {
                    b.HasOne("Vehicle.Data.Models.VehicleProfile")
                        .WithMany("VehicleServices")
                        .HasForeignKey("VehicleProfileId");
                });
#pragma warning restore 612, 618
        }
    }
}
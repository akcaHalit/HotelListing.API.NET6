﻿// <auto-generated />
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListing.API.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    [Migration("20221128094559_InıtialMigration")]
    partial class InıtialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelListing.API.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jamaica",
                            shortName = "JM"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bahamas",
                            shortName = "BM"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cayman Island",
                            shortName = "CI"
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "Negril",
                            CountryId = 1,
                            Name = "Sandals Resort and SPA",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Adress = "George Town",
                            CountryId = 3,
                            Name = "Comfort Suites",
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Nassua",
                            CountryId = 2,
                            Name = "Grand Palldium",
                            Rating = 4.0
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.API.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelListing.API.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}

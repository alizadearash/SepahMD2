﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SepahMD.DataLayer.Context;

#nullable disable

namespace SepahMD.DataLayer.Migrations
{
    [DbContext(typeof(Refahi_db))]
    [Migration("20220325142640_updatedb2")]
    partial class updatedb2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SepahMD.DataLayer.Entities.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityID"), 1L, 1);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityID");

                    b.ToTable("tblCity");
                });

            modelBuilder.Entity("SepahMD.DataLayer.Entities.Doctors", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorID"), 1L, 1);

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("DoctorAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorTell")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorTypeID")
                        .HasColumnType("int");

                    b.Property<int>("InsuranceID")
                        .HasColumnType("int");

                    b.HasKey("DoctorID");

                    b.HasIndex("CityID");

                    b.HasIndex("DoctorTypeID");

                    b.HasIndex("InsuranceID");

                    b.ToTable("tblDoctors");
                });

            modelBuilder.Entity("SepahMD.DataLayer.Entities.DoctorType", b =>
                {
                    b.Property<int>("DoctorTypeID")
                        .HasColumnType("int");

                    b.Property<string>("DoctorTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorTypeID");

                    b.ToTable("tblDoctorType");
                });

            modelBuilder.Entity("SepahMD.DataLayer.Entities.Insurance", b =>
                {
                    b.Property<int>("InsuranceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InsuranceID"), 1L, 1);

                    b.Property<string>("InsuranceDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsuranceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InsuranceID");

                    b.ToTable("tblInsurance");
                });

            modelBuilder.Entity("SepahMD.DataLayer.Entities.Doctors", b =>
                {
                    b.HasOne("SepahMD.DataLayer.Entities.City", "city")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SepahMD.DataLayer.Entities.DoctorType", "doctorType")
                        .WithMany()
                        .HasForeignKey("DoctorTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SepahMD.DataLayer.Entities.Insurance", "insurance")
                        .WithMany()
                        .HasForeignKey("InsuranceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("city");

                    b.Navigation("doctorType");

                    b.Navigation("insurance");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicManager.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClinicManager.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AttendAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diagnostic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MedicId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Prescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MedicId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("ClinicManager.Entities.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("ClinicManager.Entities.Specialty", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MedicId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("MedicId");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("ClinicManager.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator().HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ClinicManager.Entities.Patient", b =>
                {
                    b.HasBaseType("ClinicManager.Entities.User");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("ClinicManager.Entities.RegisteredUser", b =>
                {
                    b.HasBaseType("ClinicManager.Entities.User");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("RegisteredUser");
                });

            modelBuilder.Entity("ClinicManager.Entities.Admin", b =>
                {
                    b.HasBaseType("ClinicManager.Entities.RegisteredUser");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("ClinicManager.Entities.Medic", b =>
                {
                    b.HasBaseType("ClinicManager.Entities.RegisteredUser");

                    b.HasDiscriminator().HasValue("Medic");
                });

            modelBuilder.Entity("ClinicManager.Entities.Appointment", b =>
                {
                    b.HasOne("ClinicManager.Entities.Medic", "Medic")
                        .WithMany("Appointments")
                        .HasForeignKey("MedicId");

                    b.HasOne("ClinicManager.Entities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId");

                    b.Navigation("Medic");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicManager.Entities.MedicalRecord", b =>
                {
                    b.HasOne("ClinicManager.Entities.Patient", "Patient")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicManager.Entities.Specialty", b =>
                {
                    b.HasOne("ClinicManager.Entities.Medic", "Medic")
                        .WithMany("Specialties")
                        .HasForeignKey("MedicId");

                    b.Navigation("Medic");
                });

            modelBuilder.Entity("ClinicManager.Entities.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("MedicalRecords");
                });

            modelBuilder.Entity("ClinicManager.Entities.Medic", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Specialties");
                });
#pragma warning restore 612, 618
        }
    }
}

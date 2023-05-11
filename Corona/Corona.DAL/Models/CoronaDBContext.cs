using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Corona.DAL.Models
{
    public partial class CoronaDBContext : DbContext
    {
        public CoronaDBContext()
        {
        }

        public CoronaDBContext(DbContextOptions<CoronaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Patient> Patients { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatientTz)
                    .HasName("PK_Pateints");

                entity.Property(e => e.PatientTz)
                    .HasMaxLength(50)
                    .HasColumnName("patientTz");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("datetime")
                    .HasColumnName("birthDate");

                entity.Property(e => e.CellphoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("cellphoneNumber");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.FirstVaccineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("firstVaccineDate");

                entity.Property(e => e.FirstVaccineManufacturer)
                    .HasMaxLength(50)
                    .HasColumnName("firstVaccineManufacturer");

                entity.Property(e => e.FourthVaccineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fourthVaccineDate");

                entity.Property(e => e.FourthVaccineManufacturer)
                    .HasMaxLength(50)
                    .HasColumnName("fourthVaccineManufacturer");

                entity.Property(e => e.HouseNumber).HasColumnName("houseNumber");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.PositiveResultDate)
                    .HasColumnType("datetime")
                    .HasColumnName("positiveResultDate");

                entity.Property(e => e.RecoveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("recoveryDate");

                entity.Property(e => e.SecondVaccineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("secondVaccineDate");

                entity.Property(e => e.SecondVaccineManufacturer)
                    .HasMaxLength(50)
                    .HasColumnName("secondVaccineManufacturer");

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .HasColumnName("street");

                entity.Property(e => e.ThirdVaccineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("thirdVaccineDate");

                entity.Property(e => e.ThirdVaccineManufacturer)
                    .HasMaxLength(50)
                    .HasColumnName("thirdVaccineManufacturer");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

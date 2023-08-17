using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRJ.DataAccess.Entities
{
    public partial class MainContext : DbContext
    {
        public MainContext()
        {
        }

        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AmbulanceDetail> AmbulanceDetails { get; set; } = null!;
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<DriverVehicle> DriverVehicles { get; set; } = null!;
        public virtual DbSet<Lookup> Lookups { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=AmbulanceModule;User Id=sa; Password=sqladmin2019;encrypt=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AmbulanceDetail>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DestinationPoint).HasMaxLength(500);

                entity.Property(e => e.PickupPoint).HasMaxLength(500);

                entity.Property(e => e.SpecialRequirement).HasMaxLength(250);

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.AmbulanceDetails)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AmbulanceDetails_Drivers");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AmbulanceDetails)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AmbulanceDetails_Patient");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AmbulanceDetailStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AmbulanceDetails_Lookups");

                entity.HasOne(d => d.TypeOfEmergency)
                    .WithMany(p => p.AmbulanceDetailTypeOfEmergencies)
                    .HasForeignKey(d => d.TypeOfEmergencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AmbulanceDetails_Lookups1");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DriverLicense).HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Driver)
                    .HasForeignKey<Driver>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Drivers_Users");
            });

            modelBuilder.Entity<DriverVehicle>(entity =>
            {
                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.DriverVehicles)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DriverVehicles_Drivers");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.DriverVehicles)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DriverVehicles_Vehicles");
            });

            modelBuilder.Entity<Lookup>(entity =>
            {
                entity.Property(e => e.LookUpId).ValueGeneratedNever();

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BriefDescription).HasMaxLength(500);

                entity.Property(e => e.PatientDiagosis).HasMaxLength(500);

                entity.Property(e => e.PatientEmergencyNumber).HasMaxLength(50);

                entity.Property(e => e.PrimaryConsultant).HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Patient)
                    .HasForeignKey<Patient>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Pin).HasMaxLength(50);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.VehicleNumber).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

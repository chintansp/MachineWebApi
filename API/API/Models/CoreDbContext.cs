using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API.API.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PartsAvailibility> PartsAvailibilities { get; set; }
        public virtual DbSet<PartsInventory> PartsInventories { get; set; }
        public virtual DbSet<ServiceHistory> ServiceHistories { get; set; }
        public virtual DbSet<VehicleMasterdata> VehicleMasterdata { get; set; }
        public virtual DbSet<VehiclePartsData> VehiclePartsData { get; set; }
        public virtual DbSet<VehicleUpTimeData> VehicleUpTimeData { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=fleetcare.database.windows.net;Initial Catalog=FleetCareDb;User ID=hackAdmin;Password=Hack@@1pass;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartsAvailibility>(entity =>
            {
                entity.HasKey(e => e.PartId)
                    .HasName("PK__PartsAva__7C3F0D305CC87FF2");
            });

            modelBuilder.Entity<ServiceHistory>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK__ServiceH__476B54B28716100B");
            });

            modelBuilder.Entity<VehiclePartsData>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK__VehicleP__476B54B253B58D17");
            });

            modelBuilder.Entity<VehicleUpTimeData>(entity =>
            {
                entity.Property(e => e.BrakeCount).IsUnicode(false);

                entity.Property(e => e.Component).IsUnicode(false);

                entity.Property(e => e.CurrentDriveSessionId).IsUnicode(false);

                entity.Property(e => e.DataContentId).IsUnicode(false);

                entity.Property(e => e.DataContentReport).IsUnicode(false);

                entity.Property(e => e.DistanceToEmptyCng).IsUnicode(false);

                entity.Property(e => e.DistanceToEmptyDiesel).IsUnicode(false);

                entity.Property(e => e.DistanceToEmptyLng).IsUnicode(false);

                entity.Property(e => e.DistanceToEmptyPower).IsUnicode(false);

                entity.Property(e => e.DistanceToEmptyPower2).IsUnicode(false);

                entity.Property(e => e.Duration).IsUnicode(false);

                entity.Property(e => e.ExistsSpecificData).IsUnicode(false);

                entity.Property(e => e.Existsduration).IsUnicode(false);

                entity.Property(e => e.FuelLevelExistsCngTotal).IsUnicode(false);

                entity.Property(e => e.FuelLevelExistsDieselTotal).IsFixedLength(true);

                entity.Property(e => e.FuelLevelExistsLngTotal).IsUnicode(false);

                entity.Property(e => e.FuelLevelExistsPowerTotal).IsUnicode(false);

                entity.Property(e => e.FuelLevelPowerTotal).IsUnicode(false);

                entity.Property(e => e.LovEngineTime).IsUnicode(false);

                entity.Property(e => e.LovVehicleMovingTime).IsUnicode(false);

                entity.Property(e => e.LovVehicleOverspeedTime).IsUnicode(false);

                entity.Property(e => e.PatternId).IsUnicode(false);

                entity.Property(e => e.PositionAltitude).IsUnicode(false);

                entity.Property(e => e.PositionExistsAltitude).IsUnicode(false);

                entity.Property(e => e.PositionExistsHeading).IsUnicode(false);

                entity.Property(e => e.PositionHeading).IsUnicode(false);

                entity.Property(e => e.PositionLatitude).IsUnicode(false);

                entity.Property(e => e.PositionLongitude).IsUnicode(false);

                entity.Property(e => e.PositionTimestamp).IsUnicode(false);

                entity.Property(e => e.RemainingEnergyExistsCng).IsUnicode(false);

                entity.Property(e => e.RemainingEnergyExistsDiesel).IsUnicode(false);

                entity.Property(e => e.RemainingEnergyExistsLng).IsUnicode(false);

                entity.Property(e => e.RemainingEnergyExistsPower).IsUnicode(false);

                entity.Property(e => e.RemainingEnergyPower).IsUnicode(false);

                entity.Property(e => e.Spped).IsUnicode(false);

                entity.Property(e => e.StopCount).IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsUnicode(false);

                entity.Property(e => e.TriggerId).IsUnicode(false);

                entity.Property(e => e.TriggerTime).IsUnicode(false);

                entity.Property(e => e.VehicleId).HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

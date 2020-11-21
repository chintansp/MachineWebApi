using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MachineWebApi
{
    public partial class FleetCare : DbContext
    {
        public FleetCare()
            : base("name=FleetCare")
        {
        }

        public virtual DbSet<PartsAvailibility> PartsAvailibilities { get; set; }
        public virtual DbSet<PartsInventory> PartsInventories { get; set; }
        public virtual DbSet<ServiceHistory> ServiceHistories { get; set; }
        public virtual DbSet<VehicleMasterdata> VehicleMasterdatas { get; set; }
        public virtual DbSet<VehiclePartsData> VehiclePartsDatas { get; set; }
        public virtual DbSet<VehicleUpTimeData> VehicleUpTimeDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.TriggerTime)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.TimeStamp)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.BrakeCount)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.Component)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.CurrentDriveSessionID)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.DataContentId)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.DistanceToEmptyPower)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.DistanceToEmptyCng)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.DistanceToEmptyDiesel)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.DistanceToEmptyLng)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.DistanceToEmptyPower2)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.DataContentReport)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.Existsduration)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.ExistsSpecificData)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.FuelLevelExistsCngTotal)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.FuelLevelExistsDieselTotal)
                .IsFixedLength();

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.FuelLevelExistsLngTotal)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.FuelLevelExistsPowerTotal)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.FuelLevelPowerTotal)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.LovEngineTime)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.lovVehicleMovingTime)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.lovVehicleOverspeedTime)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.PatternId)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.PositionAltitude)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.PositionExistsAltitude)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.PositionExistsHeading)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.PositionHeading)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.PositionLatitude)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.PositionLongitude)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.PositionTimestamp)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.RemainingEnergyExistsCng)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.RemainingEnergyExistsDiesel)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.RemainingEnergyExistsLng)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.RemainingEnergyExistsPower)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.RemainingEnergyPower)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.Spped)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.StopCount)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUpTimeData>()
                .Property(e => e.TriggerId)
                .IsUnicode(false);
        }
    }
}

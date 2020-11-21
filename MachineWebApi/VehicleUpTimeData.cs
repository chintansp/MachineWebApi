namespace MachineWebApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleUpTimeData")]
    public partial class VehicleUpTimeData
    {
        public int Id { get; set; }

        public int VehicleId { get; set; }

        [StringLength(50)]
        public string TriggerTime { get; set; }

        [StringLength(50)]
        public string TimeStamp { get; set; }

        [StringLength(50)]
        public string BrakeCount { get; set; }

        [StringLength(50)]
        public string Component { get; set; }

        [StringLength(50)]
        public string CurrentDriveSessionID { get; set; }

        [StringLength(50)]
        public string DataContentId { get; set; }

        [StringLength(50)]
        public string DistanceToEmptyPower { get; set; }

        [StringLength(50)]
        public string DistanceToEmptyCng { get; set; }

        [StringLength(50)]
        public string DistanceToEmptyDiesel { get; set; }

        [StringLength(50)]
        public string DistanceToEmptyLng { get; set; }

        [StringLength(50)]
        public string DistanceToEmptyPower2 { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        [StringLength(50)]
        public string DataContentReport { get; set; }

        [StringLength(50)]
        public string Existsduration { get; set; }

        [StringLength(50)]
        public string ExistsSpecificData { get; set; }

        [StringLength(50)]
        public string FuelLevelExistsCngTotal { get; set; }

        [StringLength(10)]
        public string FuelLevelExistsDieselTotal { get; set; }

        [StringLength(50)]
        public string FuelLevelExistsLngTotal { get; set; }

        [StringLength(50)]
        public string FuelLevelExistsPowerTotal { get; set; }

        [StringLength(50)]
        public string FuelLevelPowerTotal { get; set; }

        [StringLength(50)]
        public string LovEngineTime { get; set; }

        [StringLength(50)]
        public string lovVehicleMovingTime { get; set; }

        [StringLength(50)]
        public string lovVehicleOverspeedTime { get; set; }

        [StringLength(50)]
        public string PatternId { get; set; }

        [StringLength(50)]
        public string PositionAltitude { get; set; }

        [StringLength(50)]
        public string PositionExistsAltitude { get; set; }

        [StringLength(50)]
        public string PositionExistsHeading { get; set; }

        [StringLength(50)]
        public string PositionHeading { get; set; }

        [StringLength(50)]
        public string PositionLatitude { get; set; }

        [StringLength(50)]
        public string PositionLongitude { get; set; }

        [StringLength(50)]
        public string PositionTimestamp { get; set; }

        [StringLength(50)]
        public string RemainingEnergyExistsCng { get; set; }

        [StringLength(50)]
        public string RemainingEnergyExistsDiesel { get; set; }

        [StringLength(50)]
        public string RemainingEnergyExistsLng { get; set; }

        [StringLength(50)]
        public string RemainingEnergyExistsPower { get; set; }

        [StringLength(50)]
        public string RemainingEnergyPower { get; set; }

        [StringLength(50)]
        public string Spped { get; set; }

        [StringLength(50)]
        public string StopCount { get; set; }

        [StringLength(50)]
        public string TriggerId { get; set; }
    }
}

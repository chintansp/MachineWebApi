namespace MachineWebApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehiclePartsData")]
    public partial class VehiclePartsData
    {
        [Key]
        public int VehicleID { get; set; }

        [Column("Engine Description")]
        [StringLength(255)]
        public string Engine_Description { get; set; }

        [Column("Emission Level")]
        [StringLength(255)]
        public string Emission_Level { get; set; }

        [Column("Gearbox Description")]
        [StringLength(255)]
        public string Gearbox_Description { get; set; }

        [Column("Power Take-Off")]
        [StringLength(255)]
        public string Power_Take_Off { get; set; }

        [StringLength(255)]
        public string Brakes { get; set; }

        [Column("Fuel Capacity")]
        [StringLength(255)]
        public string Fuel_Capacity { get; set; }

        [Column("Front Suspension")]
        [StringLength(255)]
        public string Front_Suspension { get; set; }

        [Column("Rear Suspension")]
        [StringLength(255)]
        public string Rear_Suspension { get; set; }

        [Column("Tyre Tread")]
        [StringLength(255)]
        public string Tyre_Tread { get; set; }

        [Column("Chassis Height")]
        [StringLength(255)]
        public string Chassis_Height { get; set; }

        [Column("Rear Axle Capacity Tech# (tonnes)")]
        public int? Rear_Axle_Capacity_Tech___tonnes_ { get; set; }

        [Column("Front Axle Capacity Tech#(tonnes)")]
        public int? Front_Axle_Capacity_Tech__tonnes_ { get; set; }
    }
}

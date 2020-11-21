using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.API.Models
{
    public partial class VehiclePartsData
    {
        [Key]
        [Column("VehicleID")]
        public int VehicleId { get; set; }
        [Column("Engine Description")]
        [StringLength(255)]
        public string EngineDescription { get; set; }
        [Column("Emission Level")]
        [StringLength(255)]
        public string EmissionLevel { get; set; }
        [Column("Gearbox Description")]
        [StringLength(255)]
        public string GearboxDescription { get; set; }
        [Column("Power Take-Off")]
        [StringLength(255)]
        public string PowerTakeOff { get; set; }
        [StringLength(255)]
        public string Brakes { get; set; }
        [Column("Fuel Capacity")]
        [StringLength(255)]
        public string FuelCapacity { get; set; }
        [Column("Front Suspension")]
        [StringLength(255)]
        public string FrontSuspension { get; set; }
        [Column("Rear Suspension")]
        [StringLength(255)]
        public string RearSuspension { get; set; }
        [Column("Tyre Tread")]
        [StringLength(255)]
        public string TyreTread { get; set; }
        [Column("Chassis Height")]
        [StringLength(255)]
        public string ChassisHeight { get; set; }
        [Column("Rear Axle Capacity Tech# (tonnes)")]
        public int? RearAxleCapacityTechTonnes { get; set; }
        [Column("Front Axle Capacity Tech#(tonnes)")]
        public int? FrontAxleCapacityTechTonnes { get; set; }
    }
}

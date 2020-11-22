using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.API.Models
{
    public partial class VehicleMasterdata
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Category/Chassis type")]
        [StringLength(255)]
        public string CategoryChassisType { get; set; }
        [StringLength(255)]
        public string Make { get; set; }
        [StringLength(255)]
        public string Model { get; set; }
        [StringLength(255)]
        public string ChassisSeries { get; set; }
        public int? ChassisNo { get; set; }
        [Column("VINNO")]
        [StringLength(255)]
        public string Vinno { get; set; }
        [StringLength(255)]
        public string RegistrationNo { get; set; }
        public int? ModelYear { get; set; }
        [StringLength(255)]
        public string FirstRegistrationDate { get; set; }
        [StringLength(255)]
        public string BuildDate { get; set; }
        [StringLength(255)]
        public string Owner { get; set; }
        [StringLength(255)]
        public string AxleArrangement { get; set; }
        [Column("GCW (tonnes)_")]
        public int? GcwTonnes { get; set; }
        [Column("Engine Output (hp)*")]
        [StringLength(255)]
        public string EngineOutputHp { get; set; }
        [Column("Wheelbase (mm)")]
        public int? WheelbaseMm { get; set; }
        public int? ActualMileage { get; set; }
        [StringLength(255)]
        public string ActualMileageDate { get; set; }

        [StringLength(255)]
        public string PartsChangeNotification { get; set; }  
        
        public DateTime? ServiceAggrementStartDate { get; set; }

        
        public DateTime? MaintainceDate { get; set; }

        public DateTime? ServiceAgreementEndDate { get; set; }
}
}

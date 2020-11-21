namespace MachineWebApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleMasterdata")]
    public partial class VehicleMasterdata
    {
        public int ID { get; set; }

        [Column("Category/Chassis type")]
        [StringLength(255)]
        public string Category_Chassis_type { get; set; }

        [StringLength(255)]
        public string Make { get; set; }

        [StringLength(255)]
        public string Model { get; set; }

        [StringLength(255)]
        public string ChassisSeries { get; set; }

        public int? ChassisNo { get; set; }

        [StringLength(255)]
        public string VINNO { get; set; }

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
        public int? GCW__tonnes__ { get; set; }

        [Column("Engine Output (hp)*")]
        [StringLength(255)]
        public string Engine_Output__hp__ { get; set; }

        [Column("Wheelbase (mm)")]
        public int? Wheelbase__mm_ { get; set; }

        public int? ActualMileage { get; set; }

        [StringLength(255)]
        public string ActualMileageDate { get; set; }
    }
}

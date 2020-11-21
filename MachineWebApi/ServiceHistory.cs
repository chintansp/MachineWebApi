namespace MachineWebApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceHistory")]
    public partial class ServiceHistory
    {
        [Key]
        public int VehicleID { get; set; }

        [StringLength(255)]
        public string ServiceDate { get; set; }
    }
}

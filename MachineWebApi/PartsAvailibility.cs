namespace MachineWebApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartsAvailibility")]
    public partial class PartsAvailibility
    {
        [Key]
        public int PartID { get; set; }

        [StringLength(255)]
        public string AvailableAt { get; set; }
    }
}

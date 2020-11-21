namespace MachineWebApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartsInventory")]
    public partial class PartsInventory
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string PartName { get; set; }

        [Column("Life(months)")]
        public double? Life_months_ { get; set; }
    }
}

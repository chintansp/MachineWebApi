using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.API.Models
{
    [Table("ServiceHistory")]
    public partial class ServiceHistory
    {
        [Key]
        [Column("VehicleID")]
        public int VehicleId { get; set; }
        [StringLength(255)]
        public string ServiceDate { get; set; }
    }
}

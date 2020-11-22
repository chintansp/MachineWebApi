using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.API.Models
{
    [Table("PartsAvailibility")]
    public partial class PartsAvailibility
    {
        [Key]
        [Column("PartID")]
        public int PartId { get; set; }
        [StringLength(255)]
        public string AvailableAt { get; set; }
    }
}

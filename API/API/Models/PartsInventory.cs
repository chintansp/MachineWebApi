using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.API.Models
{
    [Table("PartsInventory")]
    public partial class PartsInventory
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        public string PartName { get; set; }
        [Column("Life(months)")]
        public double? LifeMonths { get; set; }
    }
}

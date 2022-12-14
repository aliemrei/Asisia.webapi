using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CURRATE")]
    [Index(nameof(Corpid), nameof(Curcode), nameof(Ratedate), Name = "IX_CURRATE")]
    [Index(nameof(Ratedate), Name = "IX_CURRATE_1")]
    [Index(nameof(Ratedate), Name = "IX_CURRATE_2")]
    [Index(nameof(Corpid), nameof(Curcode), nameof(Ratedate), Name = "IX_CURRATE_4")]
    public partial class Currate : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("RATEDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Ratedate { get; set; }


        [Column("RATE")]
        [RequiredIf]
        public double Rate { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        [RequiredIf]
        public string Curcode { get; set; } = null!;



        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Currate")]
        public virtual Corp Corp { get; set; } = null!;

            }
}

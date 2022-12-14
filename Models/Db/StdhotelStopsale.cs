using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_STOPSALE")]
    [Index(nameof(Corpid), Name = "IX_CORP")]
    public partial class StdhotelStopsale : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("PRICECONDITIONID")]
        
        public Guid? Priceconditionid { get; set; }


        [Column("FROMDATE", TypeName = "date")]
        [RequiredIf]
        public DateTime Fromdate { get; set; }


        [Column("TODATE", TypeName = "date")]
        [RequiredIf]
        public DateTime Todate { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }



        [ForeignKey(nameof(Corpid))]
        [InverseProperty("StdhotelStopsale")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Priceconditionid))]
        [InverseProperty(nameof(StdhotelPricecondition.StdhotelStopsale))]
        public virtual StdhotelPricecondition? Pricecondition { get; set; }

            }
}

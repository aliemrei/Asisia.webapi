using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_PRICECONDITION_CALENDAR")]
    [Index(nameof(Date), nameof(Priceconditionid), Name = "UQ__STDHOTEL__BC35458659EA38AD", IsUnique = true)]
    public partial class StdhotelPriceconditionCalendar : EntityBase 
    {
        [Column("PRICECONDITIONID")]
        [RequiredIf]
        public Guid Priceconditionid { get; set; }


        [Column("DATE", TypeName = "date")]
        [RequiredIf]
        public DateTime Date { get; set; }


        [Column("BASERATE", TypeName = "decimal(19, 2)")]
        
        public decimal? Baserate { get; set; }


        [Column("QUOTA")]
        
        public int? Quota { get; set; }


        [Column("STOP_CHECKIN")]
        
        public bool? StopCheckin { get; set; }


        [Column("STOP_CHECKOUT")]
        
        public bool? StopCheckout { get; set; }


        [Column("STOP_SELL")]
        
        public bool? StopSell { get; set; }


        [Column("RELEASE_DAY")]
        
        public int? ReleaseDay { get; set; }


        [Column("MIN_LOS")]
        
        public int? MinLos { get; set; }


        [Column("MAX_LOS")]
        
        public int? MaxLos { get; set; }


        [Column("FREE_SELL")]
        
        public int? FreeSell { get; set; }


        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("RELEASEDATE", TypeName = "date")]
        
        public DateTime? Releasedate { get; set; }



        [ForeignKey(nameof(Priceconditionid))]
        [InverseProperty(nameof(StdhotelPricecondition.StdhotelPriceconditionCalendar))]
        public virtual StdhotelPricecondition Pricecondition { get; set; } = null!;

            }
}

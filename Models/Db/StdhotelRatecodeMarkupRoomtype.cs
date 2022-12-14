using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_MARKUP_ROOMTYPE")]
    [Index(nameof(BeforeDiscount), Name = "IX_STDHOTEL_RATECODE_MARKUP_ROOMTYPE")]
    public partial class StdhotelRatecodeMarkupRoomtype : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("MARKUPID")]
        [RequiredIf]
        public Guid Markupid { get; set; }


        [Column("ROOMTYPEID")]
        [RequiredIf]
        public Guid Roomtypeid { get; set; }


        [Column("RATE")]
        
        public double? Rate { get; set; }


        [Column("AMOUNT")]
        
        public double? Amount { get; set; }


        [Column("ADULT_PRICE")]
        
        public double? AdultPrice { get; set; }


        [Column("CHDE_PRICE")]
        
        public double? ChdePrice { get; set; }


        [Column("CHDY_PRICE")]
        
        public double? ChdyPrice { get; set; }


        [Column("BABY_PRICE")]
        
        public double? BabyPrice { get; set; }


        [Column("BEFORE_DISCOUNT")]
        [RequiredIf]
        public bool BeforeDiscount { get; set; }


        [Column("LAST_RATE")]
        
        public double? LastRate { get; set; }



        [ForeignKey(nameof(Markupid))]
        [InverseProperty(nameof(StdhotelRatecodeMarkup.StdhotelRatecodeMarkupRoomtype))]
        public virtual StdhotelRatecodeMarkup Markup { get; set; } = null!;
        [ForeignKey(nameof(Roomtypeid))]
        [InverseProperty(nameof(StdhotelRoomtypes.StdhotelRatecodeMarkupRoomtype))]
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;

            }
}

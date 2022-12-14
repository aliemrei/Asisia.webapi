using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_PRICECONDITION_OCCUPANCY")]
    public partial class StdhotelPriceconditionOccupancy : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PRICECONDITIONID")]
        [RequiredIf]
        public Guid Priceconditionid { get; set; }


        [Column("ADULT")]
        
        public byte? Adult { get; set; }


        [Column("CHDE")]
        
        public byte? Chde { get; set; }


        [Column("CHDY")]
        
        public byte? Chdy { get; set; }


        [Column("BABY")]
        
        public byte? Baby { get; set; }


        [Column("GUESTPRICE_RATE")]
        
        public double? GuestpriceRate { get; set; }


        [Column("COSTPRICE_RATE")]
        
        public double? CostpriceRate { get; set; }


        [Column("TOTALCHD")]
        
        public byte? Totalchd { get; set; }



        [ForeignKey(nameof(Priceconditionid))]
        [InverseProperty(nameof(StdhotelPricecondition.StdhotelPriceconditionOccupancy))]
        public virtual StdhotelPricecondition Pricecondition { get; set; } = null!;

            }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("STDHOTEL_FECILITIES")]
    public partial class StdhotelFecilities : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("HOTELID")]
        
        public Guid? Hotelid { get; set; }


        [Column("DEFINITION")]
        [StringLength(100)]
        
        public string? Definition { get; set; }


        [Column("CATEGORY")]
        [StringLength(100)]
        
        public string? Category { get; set; }


        [Column("ISFREE")]
        
        public bool? Isfree { get; set; }


        [Column("ICON")]
        [StringLength(75)]
        
        public string? Icon { get; set; }


        [Column("SEASONTYPE")]
        [StringLength(10)]
        
        public string? Seasontype { get; set; }


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("ROOMTYPEID")]
        
        public Guid? Roomtypeid { get; set; }



        [ForeignKey(nameof(Hotelid))]
        public virtual Stdhotel? Hotel { get; set; }
        [ForeignKey(nameof(Roomtypeid))]
        public virtual StdhotelRoomtypes? Roomtype { get; set; }

            }
}

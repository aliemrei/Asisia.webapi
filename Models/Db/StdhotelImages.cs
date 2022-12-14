using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("STDHOTEL_IMAGES")]
    public partial class StdhotelImages : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("HOTELID")]
        
        public Guid? Hotelid { get; set; }


        [Column("DEFINITION")]
        [StringLength(100)]
        
        public string? Definition { get; set; }


        [Column("DEFAULT")]
        
        public bool? Default { get; set; }


        [Column("SORTORDER")]
        
        public int? Sortorder { get; set; }


        [Column("THUMBNAIL")]
        [StringLength(250)]
        
        public string? Thumbnail { get; set; }


        [Column("URL")]
        [StringLength(250)]
        
        public string? Url { get; set; }


        [Column("ROOMTYPEID")]
        
        public Guid? Roomtypeid { get; set; }


        [Required]
        [Column("SHOWINOFFERFORM")]
        
        public bool? Showinofferform { get; set; }


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("UID")]
        [RequiredIf]
        public Guid Uid { get; set; }



        [ForeignKey(nameof(Hotelid))]
        public virtual Stdhotel? Hotel { get; set; }
        [ForeignKey(nameof(Roomtypeid))]
        public virtual StdhotelRoomtypes? Roomtype { get; set; }

            }
}

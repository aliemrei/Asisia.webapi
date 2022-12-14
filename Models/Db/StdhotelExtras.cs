using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_EXTRAS")]
    [Index(nameof(Exserviceid), Name = "IX_STDHOTEL_EXTRAS")]
    public partial class StdhotelExtras : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("HOTELID")]
        [RequiredIf]
        public Guid Hotelid { get; set; }


        [Column("DEFINITION")]
        [StringLength(150)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("PRICE")]
        
        public double? Price { get; set; }


        [Column("CURCODE")]
        [StringLength(4)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


        [Column("EXSERVICEID")]
        
        public Guid? Exserviceid { get; set; }



        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelExtras))]
        public virtual Stdhotel Hotel { get; set; } = null!;

            }
}

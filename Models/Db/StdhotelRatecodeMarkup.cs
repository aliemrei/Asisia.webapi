using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_MARKUP")]
    public partial class StdhotelRatecodeMarkup : EntityBase 
    {
        public StdhotelRatecodeMarkup()
        {
            StdhotelRatecodeMarkupMarkets = new HashSet<StdhotelRatecodeMarkupMarkets>();
            StdhotelRatecodeMarkupRoomtype = new HashSet<StdhotelRatecodeMarkupRoomtype>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("RATECODEID")]
        [RequiredIf]
        public Guid Ratecodeid { get; set; }


        [Column("STAYFROM", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Stayfrom { get; set; }


        [Column("STAYTO", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Stayto { get; set; }


        [Column("STAYINGDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Stayingdays { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("RATE")]
        
        public double? Rate { get; set; }


        [Column("APPLY_TYPE")]
        [RequiredIf]
        public byte ApplyType { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


        [Column("APPLYZONE")]
        [RequiredIf]
        public byte Applyzone { get; set; }


        [Column("AGENCYID")]
        
        public Guid? Agencyid { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdhotelRatecodeMarkupAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("StdhotelRatecodeMarkup")]
        public virtual Curcode? CurcodeNavigation { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdhotelRatecodeMarkupEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Ratecodeid))]
        [InverseProperty(nameof(StdhotelRatecode.StdhotelRatecodeMarkup))]
        public virtual StdhotelRatecode Ratecode { get; set; } = null!;
        [InverseProperty("Markup")]
        public virtual ICollection<StdhotelRatecodeMarkupMarkets> StdhotelRatecodeMarkupMarkets { get; set; }
        [InverseProperty("Markup")]
        public virtual ICollection<StdhotelRatecodeMarkupRoomtype> StdhotelRatecodeMarkupRoomtype { get; set; }

            }
}

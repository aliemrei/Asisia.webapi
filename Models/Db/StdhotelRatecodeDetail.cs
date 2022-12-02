using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_DETAIL")]
    [Index(nameof(Ratecodeid), nameof(Priceconditionid), nameof(Stayfrom), nameof(Stayto), nameof(Minlos), nameof(Maxlos), Name = "IX_MISS_HOTELSEARCH")]
    [Index(nameof(Id), Name = "UQ__STDHOTEL__3214EC2632A733C7", IsUnique = true)]
    public partial class StdhotelRatecodeDetail : EntityBase // My Handlebars Helper
    {
        public StdhotelRatecodeDetail()
        {
            StdhotelRatecodeDetailAgencygroups = new HashSet<StdhotelRatecodeDetailAgencygroups>();
            StdhotelRatecodeDiscountContract = new HashSet<StdhotelRatecodeDiscountContract>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("HOTELID")]
        public Guid Hotelid { get; set; }
        [Column("RATECODEID")]
        public Guid Ratecodeid { get; set; }
        [Column("DEFINITION")]
        [StringLength(50)]
        public string Definition { get; set; } = null!;
        [Column("TYPE")]
        public byte Type { get; set; }
        [Column("SELLFROM", TypeName = "datetime")]
        public DateTime? Sellfrom { get; set; }
        [Column("SELLTO", TypeName = "datetime")]
        public DateTime? Sellto { get; set; }
        [Column("STAYFROM", TypeName = "datetime")]
        public DateTime? Stayfrom { get; set; }
        [Column("STAYTO", TypeName = "datetime")]
        public DateTime? Stayto { get; set; }
        [Column("CHECKINDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        public string? Checkindays { get; set; }
        [Column("CHECKOUTDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        public string? Checkoutdays { get; set; }
        [Column("STAYINGDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        public string? Stayingdays { get; set; }
        [Column("PRICECONDITIONID")]
        public Guid? Priceconditionid { get; set; }
        [Column("SNG", TypeName = "decimal(19, 2)")]
        public decimal? Sng { get; set; }
        [Column("DBL", TypeName = "decimal(19, 2)")]
        public decimal? Dbl { get; set; }
        [Column("TRP", TypeName = "decimal(19, 2)")]
        public decimal? Trp { get; set; }
        [Column("QUAD", TypeName = "decimal(19, 2)")]
        public decimal? Quad { get; set; }
        [Column("EXBED", TypeName = "decimal(19, 2)")]
        public decimal? Exbed { get; set; }
        [Column("BABY", TypeName = "decimal(19, 2)")]
        public decimal? Baby { get; set; }
        [Column("CHDY", TypeName = "decimal(19, 2)")]
        public decimal? Chdy { get; set; }
        [Column("CHDE", TypeName = "decimal(19, 2)")]
        public decimal? Chde { get; set; }
        [Column("FIRSTBABY", TypeName = "decimal(19, 2)")]
        public decimal? Firstbaby { get; set; }
        [Column("FIRSTCHDY", TypeName = "decimal(19, 2)")]
        public decimal? Firstchdy { get; set; }
        [Column("FIRSTCHDE", TypeName = "decimal(19, 2)")]
        public decimal? Firstchde { get; set; }
        [Column("SNGBABY", TypeName = "decimal(19, 2)")]
        public decimal? Sngbaby { get; set; }
        [Column("SNGCHDY", TypeName = "decimal(19, 2)")]
        public decimal? Sngchdy { get; set; }
        [Column("SNGCHDE", TypeName = "decimal(19, 2)")]
        public decimal? Sngchde { get; set; }
        [Column("SNGFIRSTBABY", TypeName = "decimal(19, 2)")]
        public decimal? Sngfirstbaby { get; set; }
        [Column("SNGFIRSTCHDY", TypeName = "decimal(19, 2)")]
        public decimal? Sngfirstchdy { get; set; }
        [Column("SNGFIRSTCHDE", TypeName = "decimal(19, 2)")]
        public decimal? Sngfirstchde { get; set; }
        [Column("MINLOS")]
        public byte? Minlos { get; set; }
        [Column("MAXLOS")]
        public byte? Maxlos { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("COMMISSIONPERCENT")]
        public double? Commissionpercent { get; set; }
        [Column("COMMISSIONINCLUDED")]
        public bool? Commissionincluded { get; set; }
        [Column("FIXPRICE")]
        public byte? Fixprice { get; set; }
        [Column("PRICESORT")]
        public int? Pricesort { get; set; }
        [Column("CHILDCALCKIND")]
        public byte Childcalckind { get; set; }
        [Column("TRPBABY", TypeName = "decimal(19, 2)")]
        public decimal? Trpbaby { get; set; }
        [Column("TRPCHDY", TypeName = "decimal(19, 2)")]
        public decimal? Trpchdy { get; set; }
        [Column("TRPCHDE", TypeName = "decimal(19, 2)")]
        public decimal? Trpchde { get; set; }
        [Column("TRPFIRSTBABY", TypeName = "decimal(19, 2)")]
        public decimal? Trpfirstbaby { get; set; }
        [Column("TRPFIRSTCHDY", TypeName = "decimal(19, 2)")]
        public decimal? Trpfirstchdy { get; set; }
        [Column("TRPFIRSTCHDE", TypeName = "decimal(19, 2)")]
        public decimal? Trpfirstchde { get; set; }
        [Column("SNGCHILDCALCKIND")]
        public byte Sngchildcalckind { get; set; }
        [Column("TRPCHILDCALCKIND")]
        public byte Trpchildcalckind { get; set; }
        [Column("MINDAY_RATE")]
        public short? MindayRate { get; set; }

        [ForeignKey(nameof(Priceconditionid))]
        [InverseProperty(nameof(StdhotelPricecondition.StdhotelRatecodeDetail))]
        public virtual StdhotelPricecondition? Pricecondition { get; set; }
        [InverseProperty("Detail")]
        public virtual ICollection<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroups { get; set; }
        [InverseProperty("Contract")]
        public virtual ICollection<StdhotelRatecodeDiscountContract> StdhotelRatecodeDiscountContract { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE")]
    [Index(nameof(Hotelid), nameof(Corpid), Name = "IX_STDHOTEL_RATECODE", IsUnique = true)]
    [Index(nameof(Id), Name = "UQ__STDHOTEL__3214EC26D34E1904", IsUnique = true)]
    public partial class StdhotelRatecode : EntityBase // My Handlebars Helper
    {
        public StdhotelRatecode()
        {
            HotelReservationDetails = new HashSet<HotelReservationDetails>();
            RequestDetail = new HashSet<RequestDetail>();
            StdhotelRatecodeDiscount = new HashSet<StdhotelRatecodeDiscount>();
            StdhotelRatecodeMarkup = new HashSet<StdhotelRatecodeMarkup>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("HOTELID")]
        public Guid Hotelid { get; set; }
        [Column("DEFINITION")]
        [StringLength(50)]
        public string Definition { get; set; } = null!;
        [Column("CURCODE")]
        [StringLength(4)]
        [Unicode(false)]
        public string Curcode { get; set; } = null!;
        [Column("CORPID")]
        public Guid? Corpid { get; set; }
        [Column("BABY_MAXAGE")]
        public short? BabyMaxage { get; set; }
        [Column("CHDY_MAXAGE")]
        public short? ChdyMaxage { get; set; }
        [Column("CHDE_MAXAGE")]
        public short? ChdeMaxage { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("SNG")]
        public double? Sng { get; set; }
        [Column("DBL")]
        public double? Dbl { get; set; }
        [Column("TRP")]
        public double? Trp { get; set; }
        [Column("QUAD")]
        public double? Quad { get; set; }
        [Column("EXBED")]
        public double? Exbed { get; set; }
        [Column("BABY")]
        public double? Baby { get; set; }
        [Column("CHDY")]
        public double? Chdy { get; set; }
        [Column("CHDE")]
        public double? Chde { get; set; }
        [Column("FIRSTBABY")]
        public double? Firstbaby { get; set; }
        [Column("FIRSTCHDY")]
        public double? Firstchdy { get; set; }
        [Column("FIRSTCHDE")]
        public double? Firstchde { get; set; }
        [Column("SNGBABY")]
        public double? Sngbaby { get; set; }
        [Column("SNGCHDY")]
        public double? Sngchdy { get; set; }
        [Column("SNGCHDE")]
        public double? Sngchde { get; set; }
        [Column("SNGFIRSTBABY")]
        public double? Sngfirstbaby { get; set; }
        [Column("SNGFIRSTCHDY")]
        public double? Sngfirstchdy { get; set; }
        [Column("SNGFIRSTCHDE")]
        public double? Sngfirstchde { get; set; }
        [Column("COMMISSIONPERCENT")]
        public double? Commissionpercent { get; set; }
        [Column("COMMISSIONINCLUDED")]
        public bool? Commissionincluded { get; set; }
        [Column("TRPBABY")]
        public double? Trpbaby { get; set; }
        [Column("TRPCHDY")]
        public double? Trpchdy { get; set; }
        [Column("TRPCHDE")]
        public double? Trpchde { get; set; }
        [Column("TRPFIRSTBABY")]
        public double? Trpfirstbaby { get; set; }
        [Column("TRPFIRSTCHDY")]
        public double? Trpfirstchdy { get; set; }
        [Column("TRPFIRSTCHDE")]
        public double? Trpfirstchde { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdhotelRatecodeAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("StdhotelRatecode")]
        public virtual Corp? Corp { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdhotelRatecodeEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelRatecode))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [InverseProperty("Ratecode")]
        public virtual ICollection<HotelReservationDetails> HotelReservationDetails { get; set; }
        [InverseProperty("Ratecode")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Ratecode")]
        public virtual ICollection<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; }
        [InverseProperty("Ratecode")]
        public virtual ICollection<StdhotelRatecodeMarkup> StdhotelRatecodeMarkup { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

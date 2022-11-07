using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATECODE_DETAIL : EntityBase // My Handlebars Helper
    {
        public STDHOTEL_RATECODE_DETAIL()
        {
            STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS = new HashSet<STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS>();
            STDHOTEL_RATECODE_DISCOUNT_CONTRACT = new HashSet<STDHOTEL_RATECODE_DISCOUNT_CONTRACT>();
        }

        public Guid ID { get; set; }
        public Guid HOTELID { get; set; }
        public Guid RATECODEID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public byte TYPE { get; set; }
        public DateTime? SELLFROM { get; set; }
        public DateTime? SELLTO { get; set; }
        public DateTime? STAYFROM { get; set; }
        public DateTime? STAYTO { get; set; }
        public string? CHECKINDAYS { get; set; }
        public string? CHECKOUTDAYS { get; set; }
        public string? STAYINGDAYS { get; set; }
        public Guid? PRICECONDITIONID { get; set; }
        public decimal? SNG { get; set; }
        public decimal? DBL { get; set; }
        public decimal? TRP { get; set; }
        public decimal? QUAD { get; set; }
        public decimal? EXBED { get; set; }
        public decimal? BABY { get; set; }
        public decimal? CHDY { get; set; }
        public decimal? CHDE { get; set; }
        public decimal? FIRSTBABY { get; set; }
        public decimal? FIRSTCHDY { get; set; }
        public decimal? FIRSTCHDE { get; set; }
        public decimal? SNGBABY { get; set; }
        public decimal? SNGCHDY { get; set; }
        public decimal? SNGCHDE { get; set; }
        public decimal? SNGFIRSTBABY { get; set; }
        public decimal? SNGFIRSTCHDY { get; set; }
        public decimal? SNGFIRSTCHDE { get; set; }
        public byte? MINLOS { get; set; }
        public byte? MAXLOS { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public double? COMMISSIONPERCENT { get; set; }
        public bool? COMMISSIONINCLUDED { get; set; }
        public byte? FIXPRICE { get; set; }
        public int? PRICESORT { get; set; }
        public byte CHILDCALCKIND { get; set; }
        public decimal? TRPBABY { get; set; }
        public decimal? TRPCHDY { get; set; }
        public decimal? TRPCHDE { get; set; }
        public decimal? TRPFIRSTBABY { get; set; }
        public decimal? TRPFIRSTCHDY { get; set; }
        public decimal? TRPFIRSTCHDE { get; set; }
        public byte SNGCHILDCALCKIND { get; set; }
        public byte TRPCHILDCALCKIND { get; set; }
        public short? MINDAY_RATE { get; set; }

        public virtual STDHOTEL_PRICECONDITION? PRICECONDITION { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS> STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT_CONTRACT> STDHOTEL_RATECODE_DISCOUNT_CONTRACT { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

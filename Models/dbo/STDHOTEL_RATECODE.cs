using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATECODE : EntityBase // My Handlebars Helper
    {
        public STDHOTEL_RATECODE()
        {
            HOTEL_RESERVATION_DETAILS = new HashSet<HOTEL_RESERVATION_DETAILS>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            STDHOTEL_RATECODE_DISCOUNT = new HashSet<STDHOTEL_RATECODE_DISCOUNT>();
            STDHOTEL_RATECODE_MARKUP = new HashSet<STDHOTEL_RATECODE_MARKUP>();
        }

        public Guid ID { get; set; }
        public Guid HOTELID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string CURCODE { get; set; } = null!;
        public Guid? CORPID { get; set; }
        public short? BABY_MAXAGE { get; set; }
        public short? CHDY_MAXAGE { get; set; }
        public short? CHDE_MAXAGE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public double? SNG { get; set; }
        public double? DBL { get; set; }
        public double? TRP { get; set; }
        public double? QUAD { get; set; }
        public double? EXBED { get; set; }
        public double? BABY { get; set; }
        public double? CHDY { get; set; }
        public double? CHDE { get; set; }
        public double? FIRSTBABY { get; set; }
        public double? FIRSTCHDY { get; set; }
        public double? FIRSTCHDE { get; set; }
        public double? SNGBABY { get; set; }
        public double? SNGCHDY { get; set; }
        public double? SNGCHDE { get; set; }
        public double? SNGFIRSTBABY { get; set; }
        public double? SNGFIRSTCHDY { get; set; }
        public double? SNGFIRSTCHDE { get; set; }
        public double? COMMISSIONPERCENT { get; set; }
        public bool? COMMISSIONINCLUDED { get; set; }
        public double? TRPBABY { get; set; }
        public double? TRPCHDY { get; set; }
        public double? TRPCHDE { get; set; }
        public double? TRPFIRSTBABY { get; set; }
        public double? TRPFIRSTCHDY { get; set; }
        public double? TRPFIRSTCHDE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP? CORP { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual ICollection<HOTEL_RESERVATION_DETAILS> HOTEL_RESERVATION_DETAILS { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT> STDHOTEL_RATECODE_DISCOUNT { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_MARKUP> STDHOTEL_RATECODE_MARKUP { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

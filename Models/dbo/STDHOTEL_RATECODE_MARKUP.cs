using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATECODE_MARKUP : EntityBase // My Handlebars Helper
    {
        public STDHOTEL_RATECODE_MARKUP()
        {
            STDHOTEL_RATECODE_MARKUP_MARKETS = new HashSet<STDHOTEL_RATECODE_MARKUP_MARKETS>();
            STDHOTEL_RATECODE_MARKUP_ROOMTYPE = new HashSet<STDHOTEL_RATECODE_MARKUP_ROOMTYPE>();
        }

        public Guid ID { get; set; }
        public Guid RATECODEID { get; set; }
        public DateTime STAYFROM { get; set; }
        public DateTime STAYTO { get; set; }
        public string? STAYINGDAYS { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public double? RATE { get; set; }
        public byte APPLY_TYPE { get; set; }
        public string? CURCODE { get; set; }
        public byte APPLYZONE { get; set; }
        public Guid? AGENCYID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CURCODE? CURCODENavigation { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDHOTEL_RATECODE RATECODE { get; set; } = null!;
        public virtual ICollection<STDHOTEL_RATECODE_MARKUP_MARKETS> STDHOTEL_RATECODE_MARKUP_MARKETS { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_MARKUP_ROOMTYPE> STDHOTEL_RATECODE_MARKUP_ROOMTYPE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

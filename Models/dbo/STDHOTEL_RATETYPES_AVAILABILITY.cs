using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATETYPES_AVAILABILITY : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid RATETYPEID { get; set; }
        public Guid CORPID { get; set; }
        public DateTime DATE { get; set; }
        public int? DEFINEDQUOTA { get; set; }
        public Guid ROOMTYPEID { get; set; }
        public Guid? MARKETID { get; set; }

        public virtual STDHOTEL_MARKET? MARKET { get; set; }
        public virtual STDHOTEL_RATETYPE RATETYPE { get; set; } = null!;
        public virtual STDHOTEL_ROOMTYPES ROOMTYPE { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

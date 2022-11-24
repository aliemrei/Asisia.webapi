using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatecodeMarkup : EntityBase // My Handlebars Helper
    {
        public StdhotelRatecodeMarkup()
        {
            StdhotelRatecodeMarkupMarkets = new HashSet<StdhotelRatecodeMarkupMarkets>();
            StdhotelRatecodeMarkupRoomtype = new HashSet<StdhotelRatecodeMarkupRoomtype>();
        }

        public Guid Id { get; set; }
        public Guid Ratecodeid { get; set; }
        public DateTime Stayfrom { get; set; }
        public DateTime Stayto { get; set; }
        public string? Stayingdays { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public double? Rate { get; set; }
        public byte ApplyType { get; set; }
        public string? Curcode { get; set; }
        public byte Applyzone { get; set; }
        public Guid? Agencyid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Curcode? CurcodeNavigation { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual StdhotelRatecode Ratecode { get; set; } = null!;
        public virtual ICollection<StdhotelRatecodeMarkupMarkets> StdhotelRatecodeMarkupMarkets { get; set; }
        public virtual ICollection<StdhotelRatecodeMarkupRoomtype> StdhotelRatecodeMarkupRoomtype { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

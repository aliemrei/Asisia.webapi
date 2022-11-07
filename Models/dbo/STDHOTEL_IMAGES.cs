using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_IMAGES : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? HOTELID { get; set; }
        public string? DEFINITION { get; set; }
        public bool? DEFAULT { get; set; }
        public int? SORTORDER { get; set; }
        public string? THUMBNAIL { get; set; }
        public string? URL { get; set; }
        public Guid? ROOMTYPEID { get; set; }
        public bool? SHOWINOFFERFORM { get; set; }
        public string? DESCRIPTION { get; set; }
        public Guid UID { get; set; }

        public virtual STDHOTEL? HOTEL { get; set; }
        public virtual STDHOTEL_ROOMTYPES? ROOMTYPE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

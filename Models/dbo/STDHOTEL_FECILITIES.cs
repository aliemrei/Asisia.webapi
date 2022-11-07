using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_FECILITIES : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? HOTELID { get; set; }
        public string? DEFINITION { get; set; }
        public string? CATEGORY { get; set; }
        public bool? ISFREE { get; set; }
        public string? ICON { get; set; }
        public string? SEASONTYPE { get; set; }
        public string? DESCRIPTION { get; set; }
        public Guid? ROOMTYPEID { get; set; }

        public virtual STDHOTEL? HOTEL { get; set; }
        public virtual STDHOTEL_ROOMTYPES? ROOMTYPE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

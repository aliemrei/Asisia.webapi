using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TOUR_IMAGES : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid TOURID { get; set; }
        public Guid? TOUR_PROGRAMID { get; set; }
        public string? DEFINITION { get; set; }
        public bool? DEFAULT { get; set; }
        public int? SORTORDER { get; set; }
        public string? THUMBNAIL { get; set; }
        public string? URL { get; set; }

        public virtual TOUR TOUR { get; set; } = null!;
        public virtual TOUR_PROGRAM? TOUR_PROGRAM { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

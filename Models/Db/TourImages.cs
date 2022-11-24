using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TourImages : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Tourid { get; set; }
        public Guid? TourProgramid { get; set; }
        public string? Definition { get; set; }
        public bool? Default { get; set; }
        public int? Sortorder { get; set; }
        public string? Thumbnail { get; set; }
        public string? Url { get; set; }

        public virtual Tour Tour { get; set; } = null!;
        public virtual TourProgram? TourProgram { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

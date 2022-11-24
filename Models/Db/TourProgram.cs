using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TourProgram : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Tourid { get; set; }
        public int Stepno { get; set; }
        public int Duration { get; set; }
        public short Interval { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public Guid? Hotelid { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public int? Sortorder { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdhotel? Hotel { get; set; }
        public virtual Tour Tour { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

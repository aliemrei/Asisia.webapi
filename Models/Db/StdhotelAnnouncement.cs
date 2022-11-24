using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelAnnouncement : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Hotelid { get; set; }
        public short Kind { get; set; }
        public string? Definition { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public string? Innerhtml { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public string? Markets { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdhotel Hotel { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

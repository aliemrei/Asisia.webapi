using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class BonusDef : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public double? Rate { get; set; }
        public short ApplyType { get; set; }
        public Guid? ProjectGroupid { get; set; }
        public string? Definition { get; set; }
        public string Curcode { get; set; } = null!;
        public DateTime Adddate { get; set; }
        public Guid? Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }

        public virtual Users? AdduserNavigation { get; set; }
        public virtual Corp Corp { get; set; } = null!;
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ProjectGroup? ProjectGroup { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

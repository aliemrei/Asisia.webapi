using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwCampaigns : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid Corpid { get; set; }
        public Guid Resourceid { get; set; }
        public Guid Projectid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public bool Isdeleted { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

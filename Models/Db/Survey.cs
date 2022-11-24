using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Survey : EntityBase // My Handlebars Helper
    {
        public Survey()
        {
            Surveys = new HashSet<Surveys>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public bool? Titlevisible { get; set; }
        public bool Exitlinkvisible { get; set; }
        public bool? Requiredmarks { get; set; }
        public bool? Questionnumbers { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Design { get; set; }
        public bool Confirmbefore { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<Surveys> Surveys { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class CrmCardtypes : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Cardgroupid { get; set; }
        public string Definition { get; set; } = null!;
        public string? Title { get; set; }
        public string? CarduseRules { get; set; }
        public string? Cardbrandiconurl { get; set; }
        public bool? ShowwifiIcon { get; set; }
        public bool? ShowchipIcon { get; set; }
        public bool? ShowcardBrand { get; set; }
        public string Colorgroup1 { get; set; } = null!;
        public string Colorgroup2 { get; set; } = null!;
        public string Colorgroup3 { get; set; } = null!;
        public string Colorgroup4 { get; set; } = null!;
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string Backcolor1 { get; set; } = null!;
        public string Backcolor2 { get; set; } = null!;
        public string? Cardbrandlogo { get; set; }
        public string? Backgroundlogo { get; set; }
        public bool? Shownumbers { get; set; }
        public bool? Showexpire { get; set; }
        public bool? Showcardholdername { get; set; }
        public bool? ShowStripbottom { get; set; }
        public bool? ShowStriptop { get; set; }
        public string CardnumberMargin { get; set; } = null!;

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual CrmCardgroups Cardgroup { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

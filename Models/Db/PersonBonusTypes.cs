using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PersonBonusTypes : EntityBase // My Handlebars Helper
    {
        public PersonBonusTypes()
        {
            PersonBonus = new HashSet<PersonBonus>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Isnegative { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Corpid { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<PersonBonus> PersonBonus { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

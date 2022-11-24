using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PersonBonus : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Personid { get; set; }
        public Guid Typeid { get; set; }
        public DateTime? Date { get; set; }
        public double Point { get; set; }
        public Guid? Productid { get; set; }
        public Guid? RequestDetailid { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public double Amount { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Person Person { get; set; } = null!;
        public virtual RequestDetail? RequestDetail { get; set; }
        public virtual PersonBonusTypes Type { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

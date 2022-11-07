using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TOUR_DISCOUNTS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid TOURID { get; set; }
        public string? DEFINITION { get; set; }
        public double DISCOUNT { get; set; }
        public byte DISCOUNTTYPE { get; set; }
        public DateTime? SELLFROM { get; set; }
        public DateTime? SELLTO { get; set; }
        public double? MINPRICE { get; set; }
        public double? MAXPRICE { get; set; }
        public byte? MINPAX { get; set; }
        public byte? MAXPAX { get; set; }
        public byte APPLYTYPE { get; set; }
        public DateTime? TOURFROM { get; set; }
        public DateTime? TOURTO { get; set; }
        public int VALIDCOUNT { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual TOURDISCOUNT DISCOUNTTYPENavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual TOUR TOUR { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

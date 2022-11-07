using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_CATEGORY_ITEMS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid CATID { get; set; }
        public int SORTINDEX { get; set; }
        public bool ISDISABLED { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? HOTELID { get; set; }
        public Guid? TOURID { get; set; }
        public Guid? TICKETID { get; set; }
        public string? THUMBNAILURL { get; set; }
        public string? IMAGEURL { get; set; }
        public double? PRICE { get; set; }
        public double? DISCOUNT { get; set; }
        public string? CURCODE { get; set; }
        public string? DESCRIPTION { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual PORTAL_CATEGORIES CAT { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDHOTEL? HOTEL { get; set; }
        public virtual TICKET? TICKET { get; set; }
        public virtual TOUR? TOUR { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

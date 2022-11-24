using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalCategoryItems : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Catid { get; set; }
        public int Sortindex { get; set; }
        public bool Isdisabled { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Hotelid { get; set; }
        public Guid? Tourid { get; set; }
        public Guid? Ticketid { get; set; }
        public string? Thumbnailurl { get; set; }
        public string? Imageurl { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
        public string? Curcode { get; set; }
        public string? Description { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual PortalCategories Cat { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdhotel? Hotel { get; set; }
        public virtual Ticket? Ticket { get; set; }
        public virtual Tour? Tour { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

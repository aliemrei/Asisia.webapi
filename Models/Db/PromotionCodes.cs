using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PromotionCodes : EntityBase // My Handlebars Helper
    {
        public PromotionCodes()
        {
            PromotionCodesMarket = new HashSet<PromotionCodesMarket>();
            RequestDetail = new HashSet<RequestDetail>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public short Kind { get; set; }
        public short Type { get; set; }
        public string? Email { get; set; }
        public string Definition { get; set; } = null!;
        public string Code { get; set; } = null!;
        public short Usetype { get; set; }
        public int Usecount { get; set; }
        public short Discounttype { get; set; }
        public short Discountkind { get; set; }
        public double Discount { get; set; }
        public string? Curcode { get; set; }
        public DateTime? Sellfrom { get; set; }
        public DateTime? Sellto { get; set; }
        public DateTime? Stayfrom { get; set; }
        public DateTime? Stayto { get; set; }
        public string? Description { get; set; }
        public Guid? Hotelid { get; set; }
        public Guid? Tourid { get; set; }
        public Guid? Ticketid { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Curcode? CurcodeNavigation { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdhotel? Hotel { get; set; }
        public virtual Ticket? Ticket { get; set; }
        public virtual Tour? Tour { get; set; }
        public virtual ICollection<PromotionCodesMarket> PromotionCodesMarket { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

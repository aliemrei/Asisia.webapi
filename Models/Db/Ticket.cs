using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Ticket : EntityBase // My Handlebars Helper
    {
        public Ticket()
        {
            PortalCategoryItems = new HashSet<PortalCategoryItems>();
            ProjectGroupdetail = new HashSet<ProjectGroupdetail>();
            PromotionCodes = new HashSet<PromotionCodes>();
            RequestDetail = new HashSet<RequestDetail>();
            ReservationSettings = new HashSet<ReservationSettings>();
            TicketHours = new HashSet<TicketHours>();
            TicketPrices = new HashSet<TicketPrices>();
            TileItemoption = new HashSet<TileItemoption>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string? Definition { get; set; }
        public byte Tickettype { get; set; }
        public byte? Endofminute { get; set; }
        public int Maxselldate { get; set; }
        public int Adultmandatory { get; set; }
        public int Childmandatory { get; set; }
        public bool Isdisabled { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Plu { get; set; }
        public string? Description { get; set; }
        public int Sortorder { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<PortalCategoryItems> PortalCategoryItems { get; set; }
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<ReservationSettings> ReservationSettings { get; set; }
        public virtual ICollection<TicketHours> TicketHours { get; set; }
        public virtual ICollection<TicketPrices> TicketPrices { get; set; }
        public virtual ICollection<TileItemoption> TileItemoption { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

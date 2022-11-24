using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Agency : EntityBase // My Handlebars Helper
    {
        public Agency()
        {
            Request = new HashSet<Request>();
            StdhotelRatecodeDiscount = new HashSet<StdhotelRatecodeDiscount>();
            TicketPrices = new HashSet<TicketPrices>();
            TransferPrices = new HashSet<TransferPrices>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Fullname { get; set; } = null!;
        public long? Tel1 { get; set; }
        public long? Tel2 { get; set; }
        public string? Email { get; set; }
        public bool Isdisabled { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Authorizedid { get; set; }
        public int Intid { get; set; }
        public Guid? Groupid { get; set; }
        public string? DefaultCurcode { get; set; }
        public double Quota { get; set; }
        public double PaymentRate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Person? Authorized { get; set; }
        public virtual Corp Corp { get; set; } = null!;
        public virtual Curcode? DefaultCurcodeNavigation { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual AgencyGroup? Group { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; }
        public virtual ICollection<TicketPrices> TicketPrices { get; set; }
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Vehicletypes : EntityBase // My Handlebars Helper
    {
        public Vehicletypes()
        {
            RequestDetail = new HashSet<RequestDetail>();
            TransferPrices = new HashSet<TransferPrices>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Vehicletype { get; set; } = null!;
        public string Definition { get; set; } = null!;
        public string? Description { get; set; }
        public int PersonCount { get; set; }
        public string? SpecialCode { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? BaggageCapacity { get; set; }
        public bool? Aircondition { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdvehicletypes VehicletypeNavigation { get; set; } = null!;
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

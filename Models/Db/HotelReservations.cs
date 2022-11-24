using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class HotelReservations : EntityBase // My Handlebars Helper
    {
        public HotelReservations()
        {
            HotelReservationDetails = new HashSet<HotelReservationDetails>();
        }

        public Guid Id { get; set; }
        public int Resid { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }
        public Guid? RequestDetailid { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? LastupdateResdetail { get; set; }
        public bool IsconfirmedHotel { get; set; }
        public bool IsconfirmedGuest { get; set; }
        public bool IsconfirmedOwner { get; set; }
        public string? Entid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual RequestDetail? RequestDetail { get; set; }
        public virtual ICollection<HotelReservationDetails> HotelReservationDetails { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

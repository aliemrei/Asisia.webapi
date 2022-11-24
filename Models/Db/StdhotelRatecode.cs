using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatecode : EntityBase // My Handlebars Helper
    {
        public StdhotelRatecode()
        {
            HotelReservationDetails = new HashSet<HotelReservationDetails>();
            RequestDetail = new HashSet<RequestDetail>();
            StdhotelRatecodeDiscount = new HashSet<StdhotelRatecodeDiscount>();
            StdhotelRatecodeMarkup = new HashSet<StdhotelRatecodeMarkup>();
        }

        public Guid Id { get; set; }
        public Guid Hotelid { get; set; }
        public string Definition { get; set; } = null!;
        public string Curcode { get; set; } = null!;
        public Guid? Corpid { get; set; }
        public short? BabyMaxage { get; set; }
        public short? ChdyMaxage { get; set; }
        public short? ChdeMaxage { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public double? Sng { get; set; }
        public double? Dbl { get; set; }
        public double? Trp { get; set; }
        public double? Quad { get; set; }
        public double? Exbed { get; set; }
        public double? Baby { get; set; }
        public double? Chdy { get; set; }
        public double? Chde { get; set; }
        public double? Firstbaby { get; set; }
        public double? Firstchdy { get; set; }
        public double? Firstchde { get; set; }
        public double? Sngbaby { get; set; }
        public double? Sngchdy { get; set; }
        public double? Sngchde { get; set; }
        public double? Sngfirstbaby { get; set; }
        public double? Sngfirstchdy { get; set; }
        public double? Sngfirstchde { get; set; }
        public double? Commissionpercent { get; set; }
        public bool? Commissionincluded { get; set; }
        public double? Trpbaby { get; set; }
        public double? Trpchdy { get; set; }
        public double? Trpchde { get; set; }
        public double? Trpfirstbaby { get; set; }
        public double? Trpfirstchdy { get; set; }
        public double? Trpfirstchde { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp? Corp { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual ICollection<HotelReservationDetails> HotelReservationDetails { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; }
        public virtual ICollection<StdhotelRatecodeMarkup> StdhotelRatecodeMarkup { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

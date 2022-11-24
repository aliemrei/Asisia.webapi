using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatecodeDetail : EntityBase // My Handlebars Helper
    {
        public StdhotelRatecodeDetail()
        {
            StdhotelRatecodeDetailAgencygroups = new HashSet<StdhotelRatecodeDetailAgencygroups>();
            StdhotelRatecodeDiscountContract = new HashSet<StdhotelRatecodeDiscountContract>();
        }

        public Guid Id { get; set; }
        public Guid Hotelid { get; set; }
        public Guid Ratecodeid { get; set; }
        public string Definition { get; set; } = null!;
        public byte Type { get; set; }
        public DateTime? Sellfrom { get; set; }
        public DateTime? Sellto { get; set; }
        public DateTime? Stayfrom { get; set; }
        public DateTime? Stayto { get; set; }
        public string? Checkindays { get; set; }
        public string? Checkoutdays { get; set; }
        public string? Stayingdays { get; set; }
        public Guid? Priceconditionid { get; set; }
        public decimal? Sng { get; set; }
        public decimal? Dbl { get; set; }
        public decimal? Trp { get; set; }
        public decimal? Quad { get; set; }
        public decimal? Exbed { get; set; }
        public decimal? Baby { get; set; }
        public decimal? Chdy { get; set; }
        public decimal? Chde { get; set; }
        public decimal? Firstbaby { get; set; }
        public decimal? Firstchdy { get; set; }
        public decimal? Firstchde { get; set; }
        public decimal? Sngbaby { get; set; }
        public decimal? Sngchdy { get; set; }
        public decimal? Sngchde { get; set; }
        public decimal? Sngfirstbaby { get; set; }
        public decimal? Sngfirstchdy { get; set; }
        public decimal? Sngfirstchde { get; set; }
        public byte? Minlos { get; set; }
        public byte? Maxlos { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public double? Commissionpercent { get; set; }
        public bool? Commissionincluded { get; set; }
        public byte? Fixprice { get; set; }
        public int? Pricesort { get; set; }
        public byte Childcalckind { get; set; }
        public decimal? Trpbaby { get; set; }
        public decimal? Trpchdy { get; set; }
        public decimal? Trpchde { get; set; }
        public decimal? Trpfirstbaby { get; set; }
        public decimal? Trpfirstchdy { get; set; }
        public decimal? Trpfirstchde { get; set; }
        public byte Sngchildcalckind { get; set; }
        public byte Trpchildcalckind { get; set; }
        public short? MindayRate { get; set; }

        public virtual StdhotelPricecondition? Pricecondition { get; set; }
        public virtual ICollection<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroups { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscountContract> StdhotelRatecodeDiscountContract { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

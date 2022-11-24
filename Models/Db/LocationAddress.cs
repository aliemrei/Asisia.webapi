using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class LocationAddress : EntityBase // My Handlebars Helper
    {
        public LocationAddress()
        {
            Corp = new HashSet<Corp>();
            PersonAddress = new HashSet<PersonAddress>();
            ProjectGroup = new HashSet<ProjectGroup>();
            Request = new HashSet<Request>();
            Stdhotel = new HashSet<Stdhotel>();
            Stdstore = new HashSet<Stdstore>();
        }

        public Guid Id { get; set; }
        public short? Type { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public Guid? Countryid { get; set; }
        public Guid? Cityid { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Zipcode { get; set; }
        public Guid? Districtid { get; set; }
        public byte InvoiceType { get; set; }
        public string? InvoiceTaxno { get; set; }
        public string? InvoiceTaxplacename { get; set; }
        public string? InvoiceEmail { get; set; }
        public string? InvoiceTitle { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual District? District { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<Corp> Corp { get; set; }
        public virtual ICollection<PersonAddress> PersonAddress { get; set; }
        public virtual ICollection<ProjectGroup> ProjectGroup { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<Stdhotel> Stdhotel { get; set; }
        public virtual ICollection<Stdstore> Stdstore { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

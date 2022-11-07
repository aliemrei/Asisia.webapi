using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class LOCATION_ADDRESS : EntityBase // My Handlebars Helper
    {
        public LOCATION_ADDRESS()
        {
            CORP = new HashSet<CORP>();
            PERSON_ADDRESS = new HashSet<PERSON_ADDRESS>();
            PROJECT_GROUP = new HashSet<PROJECT_GROUP>();
            REQUEST = new HashSet<REQUEST>();
            STDHOTEL = new HashSet<STDHOTEL>();
            STDSTORE = new HashSet<STDSTORE>();
        }

        public Guid ID { get; set; }
        public short? TYPE { get; set; }
        public string? LINE1 { get; set; }
        public string? LINE2 { get; set; }
        public Guid? COUNTRYID { get; set; }
        public Guid? CITYID { get; set; }
        public double? LATITUDE { get; set; }
        public double? LONGITUDE { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? ZIPCODE { get; set; }
        public Guid? DISTRICTID { get; set; }
        public byte INVOICE_TYPE { get; set; }
        public string? INVOICE_TAXNO { get; set; }
        public string? INVOICE_TAXPLACENAME { get; set; }
        public string? INVOICE_EMAIL { get; set; }
        public string? INVOICE_TITLE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CITY? CITY { get; set; }
        public virtual COUNTRY? COUNTRY { get; set; }
        public virtual DISTRICT? DISTRICT { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<CORP> CORP { get; set; }
        public virtual ICollection<PERSON_ADDRESS> PERSON_ADDRESS { get; set; }
        public virtual ICollection<PROJECT_GROUP> PROJECT_GROUP { get; set; }
        public virtual ICollection<REQUEST> REQUEST { get; set; }
        public virtual ICollection<STDHOTEL> STDHOTEL { get; set; }
        public virtual ICollection<STDSTORE> STDSTORE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

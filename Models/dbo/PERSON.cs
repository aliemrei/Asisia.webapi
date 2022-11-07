using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PERSON : EntityBase // My Handlebars Helper
    {
        public PERSON()
        {
            AGENCY = new HashSet<AGENCY>();
            CALL_JOBS = new HashSet<CALL_JOBS>();
            CONTACT_FORM = new HashSet<CONTACT_FORM>();
            PERSON_ADDRESS = new HashSet<PERSON_ADDRESS>();
            PERSON_BONUS = new HashSet<PERSON_BONUS>();
            PERSON_CCARDS = new HashSet<PERSON_CCARDS>();
            PORTAL_USER = new HashSet<PORTAL_USER>();
            REQUEST = new HashSet<REQUEST>();
            SALES_REQ = new HashSet<SALES_REQ>();
            SURVEYS = new HashSet<SURVEYS>();
        }

        public Guid ID { get; set; }
        public string? FIRSTNAME { get; set; }
        public string? SECONDNAME { get; set; }
        public string? LASTNAME { get; set; }
        public string FULLNAME { get; set; } = null!;
        public short DEFAULTNAME { get; set; }
        public short? GENDER { get; set; }
        public Guid? NATIONALITY { get; set; }
        public string? IDENTITYNO { get; set; }
        public DateTime? BIRTHDATE { get; set; }
        public long? TEL1 { get; set; }
        public long? TEL2 { get; set; }
        public string? EMAIL { get; set; }
        public short TYPE { get; set; }
        public Guid CORPID { get; set; }
        public Guid? GROUPID { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? RAKAM_ID { get; set; }
        public bool NEWSLATTER_FROMEMAIL { get; set; }
        public bool NEWSLATTER_FROMSMS { get; set; }
        public byte KVKK { get; set; }
        public string? TITLE { get; set; }
        public string? BONUS_CARDTYPE { get; set; }
        public double BONUS_LEFT { get; set; }
        public double BONUS_EXPRIED { get; set; }
        public double BONUS_USED { get; set; }
        public double BONUS_LEFTAMOUNT { get; set; }
        public double BONUS_GAINED { get; set; }
        public string? ENT_ID { get; set; }
        public bool REPEAT_GUEST { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PERSON_GROUP? GROUP { get; set; }
        public virtual COUNTRY? NATIONALITYNavigation { get; set; }
        public virtual ICollection<AGENCY> AGENCY { get; set; }
        public virtual ICollection<CALL_JOBS> CALL_JOBS { get; set; }
        public virtual ICollection<CONTACT_FORM> CONTACT_FORM { get; set; }
        public virtual ICollection<PERSON_ADDRESS> PERSON_ADDRESS { get; set; }
        public virtual ICollection<PERSON_BONUS> PERSON_BONUS { get; set; }
        public virtual ICollection<PERSON_CCARDS> PERSON_CCARDS { get; set; }
        public virtual ICollection<PORTAL_USER> PORTAL_USER { get; set; }
        public virtual ICollection<REQUEST> REQUEST { get; set; }
        public virtual ICollection<SALES_REQ> SALES_REQ { get; set; }
        public virtual ICollection<SURVEYS> SURVEYS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

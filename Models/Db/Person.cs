using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Person : EntityBase // My Handlebars Helper
    {
        public Person()
        {
            Agency = new HashSet<Agency>();
            CallJobs = new HashSet<CallJobs>();
            ContactForm = new HashSet<ContactForm>();
            PersonAddress = new HashSet<PersonAddress>();
            PersonBonus = new HashSet<PersonBonus>();
            PersonCcards = new HashSet<PersonCcards>();
            PortalUser = new HashSet<PortalUser>();
            Request = new HashSet<Request>();
            SalesReq = new HashSet<SalesReq>();
            Surveys = new HashSet<Surveys>();
        }

        public Guid Id { get; set; }
        public string? Firstname { get; set; }
        public string? Secondname { get; set; }
        public string? Lastname { get; set; }
        public string Fullname { get; set; } = null!;
        public short Defaultname { get; set; }
        public short? Gender { get; set; }
        public Guid? Nationality { get; set; }
        public string? Identityno { get; set; }
        public DateTime? Birthdate { get; set; }
        public long? Tel1 { get; set; }
        public long? Tel2 { get; set; }
        public string? Email { get; set; }
        public short Type { get; set; }
        public Guid Corpid { get; set; }
        public Guid? Groupid { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? RakamId { get; set; }
        public bool NewslatterFromemail { get; set; }
        public bool NewslatterFromsms { get; set; }
        public byte Kvkk { get; set; }
        public string? Title { get; set; }
        public string? BonusCardtype { get; set; }
        public double BonusLeft { get; set; }
        public double BonusExpried { get; set; }
        public double BonusUsed { get; set; }
        public double BonusLeftamount { get; set; }
        public double BonusGained { get; set; }
        public string? EntId { get; set; }
        public bool RepeatGuest { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual PersonGroup? Group { get; set; }
        public virtual Country? NationalityNavigation { get; set; }
        public virtual ICollection<Agency> Agency { get; set; }
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        public virtual ICollection<ContactForm> ContactForm { get; set; }
        public virtual ICollection<PersonAddress> PersonAddress { get; set; }
        public virtual ICollection<PersonBonus> PersonBonus { get; set; }
        public virtual ICollection<PersonCcards> PersonCcards { get; set; }
        public virtual ICollection<PortalUser> PortalUser { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<SalesReq> SalesReq { get; set; }
        public virtual ICollection<Surveys> Surveys { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PERSON")]
    [Index(nameof(RakamId), Name = "IX_PERSON")]
    [Index(nameof(Firstname), Name = "IX_PERSON_1")]
    [Index(nameof(Nationality), Name = "IX_PERSON_10")]
    [Index(nameof(Isdeleted), Name = "IX_PERSON_11")]
    [Index(nameof(Kvkk), Name = "IX_PERSON_12")]
    [Index(nameof(Email), Name = "IX_PERSON_13")]
    [Index(nameof(Lastname), Name = "IX_PERSON_2")]
    [Index(nameof(Secondname), Name = "IX_PERSON_3")]
    [Index(nameof(Firstname), Name = "IX_PERSON_4")]
    [Index(nameof(Lastname), Name = "IX_PERSON_5")]
    [Index(nameof(Fullname), Name = "IX_PERSON_6")]
    [Index(nameof(Tel1), Name = "IX_PERSON_7")]
    [Index(nameof(Tel2), Name = "IX_PERSON_8")]
    [Index(nameof(Type), Name = "IX_PERSON_9")]
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

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(70)]
        public string? Firstname { get; set; }
        [Column("SECONDNAME")]
        [StringLength(70)]
        public string? Secondname { get; set; }
        [Column("LASTNAME")]
        [StringLength(70)]
        public string? Lastname { get; set; }
        [Column("FULLNAME")]
        [StringLength(212)]
        public string Fullname { get; set; } = null!;
        [Column("DEFAULTNAME")]
        public short Defaultname { get; set; }
        [Column("GENDER")]
        public short? Gender { get; set; }
        [Column("NATIONALITY")]
        public Guid? Nationality { get; set; }
        [Column("IDENTITYNO")]
        [StringLength(15)]
        public string? Identityno { get; set; }
        [Column("BIRTHDATE", TypeName = "date")]
        public DateTime? Birthdate { get; set; }
        [Column("TEL1")]
        public long? Tel1 { get; set; }
        [Column("TEL2")]
        public long? Tel2 { get; set; }
        [Column("EMAIL")]
        [StringLength(200)]
        public string? Email { get; set; }
        [Column("TYPE")]
        public short Type { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("GROUPID")]
        public Guid? Groupid { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("RAKAM_ID")]
        [StringLength(15)]
        public string? RakamId { get; set; }
        [Column("NEWSLATTER_FROMEMAIL")]
        public bool NewslatterFromemail { get; set; }
        [Column("NEWSLATTER_FROMSMS")]
        public bool NewslatterFromsms { get; set; }
        [Column("KVKK")]
        public byte Kvkk { get; set; }
        [Column("TITLE")]
        [StringLength(10)]
        public string? Title { get; set; }
        [Column("BONUS_CARDTYPE")]
        [StringLength(150)]
        public string? BonusCardtype { get; set; }
        [Column("BONUS_LEFT")]
        public double BonusLeft { get; set; }
        [Column("BONUS_EXPRIED")]
        public double BonusExpried { get; set; }
        [Column("BONUS_USED")]
        public double BonusUsed { get; set; }
        [Column("BONUS_LEFTAMOUNT")]
        public double BonusLeftamount { get; set; }
        [Column("BONUS_GAINED")]
        public double BonusGained { get; set; }
        [Column("ENT_ID")]
        [StringLength(150)]
        public string? EntId { get; set; }
        [Column("REPEAT_GUEST")]
        public bool RepeatGuest { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PersonAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Person")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PersonEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Groupid))]
        [InverseProperty(nameof(PersonGroup.Person))]
        public virtual PersonGroup? Group { get; set; }
        [ForeignKey(nameof(Nationality))]
        [InverseProperty(nameof(Country.Person))]
        public virtual Country? NationalityNavigation { get; set; }
        [InverseProperty("Authorized")]
        public virtual ICollection<Agency> Agency { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<ContactForm> ContactForm { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonAddress> PersonAddress { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonBonus> PersonBonus { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonCcards> PersonCcards { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PortalUser> PortalUser { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<Request> Request { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<SalesReq> SalesReq { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<Surveys> Surveys { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

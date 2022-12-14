using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL")]
    [Index(nameof(Uid), Name = "IX_PORTAL", IsUnique = true)]
    public partial class Portal : EntityBase 
    {
        public Portal()
        {
            PortalAuthIpaddress = new HashSet<PortalAuthIpaddress>();
            PortalCategories = new HashSet<PortalCategories>();
            PortalCurrencies = new HashSet<PortalCurrencies>();
            PortalDescription = new HashSet<PortalDescription>();
            PortalDomains = new HashSet<PortalDomains>();
            PortalEmails = new HashSet<PortalEmails>();
            PortalLanguages = new HashSet<PortalLanguages>();
            PortalSettings = new HashSet<PortalSettings>();
            VirtualPosDefaults = new HashSet<VirtualPosDefaults>();
            VirtualPosPaymentRequests = new HashSet<VirtualPosPaymentRequests>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("UID")]
        [RequiredIf]
        public Guid Uid { get; set; }


        [Column("PROJECTID")]
        
        public Guid? Projectid { get; set; }


        [Column("PROJECT_DETAILID")]
        
        public Guid? ProjectDetailid { get; set; }


        [Column("CORPORATIONID")]
        
        public Guid? Corporationid { get; set; }


        [Column("DOMAIN")]
        [StringLength(100)]
        
        public string? Domain { get; set; }


        [Column("TEMPLATENAME")]
        [StringLength(50)]
        
        public string? Templatename { get; set; }


        [Column("LOGININFO", TypeName = "ntext")]
        
        public string? Logininfo { get; set; }


        [Column("RESOURCEID")]
        
        public Guid? Resourceid { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("DEFAULT_LANG")]
        [StringLength(5)]
        
        public string? DefaultLang { get; set; }


        [Column("DEFAULT_CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        [RequiredIf]
        public string DefaultCurcode { get; set; } = null!;


        [Column("LOGO")]
        [StringLength(250)]
        
        public string? Logo { get; set; }


        [Column("DISPLAYNAME")]
        [StringLength(100)]
        
        public string? Displayname { get; set; }


        [Column("CONTACT_PHONE")]
        [StringLength(40)]
        
        public string? ContactPhone { get; set; }


        [Column("CONTACT_EMAIL")]
        [StringLength(240)]
        
        public string? ContactEmail { get; set; }


        [Column("MODE")]
        [RequiredIf]
        public byte Mode { get; set; }


        [Column("CONTACT_MAPURL")]
        [StringLength(400)]
        
        public string? ContactMapurl { get; set; }


        [Column("FAVICON")]
        [StringLength(250)]
        
        public string? Favicon { get; set; }


        [Column("SET_LANG_BYMARKET")]
        [RequiredIf]
        public bool SetLangBymarket { get; set; }


        [Column("SET_CURCODE_BYMARKET")]
        [RequiredIf]
        public bool SetCurcodeBymarket { get; set; }


        [Required]
        [Column("MULTIPLE_CURCODES")]
        
        public bool? MultipleCurcodes { get; set; }


        [Column("OFFER_TEXT")]
        
        public string? OfferText { get; set; }


        [Column("OFFER_RULES")]
        
        public string? OfferRules { get; set; }


        [Column("OFFER_BANNER")]
        [StringLength(350)]
        
        public string? OfferBanner { get; set; }


        [Column("ACCOUNT_USE")]
        [RequiredIf]
        public bool AccountUse { get; set; }


        [Column("ACCOUNT_BACKGROUNDURL")]
        [StringLength(350)]
        
        public string? AccountBackgroundurl { get; set; }


        [Column("ACCOUNT_LOGO")]
        [StringLength(350)]
        
        public string? AccountLogo { get; set; }


        [Column("ACCOUNT_COPYRIGHT")]
        [StringLength(150)]
        
        public string? AccountCopyright { get; set; }


        [Required]
        [Column("ACCOUNT_LOGIN_BY_PHONE")]
        
        public bool? AccountLoginByPhone { get; set; }


        [Column("ACCOUNT_LOGIN_BY_ROOMNO")]
        [RequiredIf]
        public bool AccountLoginByRoomno { get; set; }


        [Required]
        [Column("ACCOUNT_LOGIN_BY_VOUCHERNO")]
        
        public bool? AccountLoginByVoucherno { get; set; }


        [Required]
        [Column("ACCOUNT_AUTO_CREATEUSER_ONFORGETPASSFORM")]
        
        public bool? AccountAutoCreateuserOnforgetpassform { get; set; }


        [Column("CRM_ACTIVE")]
        [RequiredIf]
        public bool CrmActive { get; set; }


        [Column("PORTAL_GROUPNAME")]
        [StringLength(50)]
        
        public string? PortalGroupname { get; set; }


        [Column("POSTEK_DOMAIN")]
        [StringLength(100)]
        
        public string? PostekDomain { get; set; }



        [ForeignKey(nameof(Corporationid))]
        [InverseProperty(nameof(Corp.Portal))]
        public virtual Corp? Corporation { get; set; }
        [ForeignKey(nameof(DefaultCurcode))]
        [InverseProperty(nameof(Curcode.Portal))]
        public virtual Curcode DefaultCurcodeNavigation { get; set; } = null!;
        [ForeignKey(nameof(Projectid))]
        [InverseProperty(nameof(ProjectGroup.Portal))]
        public virtual ProjectGroup? Project { get; set; }
        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.Portal))]
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }
        public virtual ICollection<PortalAuthIpaddress> PortalAuthIpaddress { get; set; }
        [InverseProperty("Portal")]
        public virtual ICollection<PortalCategories> PortalCategories { get; set; }
        public virtual ICollection<PortalCurrencies> PortalCurrencies { get; set; }
        public virtual ICollection<PortalDescription> PortalDescription { get; set; }
        public virtual ICollection<PortalDomains> PortalDomains { get; set; }
        public virtual ICollection<PortalEmails> PortalEmails { get; set; }
        public virtual ICollection<PortalLanguages> PortalLanguages { get; set; }
        public virtual ICollection<PortalSettings> PortalSettings { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaults { get; set; }
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequests { get; set; }

            }
}

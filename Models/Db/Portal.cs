using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Portal : EntityBase // My Handlebars Helper
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

        public int Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? Projectid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public Guid? Corporationid { get; set; }
        public string? Domain { get; set; }
        public string? Templatename { get; set; }
        public string? Logininfo { get; set; }
        public Guid? Resourceid { get; set; }
        public bool Isdisabled { get; set; }
        public string? DefaultLang { get; set; }
        public string DefaultCurcode { get; set; } = null!;
        public string? Logo { get; set; }
        public string? Displayname { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }
        public byte Mode { get; set; }
        public string? ContactMapurl { get; set; }
        public string? Favicon { get; set; }
        public bool SetLangBymarket { get; set; }
        public bool SetCurcodeBymarket { get; set; }
        public bool? MultipleCurcodes { get; set; }
        public string? OfferText { get; set; }
        public string? OfferRules { get; set; }
        public string? OfferBanner { get; set; }
        public bool AccountUse { get; set; }
        public string? AccountBackgroundurl { get; set; }
        public string? AccountLogo { get; set; }
        public string? AccountCopyright { get; set; }
        public bool? AccountLoginByPhone { get; set; }
        public bool AccountLoginByRoomno { get; set; }
        public bool? AccountLoginByVoucherno { get; set; }
        public bool? AccountAutoCreateuserOnforgetpassform { get; set; }
        public bool CrmActive { get; set; }
        public string? PortalGroupname { get; set; }
        public string? PostekDomain { get; set; }

        public virtual Corp? Corporation { get; set; }
        public virtual Curcode DefaultCurcodeNavigation { get; set; } = null!;
        public virtual ProjectGroup? Project { get; set; }
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }
        public virtual ICollection<PortalAuthIpaddress> PortalAuthIpaddress { get; set; }
        public virtual ICollection<PortalCategories> PortalCategories { get; set; }
        public virtual ICollection<PortalCurrencies> PortalCurrencies { get; set; }
        public virtual ICollection<PortalDescription> PortalDescription { get; set; }
        public virtual ICollection<PortalDomains> PortalDomains { get; set; }
        public virtual ICollection<PortalEmails> PortalEmails { get; set; }
        public virtual ICollection<PortalLanguages> PortalLanguages { get; set; }
        public virtual ICollection<PortalSettings> PortalSettings { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaults { get; set; }
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequests { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

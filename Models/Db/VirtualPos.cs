using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPos : EntityBase // My Handlebars Helper
    {
        public VirtualPos()
        {
            VirtualPosAccounts = new HashSet<VirtualPosAccounts>();
            VirtualPosDefaultsAmexExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsAmexPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsJcbExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsJcbPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsMaestroExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsMaestroPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsMasterExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsMasterPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsUnionpayExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsUnionpayPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsVisaExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsVisaPos = new HashSet<VirtualPosDefaults>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; } = null!;
        public string? Name { get; set; }
        public string Class { get; set; } = null!;
        public Guid Corpid { get; set; }
        public string? BinnumberName { get; set; }
        public string? AccInvCode { get; set; }
        public string? AccPayCode { get; set; }
        public int Intid { get; set; }
        public string? Iconurl { get; set; }
        public string? Fontcolor { get; set; }
        public string? Forecolor { get; set; }
        public string? Xmlusername { get; set; }
        public string? Xmlpassword { get; set; }

        public virtual Corp Corp { get; set; } = null!;
        public virtual ICollection<VirtualPosAccounts> VirtualPosAccounts { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsAmexExPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsAmexPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsJcbExPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsJcbPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsMaestroExPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsMaestroPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsMasterExPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsMasterPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsUnionpayExPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsUnionpayPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsVisaExPos { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsVisaPos { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

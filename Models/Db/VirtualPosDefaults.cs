using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosDefaults : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public Guid Portaluid { get; set; }
        public Guid? VisaPosid { get; set; }
        public Guid? MasterPosid { get; set; }
        public Guid? AmexPosid { get; set; }
        public Guid? JcbPosid { get; set; }
        public Guid? UnionpayPosid { get; set; }
        public Guid? MaestroPosid { get; set; }
        public Guid? VisaExPosid { get; set; }
        public Guid? MasterExPosid { get; set; }
        public Guid? AmexExPosid { get; set; }
        public Guid? JcbExPosid { get; set; }
        public Guid? UnionpayExPosid { get; set; }
        public Guid? MaestroExPosid { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual VirtualPos? AmexExPos { get; set; }
        public virtual VirtualPos? AmexPos { get; set; }
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual VirtualPos? JcbExPos { get; set; }
        public virtual VirtualPos? JcbPos { get; set; }
        public virtual VirtualPos? MaestroExPos { get; set; }
        public virtual VirtualPos? MaestroPos { get; set; }
        public virtual VirtualPos? MasterExPos { get; set; }
        public virtual VirtualPos? MasterPos { get; set; }
        public virtual Portal Portalu { get; set; } = null!;
        public virtual VirtualPos? UnionpayExPos { get; set; }
        public virtual VirtualPos? UnionpayPos { get; set; }
        public virtual VirtualPos? VisaExPos { get; set; }
        public virtual VirtualPos? VisaPos { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

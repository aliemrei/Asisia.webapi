using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosAccounts : EntityBase // My Handlebars Helper
    {
        public VirtualPosAccounts()
        {
            VirtualPosAccountInstalments = new HashSet<VirtualPosAccountInstalments>();
            VirtualPosAccountsCurcodes = new HashSet<VirtualPosAccountsCurcodes>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        public Guid Id { get; set; }
        public Guid Posid { get; set; }
        public Guid Corpid { get; set; }
        public string? Clientid { get; set; }
        public string? Terminalid { get; set; }
        public string? Accountname { get; set; }
        public string? Password { get; set; }
        public string? Password3d { get; set; }
        public string? Params { get; set; }
        public byte Use3d { get; set; }
        public string? Posturl { get; set; }
        public bool InstalmentMerge { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Definition { get; set; }
        public string? EntHotelid { get; set; }
        public string? BinnumberName { get; set; }
        public bool IsforeignPos { get; set; }
        public string? Email { get; set; }
        public string? Entid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual VirtualPos Pos { get; set; } = null!;
        public virtual ICollection<VirtualPosAccountInstalments> VirtualPosAccountInstalments { get; set; }
        public virtual ICollection<VirtualPosAccountsCurcodes> VirtualPosAccountsCurcodes { get; set; }
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

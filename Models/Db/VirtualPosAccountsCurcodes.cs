using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosAccountsCurcodes : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Accountid { get; set; }
        public string Curcode { get; set; } = null!;
        public string? Schemes { get; set; }

        public virtual VirtualPosAccounts Account { get; set; } = null!;
        public virtual Curcode CurcodeNavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

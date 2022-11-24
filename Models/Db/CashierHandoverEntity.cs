using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class CashierHandoverEntity : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid CashierHandoverid { get; set; }
        public byte EntityType { get; set; }
        public double Debt { get; set; }
        public string Curcode { get; set; } = null!;

        public virtual CashierHandover CashierHandover { get; set; } = null!;
        public virtual Curcode CurcodeNavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

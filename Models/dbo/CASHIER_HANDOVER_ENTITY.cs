using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CASHIER_HANDOVER_ENTITY : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid CASHIER_HANDOVERID { get; set; }
        public byte ENTITY_TYPE { get; set; }
        public double DEBT { get; set; }
        public string CURCODE { get; set; } = null!;

        public virtual CASHIER_HANDOVER CASHIER_HANDOVER { get; set; } = null!;
        public virtual CURCODE CURCODENavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

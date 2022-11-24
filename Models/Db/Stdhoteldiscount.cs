using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Stdhoteldiscount : EntityBase // My Handlebars Helper
    {
        public Stdhoteldiscount()
        {
            StdhotelRatecodeDiscount = new HashSet<StdhotelRatecodeDiscount>();
        }

        public byte Id { get; set; }
        public string? Definition { get; set; }

        public virtual ICollection<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Stdboardtypes : EntityBase // My Handlebars Helper
    {
        public Stdboardtypes()
        {
            StdhotelBoardtypes = new HashSet<StdhotelBoardtypes>();
        }

        public string Boardtype { get; set; } = null!;

        public virtual ICollection<StdhotelBoardtypes> StdhotelBoardtypes { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

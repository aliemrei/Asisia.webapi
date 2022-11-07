using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDROOMTYPES : EntityBase // My Handlebars Helper
    {
        public STDROOMTYPES()
        {
            STDHOTEL_ROOMTYPES = new HashSet<STDHOTEL_ROOMTYPES>();
        }

        public string ROOMTYPE { get; set; } = null!;
        public string? ENT_ROOMTYPE { get; set; }

        public virtual ICollection<STDHOTEL_ROOMTYPES> STDHOTEL_ROOMTYPES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

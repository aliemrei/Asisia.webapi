using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Stdroomtypes : EntityBase // My Handlebars Helper
    {
        public Stdroomtypes()
        {
            StdhotelRoomtypes = new HashSet<StdhotelRoomtypes>();
        }

        public string Roomtype { get; set; } = null!;
        public string? EntRoomtype { get; set; }

        public virtual ICollection<StdhotelRoomtypes> StdhotelRoomtypes { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

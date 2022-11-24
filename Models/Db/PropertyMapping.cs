using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PropertyMapping : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Providerid { get; set; }
        public Guid Hotelid { get; set; }
        public Guid? Roomid { get; set; }
        public Guid? Boardtypeid { get; set; }
        public Guid? Ratetypeid { get; set; }
        public string? Code { get; set; }

        public virtual StdhotelBoardtypes? Boardtype { get; set; }
        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual PropertyProviders Provider { get; set; } = null!;
        public virtual StdhotelRatetype? Ratetype { get; set; }
        public virtual StdhotelRoomtypes? Room { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

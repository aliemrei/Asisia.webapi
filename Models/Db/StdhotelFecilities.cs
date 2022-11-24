using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelFecilities : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? Hotelid { get; set; }
        public string? Definition { get; set; }
        public string? Category { get; set; }
        public bool? Isfree { get; set; }
        public string? Icon { get; set; }
        public string? Seasontype { get; set; }
        public string? Description { get; set; }
        public Guid? Roomtypeid { get; set; }

        public virtual Stdhotel? Hotel { get; set; }
        public virtual StdhotelRoomtypes? Roomtype { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

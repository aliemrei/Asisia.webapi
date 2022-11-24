using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelImages : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? Hotelid { get; set; }
        public string? Definition { get; set; }
        public bool? Default { get; set; }
        public int? Sortorder { get; set; }
        public string? Thumbnail { get; set; }
        public string? Url { get; set; }
        public Guid? Roomtypeid { get; set; }
        public bool? Showinofferform { get; set; }
        public string? Description { get; set; }
        public Guid Uid { get; set; }

        public virtual Stdhotel? Hotel { get; set; }
        public virtual StdhotelRoomtypes? Roomtype { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

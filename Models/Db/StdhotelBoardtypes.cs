using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelBoardtypes : EntityBase // My Handlebars Helper
    {
        public StdhotelBoardtypes()
        {
            PropertyMapping = new HashSet<PropertyMapping>();
            RequestDetail = new HashSet<RequestDetail>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
        }

        public Guid Id { get; set; }
        public string Boardtype { get; set; } = null!;
        public Guid Hotelid { get; set; }
        public string? Definition { get; set; }
        public string? EntId { get; set; }
        public string? EntEtsid { get; set; }
        public string? EntTouristicaid { get; set; }
        public string? EntTatilbudurid { get; set; }
        public string? EntIatiid { get; set; }
        public string? EntTravelclickid { get; set; }
        public string? EntJollytourid { get; set; }
        public string? EntSednaid { get; set; }
        public string? EntHotelrunnerid { get; set; }
        public string? EntSeturid { get; set; }

        public virtual Stdboardtypes BoardtypeNavigation { get; set; } = null!;
        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

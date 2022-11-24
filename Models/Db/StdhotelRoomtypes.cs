using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRoomtypes : EntityBase // My Handlebars Helper
    {
        public StdhotelRoomtypes()
        {
            PropertyMapping = new HashSet<PropertyMapping>();
            RequestDetail = new HashSet<RequestDetail>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
            StdhotelRatecodeDiscountRoomtype = new HashSet<StdhotelRatecodeDiscountRoomtype>();
            StdhotelRatecodeMarkupRoomtype = new HashSet<StdhotelRatecodeMarkupRoomtype>();
            StdhotelRoomtypesAvailability = new HashSet<StdhotelRoomtypesAvailability>();
        }

        public Guid Id { get; set; }
        public string Roomtype { get; set; } = null!;
        public int Roomcount { get; set; }
        public int? Maxbedcount { get; set; }
        public Guid Hotelid { get; set; }
        public string? Definition { get; set; }
        public string? EntId { get; set; }
        public int? Minbedcount { get; set; }
        public int? Minadultcount { get; set; }
        public int? Maxadultcount { get; set; }
        public int? Minchildcount { get; set; }
        public int? Maxchildcount { get; set; }
        public int? Minbabycount { get; set; }
        public int? Maxbabycount { get; set; }
        public string? Thumbnailimg { get; set; }
        public string? Description { get; set; }
        public string? EntEtsid { get; set; }
        public string? EntTouristicaid { get; set; }
        public string? EntTatilbudurid { get; set; }
        public string? EntIatiid { get; set; }
        public string? EntTravelclickid { get; set; }
        public string? EntJollytourid { get; set; }
        public string? EntSednaid { get; set; }
        public byte BabycountsIncToBeds { get; set; }
        public double? AdultRate { get; set; }
        public double? ChildRate { get; set; }
        public double? BabyRate { get; set; }
        public string? EntHotelrunnerid { get; set; }
        public string? EntSeturid { get; set; }
        public int? DisplayPersonCount { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid? Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Roomgroup { get; set; }

        public virtual Users? AdduserNavigation { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual Stdroomtypes RoomtypeNavigation { get; set; } = null!;
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscountRoomtype> StdhotelRatecodeDiscountRoomtype { get; set; }
        public virtual ICollection<StdhotelRatecodeMarkupRoomtype> StdhotelRatecodeMarkupRoomtype { get; set; }
        public virtual ICollection<StdhotelRoomtypesAvailability> StdhotelRoomtypesAvailability { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

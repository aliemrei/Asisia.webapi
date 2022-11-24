using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Stdhotel : EntityBase // My Handlebars Helper
    {
        public Stdhotel()
        {
            PortalCategoryItems = new HashSet<PortalCategoryItems>();
            ProjectGroupdetail = new HashSet<ProjectGroupdetail>();
            PromotionCodes = new HashSet<PromotionCodes>();
            PropertyMapping = new HashSet<PropertyMapping>();
            RequestDetail = new HashSet<RequestDetail>();
            ReservationSettings = new HashSet<ReservationSettings>();
            StdhotelAnnouncement = new HashSet<StdhotelAnnouncement>();
            StdhotelBoardtypes = new HashSet<StdhotelBoardtypes>();
            StdhotelDescriptions = new HashSet<StdhotelDescriptions>();
            StdhotelExtras = new HashSet<StdhotelExtras>();
            StdhotelMarket = new HashSet<StdhotelMarket>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
            StdhotelRatecode = new HashSet<StdhotelRatecode>();
            StdhotelRatecodeDiscount = new HashSet<StdhotelRatecodeDiscount>();
            StdhotelRatetype = new HashSet<StdhotelRatetype>();
            StdhotelRoomtypes = new HashSet<StdhotelRoomtypes>();
            TourProgram = new HashSet<TourProgram>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Name { get; set; } = null!;
        public Guid? Addressid { get; set; }
        public long? Tel1 { get; set; }
        public long? Tel2 { get; set; }
        public string? Email { get; set; }
        public long? Fax { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Contact { get; set; }
        public string? Webaddress { get; set; }
        public string? Homepageurl { get; set; }
        public string? Templatename { get; set; }
        public string? Thumbnailurl { get; set; }
        public string? HotelDescription { get; set; }
        public string? RakamId { get; set; }
        public DateTime? Checkintime { get; set; }
        public DateTime? Checkouttime { get; set; }
        public string? Tripadvisorid { get; set; }
        public string? UrlBlogger { get; set; }
        public string? UrlFlicker { get; set; }
        public string? UrlFoursquare { get; set; }
        public string? UrlGoogleplus { get; set; }
        public string? UrlInstagram { get; set; }
        public string? UrlVine { get; set; }
        public string? UrlFacebook { get; set; }
        public string? Factsheeturl { get; set; }
        public double? Stars { get; set; }
        public string? Factsheeturl2 { get; set; }
        public int Thumbnailmaxwidth { get; set; }
        public int? Seturid { get; set; }

        public virtual LocationAddress? Address { get; set; }
        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<PortalCategoryItems> PortalCategoryItems { get; set; }
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<ReservationSettings> ReservationSettings { get; set; }
        public virtual ICollection<StdhotelAnnouncement> StdhotelAnnouncement { get; set; }
        public virtual ICollection<StdhotelBoardtypes> StdhotelBoardtypes { get; set; }
        public virtual ICollection<StdhotelDescriptions> StdhotelDescriptions { get; set; }
        public virtual ICollection<StdhotelExtras> StdhotelExtras { get; set; }
        public virtual ICollection<StdhotelMarket> StdhotelMarket { get; set; }
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        public virtual ICollection<StdhotelRatecode> StdhotelRatecode { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; }
        public virtual ICollection<StdhotelRatetype> StdhotelRatetype { get; set; }
        public virtual ICollection<StdhotelRoomtypes> StdhotelRoomtypes { get; set; }
        public virtual ICollection<TourProgram> TourProgram { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

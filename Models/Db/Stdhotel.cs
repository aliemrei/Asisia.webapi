using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL")]
    [Index(nameof(Seturid), Name = "IX_STDHOTEL")]
    [Index(nameof(Isdeleted), nameof(Isdisabled), Name = "IX_STDHOTEL_1")]
    [Index(nameof(Name), Name = "IX_STDHOTEL_2")]
    [Index(nameof(Name), Name = "IX_STDHOTEL_3")]
    [Index(nameof(Adddate), Name = "IX_STDHOTEL_4")]
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

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("NAME")]
        [StringLength(70)]
        public string Name { get; set; } = null!;
        [Column("ADDRESSID")]
        public Guid? Addressid { get; set; }
        [Column("TEL1")]
        public long? Tel1 { get; set; }
        [Column("TEL2")]
        public long? Tel2 { get; set; }
        [Column("EMAIL")]
        [StringLength(200)]
        public string? Email { get; set; }
        [Column("FAX")]
        public long? Fax { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("CONTACT")]
        [StringLength(200)]
        public string? Contact { get; set; }
        [Column("WEBADDRESS")]
        [StringLength(250)]
        public string? Webaddress { get; set; }
        [Column("HOMEPAGEURL")]
        [StringLength(350)]
        public string? Homepageurl { get; set; }
        [Column("TEMPLATENAME")]
        [StringLength(50)]
        public string? Templatename { get; set; }
        [Column("THUMBNAILURL")]
        [StringLength(350)]
        public string? Thumbnailurl { get; set; }
        [Column("HOTEL_DESCRIPTION")]
        public string? HotelDescription { get; set; }
        [Column("RAKAM_ID")]
        [StringLength(15)]
        public string? RakamId { get; set; }
        [Column("CHECKINTIME", TypeName = "datetime")]
        public DateTime? Checkintime { get; set; }
        [Column("CHECKOUTTIME", TypeName = "datetime")]
        public DateTime? Checkouttime { get; set; }
        [Column("TRIPADVISORID")]
        [StringLength(50)]
        public string? Tripadvisorid { get; set; }
        [Column("URL_BLOGGER")]
        [StringLength(250)]
        public string? UrlBlogger { get; set; }
        [Column("URL_FLICKER")]
        [StringLength(250)]
        public string? UrlFlicker { get; set; }
        [Column("URL_FOURSQUARE")]
        [StringLength(250)]
        public string? UrlFoursquare { get; set; }
        [Column("URL_GOOGLEPLUS")]
        [StringLength(250)]
        public string? UrlGoogleplus { get; set; }
        [Column("URL_INSTAGRAM")]
        [StringLength(250)]
        public string? UrlInstagram { get; set; }
        [Column("URL_VINE")]
        [StringLength(250)]
        public string? UrlVine { get; set; }
        [Column("URL_FACEBOOK")]
        [StringLength(250)]
        public string? UrlFacebook { get; set; }
        [Column("FACTSHEETURL")]
        [StringLength(250)]
        public string? Factsheeturl { get; set; }
        [Column("STARS")]
        public double? Stars { get; set; }
        [Column("FACTSHEETURL2")]
        [StringLength(250)]
        public string? Factsheeturl2 { get; set; }
        [Column("THUMBNAILMAXWIDTH")]
        public int Thumbnailmaxwidth { get; set; }
        [Column("SETURID")]
        public int? Seturid { get; set; }

        [ForeignKey(nameof(Addressid))]
        [InverseProperty(nameof(LocationAddress.Stdhotel))]
        public virtual LocationAddress? Address { get; set; }
        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdhotelAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Stdhotel")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdhotelEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<PortalCategoryItems> PortalCategoryItems { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<ReservationSettings> ReservationSettings { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelAnnouncement> StdhotelAnnouncement { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelBoardtypes> StdhotelBoardtypes { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelDescriptions> StdhotelDescriptions { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelExtras> StdhotelExtras { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelMarket> StdhotelMarket { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelRatecode> StdhotelRatecode { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelRatetype> StdhotelRatetype { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<StdhotelRoomtypes> StdhotelRoomtypes { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<TourProgram> TourProgram { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

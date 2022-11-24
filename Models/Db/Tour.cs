using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Tour : EntityBase // My Handlebars Helper
    {
        public Tour()
        {
            PortalCategoryItems = new HashSet<PortalCategoryItems>();
            ProjectGroupdetail = new HashSet<ProjectGroupdetail>();
            PromotionCodes = new HashSet<PromotionCodes>();
            RequestDetail = new HashSet<RequestDetail>();
            ReservationSettings = new HashSet<ReservationSettings>();
            TourDiscounts = new HashSet<TourDiscounts>();
            TourPrices = new HashSet<TourPrices>();
            TourProgram = new HashSet<TourProgram>();
        }

        public Guid Id { get; set; }
        public int Intid { get; set; }
        public Guid Corpid { get; set; }
        public string Description { get; set; } = null!;
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public int Adultcapacity { get; set; }
        public int Childcapacity { get; set; }
        public int Babycapacity { get; set; }
        public int TotalDays { get; set; }
        public string? Boardtype { get; set; }
        public string? TripLocations { get; set; }
        public short? BabyMaxage { get; set; }
        public short? ChdyMaxage { get; set; }
        public short? ChdeMaxage { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<PortalCategoryItems> PortalCategoryItems { get; set; }
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<ReservationSettings> ReservationSettings { get; set; }
        public virtual ICollection<TourDiscounts> TourDiscounts { get; set; }
        public virtual ICollection<TourPrices> TourPrices { get; set; }
        public virtual ICollection<TourProgram> TourProgram { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

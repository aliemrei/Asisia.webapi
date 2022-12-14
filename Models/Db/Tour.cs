using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TOUR")]
    public partial class Tour : EntityBase 
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

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("INTID")]
        [RequiredIf]
        public int Intid { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(70)]
        [RequiredIf]
        public string Description { get; set; } = null!;


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("ADULTCAPACITY")]
        [RequiredIf]
        public int Adultcapacity { get; set; }


        [Column("CHILDCAPACITY")]
        [RequiredIf]
        public int Childcapacity { get; set; }


        [Column("BABYCAPACITY")]
        [RequiredIf]
        public int Babycapacity { get; set; }


        [Column("TOTAL_DAYS")]
        [RequiredIf]
        public int TotalDays { get; set; }


        [Column("BOARDTYPE")]
        [StringLength(100)]
        
        public string? Boardtype { get; set; }


        [Column("TRIP_LOCATIONS")]
        
        public string? TripLocations { get; set; }


        [Column("BABY_MAXAGE")]
        
        public short? BabyMaxage { get; set; }


        [Column("CHDY_MAXAGE")]
        
        public short? ChdyMaxage { get; set; }


        [Column("CHDE_MAXAGE")]
        
        public short? ChdeMaxage { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.TourAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Tour")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TourEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Tour")]
        public virtual ICollection<PortalCategoryItems> PortalCategoryItems { get; set; }
        [InverseProperty("Tour")]
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        [InverseProperty("Tour")]
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        [InverseProperty("Tour")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Tour")]
        public virtual ICollection<ReservationSettings> ReservationSettings { get; set; }
        [InverseProperty("Tour")]
        public virtual ICollection<TourDiscounts> TourDiscounts { get; set; }
        [InverseProperty("Tour")]
        public virtual ICollection<TourPrices> TourPrices { get; set; }
        [InverseProperty("Tour")]
        public virtual ICollection<TourProgram> TourProgram { get; set; }

            }
}

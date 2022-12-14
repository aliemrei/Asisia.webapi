using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("RESERVATION_SETTINGS")]
    [Index(nameof(Startdate), nameof(Finishdate), Name = "IX_RESERVATION_SETTINGS")]
    public partial class ReservationSettings : EntityBase 
    {
        public ReservationSettings()
        {
            RequestDetail = new HashSet<RequestDetail>();
            ReservationSettingsMarket = new HashSet<ReservationSettingsMarket>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("HOTELID")]
        
        public Guid? Hotelid { get; set; }


        [Column("TOURID")]
        
        public Guid? Tourid { get; set; }


        [Column("TICKETID")]
        
        public Guid? Ticketid { get; set; }


        [Column("STARTDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Startdate { get; set; }


        [Column("FINISHDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Finishdate { get; set; }


        [Column("CANCELATION_RATE")]
        [RequiredIf]
        public double CancelationRate { get; set; }


        [Column("CANCELATION_DAYS")]
        [RequiredIf]
        public int CancelationDays { get; set; }


        [Column("CANCELATION_DESCRIPTION")]
        
        public string? CancelationDescription { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("PAYMENT_RATE")]
        
        public double? PaymentRate { get; set; }


        [Column("CANCELLATION_WARRANTY_RATE")]
        
        public double? CancellationWarrantyRate { get; set; }


        [Column("MEN_ACCOMMODATION_FORBIDDEN")]
        
        public bool? MenAccommodationForbidden { get; set; }


        [Column("CHILDREN_ACCOMMODATION_FORBIDDEN")]
        
        public bool? ChildrenAccommodationForbidden { get; set; }


        [Column("CHILDREN_MAXAGE")]
        
        public int? ChildrenMaxage { get; set; }


        [Column("PAYMENT_RATE_MAX_DAY")]
        
        public int? PaymentRateMaxDay { get; set; }


        [Column("CANCELLATION_WARRANTY_RATE_MAX_DAY")]
        
        public int? CancellationWarrantyRateMaxDay { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.ReservationSettings))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.ReservationSettings))]
        public virtual Stdhotel? Hotel { get; set; }
        [ForeignKey(nameof(Ticketid))]
        [InverseProperty("ReservationSettings")]
        public virtual Ticket? Ticket { get; set; }
        [ForeignKey(nameof(Tourid))]
        [InverseProperty("ReservationSettings")]
        public virtual Tour? Tour { get; set; }
        [InverseProperty("ReservationSettings")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Settings")]
        public virtual ICollection<ReservationSettingsMarket> ReservationSettingsMarket { get; set; }

            }
}

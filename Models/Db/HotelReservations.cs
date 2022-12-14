using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("HOTEL_RESERVATIONS")]
    [Index(nameof(Resid), Name = "UQ__HOTEL_RE__4D969333596EF86E", IsUnique = true)]
    public partial class HotelReservations : EntityBase 
    {
        public HotelReservations()
        {
            HotelReservationDetails = new HashSet<HotelReservationDetails>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("RESID")]
        [RequiredIf]
        public int Resid { get; set; }


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


        [Column("REQUEST_DETAILID")]
        
        public Guid? RequestDetailid { get; set; }


        [Column("CONTRACT_DATE", TypeName = "datetime")]
        
        public DateTime? ContractDate { get; set; }


        [Column("LASTUPDATE_RESDETAIL", TypeName = "datetime")]
        
        public DateTime? LastupdateResdetail { get; set; }


        [Column("ISCONFIRMED_HOTEL")]
        [RequiredIf]
        public bool IsconfirmedHotel { get; set; }


        [Column("ISCONFIRMED_GUEST")]
        [RequiredIf]
        public bool IsconfirmedGuest { get; set; }


        [Column("ISCONFIRMED_OWNER")]
        [RequiredIf]
        public bool IsconfirmedOwner { get; set; }


        [Column("ENTID")]
        [StringLength(40)]
        
        public string? Entid { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.HotelReservationsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.HotelReservationsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("HotelReservations")]
        public virtual RequestDetail? RequestDetail { get; set; }
        [InverseProperty("Res")]
        public virtual ICollection<HotelReservationDetails> HotelReservationDetails { get; set; }

            }
}

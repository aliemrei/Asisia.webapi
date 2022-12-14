using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TICKET")]
    public partial class Ticket : EntityBase 
    {
        public Ticket()
        {
            PortalCategoryItems = new HashSet<PortalCategoryItems>();
            ProjectGroupdetail = new HashSet<ProjectGroupdetail>();
            PromotionCodes = new HashSet<PromotionCodes>();
            RequestDetail = new HashSet<RequestDetail>();
            ReservationSettings = new HashSet<ReservationSettings>();
            TicketHours = new HashSet<TicketHours>();
            TicketPrices = new HashSet<TicketPrices>();
            TileItemoption = new HashSet<TileItemoption>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("DEFINITION")]
        [StringLength(200)]
        
        public string? Definition { get; set; }


        [Column("TICKETTYPE")]
        [RequiredIf]
        public byte Tickettype { get; set; }


        [Column("ENDOFMINUTE")]
        
        public byte? Endofminute { get; set; }


        [Column("MAXSELLDATE")]
        [RequiredIf]
        public int Maxselldate { get; set; }


        [Column("ADULTMANDATORY")]
        [RequiredIf]
        public int Adultmandatory { get; set; }


        [Column("CHILDMANDATORY")]
        [RequiredIf]
        public int Childmandatory { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


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


        [Column("PLU")]
        [StringLength(10)]
        
        public string? Plu { get; set; }


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("SORTORDER")]
        [RequiredIf]
        public int Sortorder { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.TicketAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Ticket")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TicketEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Ticket")]
        public virtual ICollection<PortalCategoryItems> PortalCategoryItems { get; set; }
        [InverseProperty("Ticket")]
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        [InverseProperty("Ticket")]
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        [InverseProperty("Ticket")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Ticket")]
        public virtual ICollection<ReservationSettings> ReservationSettings { get; set; }
        [InverseProperty("Ticket")]
        public virtual ICollection<TicketHours> TicketHours { get; set; }
        [InverseProperty("Ticket")]
        public virtual ICollection<TicketPrices> TicketPrices { get; set; }
        [InverseProperty("Ticket")]
        public virtual ICollection<TileItemoption> TileItemoption { get; set; }

            }
}

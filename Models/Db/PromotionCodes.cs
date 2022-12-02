using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROMOTION_CODES")]
    public partial class PromotionCodes : EntityBase // My Handlebars Helper
    {
        public PromotionCodes()
        {
            PromotionCodesMarket = new HashSet<PromotionCodesMarket>();
            RequestDetail = new HashSet<RequestDetail>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("KIND")]
        public short Kind { get; set; }
        [Column("TYPE")]
        public short Type { get; set; }
        [Column("EMAIL")]
        [StringLength(250)]
        public string? Email { get; set; }
        [Column("DEFINITION")]
        [StringLength(150)]
        public string Definition { get; set; } = null!;
        [Column("CODE")]
        [StringLength(255)]
        public string Code { get; set; } = null!;
        [Column("USETYPE")]
        public short Usetype { get; set; }
        [Column("USECOUNT")]
        public int Usecount { get; set; }
        [Column("DISCOUNTTYPE")]
        public short Discounttype { get; set; }
        [Column("DISCOUNTKIND")]
        public short Discountkind { get; set; }
        [Column("DISCOUNT")]
        public double Discount { get; set; }
        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string? Curcode { get; set; }
        [Column("SELLFROM", TypeName = "datetime")]
        public DateTime? Sellfrom { get; set; }
        [Column("SELLTO", TypeName = "datetime")]
        public DateTime? Sellto { get; set; }
        [Column("STAYFROM", TypeName = "datetime")]
        public DateTime? Stayfrom { get; set; }
        [Column("STAYTO", TypeName = "datetime")]
        public DateTime? Stayto { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("HOTELID")]
        public Guid? Hotelid { get; set; }
        [Column("TOURID")]
        public Guid? Tourid { get; set; }
        [Column("TICKETID")]
        public Guid? Ticketid { get; set; }
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

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PromotionCodesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("PromotionCodes")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("PromotionCodes")]
        public virtual Curcode? CurcodeNavigation { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PromotionCodesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.PromotionCodes))]
        public virtual Stdhotel? Hotel { get; set; }
        [ForeignKey(nameof(Ticketid))]
        [InverseProperty("PromotionCodes")]
        public virtual Ticket? Ticket { get; set; }
        [ForeignKey(nameof(Tourid))]
        [InverseProperty("PromotionCodes")]
        public virtual Tour? Tour { get; set; }
        [InverseProperty("Promotion")]
        public virtual ICollection<PromotionCodesMarket> PromotionCodesMarket { get; set; }
        [InverseProperty("Promotion")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

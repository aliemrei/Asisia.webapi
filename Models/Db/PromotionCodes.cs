using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROMOTION_CODES")]
    public partial class PromotionCodes : EntityBase 
    {
        public PromotionCodes()
        {
            PromotionCodesMarket = new HashSet<PromotionCodesMarket>();
            RequestDetail = new HashSet<RequestDetail>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("KIND")]
        [RequiredIf]
        public short Kind { get; set; }


        [Column("TYPE")]
        [RequiredIf]
        public short Type { get; set; }


        [Column("EMAIL")]
        [StringLength(250)]
        
        public string? Email { get; set; }


        [Column("DEFINITION")]
        [StringLength(150)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("CODE")]
        [StringLength(255)]
        [RequiredIf]
        public string Code { get; set; } = null!;


        [Column("USETYPE")]
        [RequiredIf]
        public short Usetype { get; set; }


        [Column("USECOUNT")]
        [RequiredIf]
        public int Usecount { get; set; }


        [Column("DISCOUNTTYPE")]
        [RequiredIf]
        public short Discounttype { get; set; }


        [Column("DISCOUNTKIND")]
        [RequiredIf]
        public short Discountkind { get; set; }


        [Column("DISCOUNT")]
        [RequiredIf]
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

            }
}

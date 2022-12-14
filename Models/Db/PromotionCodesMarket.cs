using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROMOTION_CODES_MARKET")]
    [Index(nameof(Promotionid), nameof(Marketid), Name = "UQ__PROMOTION_CODES_MARKET__4B96FBB176D8588E", IsUnique = true)]
    public partial class PromotionCodesMarket : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("PROMOTIONID")]
        [RequiredIf]
        public Guid Promotionid { get; set; }


        [Column("MARKETID")]
        [RequiredIf]
        public Guid Marketid { get; set; }



        [ForeignKey(nameof(Marketid))]
        [InverseProperty(nameof(Stdmarkets.PromotionCodesMarket))]
        public virtual Stdmarkets Market { get; set; } = null!;
        [ForeignKey(nameof(Promotionid))]
        [InverseProperty(nameof(PromotionCodes.PromotionCodesMarket))]
        public virtual PromotionCodes Promotion { get; set; } = null!;

            }
}

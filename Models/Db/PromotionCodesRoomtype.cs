using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("PROMOTION_CODES_ROOMTYPE")]
    [Index(nameof(Promotionid), nameof(Roomtype), Name = "UQ__PROMOTIO__C1C5A5FA64991A60", IsUnique = true)]
    public partial class PromotionCodesRoomtype : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("PROMOTIONID")]
        [RequiredIf]
        public Guid Promotionid { get; set; }


        [Column("ROOMTYPE")]
        [StringLength(6)]
        [RequiredIf]
        public string Roomtype { get; set; } = null!;



        [ForeignKey(nameof(Promotionid))]
        public virtual PromotionCodes Promotion { get; set; } = null!;
        [ForeignKey(nameof(Roomtype))]
        public virtual Stdroomtypes RoomtypeNavigation { get; set; } = null!;

            }
}

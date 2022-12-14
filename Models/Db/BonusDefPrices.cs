using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("BONUS_DEF_PRICES")]
    public partial class BonusDefPrices : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("BONUS_DEF_ITEMSID")]
        [RequiredIf]
        public Guid BonusDefItemsid { get; set; }


        [Column("FIRST_AMOUNT")]
        [RequiredIf]
        public double FirstAmount { get; set; }


        [Column("LAST_AMOUNT")]
        [RequiredIf]
        public double LastAmount { get; set; }


        [Column("RATE")]
        [RequiredIf]
        public double Rate { get; set; }


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



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.BonusDefPricesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(BonusDefItemsid))]
        [InverseProperty("BonusDefPrices")]
        public virtual BonusDefItems BonusDefItems { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.BonusDefPricesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }

            }
}

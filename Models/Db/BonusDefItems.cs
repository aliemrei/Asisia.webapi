using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("BONUS_DEF_ITEMS")]
    public partial class BonusDefItems : EntityBase // My Handlebars Helper
    {
        public BonusDefItems()
        {
            BonusDefPrices = new HashSet<BonusDefPrices>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("BONUS_DEFID")]
        public Guid BonusDefid { get; set; }
        [Column("PRODUCTID")]
        public Guid Productid { get; set; }
        [Column("PROPERTYID")]
        public Guid? Propertyid { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid? Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.BonusDefItemsAdduserNavigation))]
        public virtual Users? AdduserNavigation { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.BonusDefItemsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("BonusDefItems")]
        public virtual ICollection<BonusDefPrices> BonusDefPrices { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

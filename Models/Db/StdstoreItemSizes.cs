using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEM_SIZES")]
    [Index(nameof(StoreItemid), nameof(Definition), Name = "UQ__STDSTORE__92B9D130B75A427A", IsUnique = true)]
    public partial class StdstoreItemSizes : EntityBase 
    {
        public StdstoreItemSizes()
        {
            StdstoreItemImages = new HashSet<StdstoreItemImages>();
            StdstoreItemIngredients = new HashSet<StdstoreItemIngredients>();
            StdstoreItemPrices = new HashSet<StdstoreItemPrices>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("STORE_ITEMID")]
        [RequiredIf]
        public Guid StoreItemid { get; set; }


        [Column("DEFINITION")]
        [StringLength(200)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


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



        [InverseProperty("StoreItemSizes")]
        public virtual ICollection<StdstoreItemImages> StdstoreItemImages { get; set; }
        [InverseProperty("StoreItemSizes")]
        public virtual ICollection<StdstoreItemIngredients> StdstoreItemIngredients { get; set; }
        [InverseProperty("StoreItemSizes")]
        public virtual ICollection<StdstoreItemPrices> StdstoreItemPrices { get; set; }

            }
}

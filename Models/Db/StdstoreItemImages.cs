using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEM_IMAGES")]
    public partial class StdstoreItemImages : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("STORE_ITEMID")]
        
        public Guid? StoreItemid { get; set; }


        [Column("DEFINITION")]
        [StringLength(100)]
        
        public string? Definition { get; set; }


        [Column("DEFAULT")]
        
        public bool? Default { get; set; }


        [Column("SORTORDER")]
        
        public int? Sortorder { get; set; }


        [Column("THUMBNAIL")]
        [StringLength(250)]
        
        public string? Thumbnail { get; set; }


        [Column("URL")]
        [StringLength(250)]
        
        public string? Url { get; set; }


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("UID")]
        [RequiredIf]
        public Guid Uid { get; set; }


        [Column("STORE_ITEM_SIZESID")]
        [RequiredIf]
        public Guid StoreItemSizesid { get; set; }



        [ForeignKey(nameof(StoreItemid))]
        [InverseProperty(nameof(StdstoreItems.StdstoreItemImages))]
        public virtual StdstoreItems? StoreItem { get; set; }
        [ForeignKey(nameof(StoreItemSizesid))]
        [InverseProperty(nameof(StdstoreItemSizes.StdstoreItemImages))]
        public virtual StdstoreItemSizes StoreItemSizes { get; set; } = null!;

            }
}

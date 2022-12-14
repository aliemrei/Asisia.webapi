using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TRANSFER_PROVIDERS")]
    public partial class TransferProviders : EntityBase 
    {
        public TransferProviders()
        {
            TransferPrices = new HashSet<TransferPrices>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(170)]
        [RequiredIf]
        public string Description { get; set; } = null!;


        [Column("TEL1")]
        
        public long? Tel1 { get; set; }


        [Column("TEL2")]
        
        public long? Tel2 { get; set; }


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
        [InverseProperty(nameof(Users.TransferProvidersAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("TransferProviders")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TransferProvidersEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Provider")]
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }

            }
}

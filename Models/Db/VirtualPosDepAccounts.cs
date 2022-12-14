using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_DEP_ACCOUNTS")]
    [Index(nameof(Iban), Name = "UQ__VIRTUAL___8235CCBCC71928CD", IsUnique = true)]
    [Index(nameof(Posid), nameof(BrandCode), nameof(AccountNo), Name = "UQ__VIRTUAL___FB82C868314D95A7", IsUnique = true)]
    public partial class VirtualPosDepAccounts : EntityBase 
    {
        public VirtualPosDepAccounts()
        {
            ProjectGroupdetailBankdep = new HashSet<ProjectGroupdetailBankdep>();
            VirtualPosDepPayments = new HashSet<VirtualPosDepPayments>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("POSID")]
        [RequiredIf]
        public Guid Posid { get; set; }


        [Column("DEFINITION")]
        [StringLength(100)]
        
        public string? Definition { get; set; }


        [Column("BRAND_CODE")]
        [StringLength(25)]
        
        public string? BrandCode { get; set; }


        [Column("ACCOUNT_NO")]
        [StringLength(35)]
        
        public string? AccountNo { get; set; }


        [Column("IBAN")]
        [StringLength(35)]
        
        public string? Iban { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        [RequiredIf]
        public string Curcode { get; set; } = null!;


        [Column("FIRMNAME")]
        [StringLength(250)]
        
        public string? Firmname { get; set; }


        [Column("SWIFTCODE")]
        [StringLength(50)]
        
        public string? Swiftcode { get; set; }


        [Column("ENTID")]
        [StringLength(100)]
        
        public string? Entid { get; set; }



        [InverseProperty("Depaccount")]
        public virtual ICollection<ProjectGroupdetailBankdep> ProjectGroupdetailBankdep { get; set; }
        [InverseProperty("Posaccount")]
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPayments { get; set; }

            }
}

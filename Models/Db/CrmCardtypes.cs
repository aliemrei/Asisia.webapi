using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CRM_CARDTYPES")]
    public partial class CrmCardtypes : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CARDGROUPID")]
        [RequiredIf]
        public Guid Cardgroupid { get; set; }


        [Column("DEFINITION")]
        [StringLength(100)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("TITLE")]
        [StringLength(100)]
        
        public string? Title { get; set; }


        [Column("CARDUSE_RULES")]
        
        public string? CarduseRules { get; set; }


        [Column("CARDBRANDICONURL")]
        [StringLength(250)]
        
        public string? Cardbrandiconurl { get; set; }


        [Required]
        [Column("SHOWWIFI_ICON")]
        
        public bool? ShowwifiIcon { get; set; }


        [Required]
        [Column("SHOWCHIP_ICON")]
        
        public bool? ShowchipIcon { get; set; }


        [Required]
        [Column("SHOWCARD_BRAND")]
        
        public bool? ShowcardBrand { get; set; }


        [Column("COLORGROUP1")]
        [StringLength(20)]
        [RequiredIf]
        public string Colorgroup1 { get; set; } = null!;


        [Column("COLORGROUP2")]
        [StringLength(20)]
        [RequiredIf]
        public string Colorgroup2 { get; set; } = null!;


        [Column("COLORGROUP3")]
        [StringLength(20)]
        [RequiredIf]
        public string Colorgroup3 { get; set; } = null!;


        [Column("COLORGROUP4")]
        [StringLength(20)]
        [RequiredIf]
        public string Colorgroup4 { get; set; } = null!;


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


        [Column("BACKCOLOR1")]
        [StringLength(20)]
        [RequiredIf]
        public string Backcolor1 { get; set; } = null!;


        [Column("BACKCOLOR2")]
        [StringLength(20)]
        [RequiredIf]
        public string Backcolor2 { get; set; } = null!;


        [Column("CARDBRANDLOGO")]
        
        public string? Cardbrandlogo { get; set; }


        [Column("BACKGROUNDLOGO")]
        [StringLength(255)]
        
        public string? Backgroundlogo { get; set; }


        [Required]
        [Column("SHOWNUMBERS")]
        
        public bool? Shownumbers { get; set; }


        [Required]
        [Column("SHOWEXPIRE")]
        
        public bool? Showexpire { get; set; }


        [Required]
        [Column("SHOWCARDHOLDERNAME")]
        
        public bool? Showcardholdername { get; set; }


        [Required]
        [Column("SHOW_STRIPBOTTOM")]
        
        public bool? ShowStripbottom { get; set; }


        [Required]
        [Column("SHOW_STRIPTOP")]
        
        public bool? ShowStriptop { get; set; }


        [Column("CARDNUMBER_MARGIN")]
        [StringLength(50)]
        [RequiredIf]
        public string CardnumberMargin { get; set; } = null!;



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.CrmCardtypesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Cardgroupid))]
        [InverseProperty(nameof(CrmCardgroups.CrmCardtypes))]
        public virtual CrmCardgroups Cardgroup { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.CrmCardtypesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }

            }
}

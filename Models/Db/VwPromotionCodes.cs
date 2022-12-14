using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwPromotionCodes : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("KIND")]
        [StringLength(14)]
        [Unicode(false)]
        
        public string? Kind { get; set; }


        [Column("DEFINITION")]
        [StringLength(150)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("CODE")]
        [StringLength(255)]
        [RequiredIf]
        public string Code { get; set; } = null!;


        [Column("USETYPE")]
        [StringLength(11)]
        [Unicode(false)]
        
        public string? Usetype { get; set; }


        [Column("DISCOUNTTYPE")]
        [StringLength(15)]
        [Unicode(false)]
        
        public string? Discounttype { get; set; }


        [Column("DISCOUNTKIND")]
        [StringLength(16)]
        [Unicode(false)]
        
        public string? Discountkind { get; set; }


        [Column("SELLFROM", TypeName = "datetime")]
        
        public DateTime? Sellfrom { get; set; }


        [Column("SELLTO", TypeName = "datetime")]
        
        public DateTime? Sellto { get; set; }


        [Column("STAYFROM", TypeName = "datetime")]
        
        public DateTime? Stayfrom { get; set; }


        [Column("STAYTO", TypeName = "datetime")]
        
        public DateTime? Stayto { get; set; }


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


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }



            }
}

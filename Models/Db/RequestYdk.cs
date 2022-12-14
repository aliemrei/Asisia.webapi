using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("REQUEST_YDK")]
    public partial class RequestYdk : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PERSONID")]
        
        public Guid? Personid { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("RESOURCEID")]
        [RequiredIf]
        public Guid Resourceid { get; set; }


        [Column("PROJECT_DETAILID")]
        
        public Guid? ProjectDetailid { get; set; }


        [Column("REQ_URL")]
        [StringLength(500)]
        
        public string? ReqUrl { get; set; }


        [Column("CAMPAIGNCODE")]
        [StringLength(100)]
        
        public string? Campaigncode { get; set; }


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


        [Column("CREATIONDATE", TypeName = "date")]
        
        public DateTime? Creationdate { get; set; }


        [Column("CREATIONTIME")]
        
        public TimeSpan? Creationtime { get; set; }


        [Column("PROJECT_GROUPID")]
        [RequiredIf]
        public Guid ProjectGroupid { get; set; }


        [Column("STATUS")]
        
        public Guid? Status { get; set; }


        [Column("SUBSTATUS")]
        
        public Guid? Substatus { get; set; }


        [Column("RAKAM_ID")]
        [StringLength(15)]
        
        public string? RakamId { get; set; }


        [Column("PERSON_CCARDID")]
        
        public int? PersonCcardid { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


        [Column("POSACCOUNTID")]
        
        public Guid? Posaccountid { get; set; }


        [Column("POSINSTALMENTID")]
        
        public Guid? Posinstalmentid { get; set; }


        [Column("ISCALLTRANSFER")]
        [RequiredIf]
        public bool Iscalltransfer { get; set; }


        [Column("ORG")]
        
        public bool? Org { get; set; }


        [Column("SELLER_USERID")]
        
        public Guid? SellerUserid { get; set; }


        [Column("SELL_DATE", TypeName = "datetime")]
        
        public DateTime? SellDate { get; set; }


        [Column("RESNO")]
        [StringLength(200)]
        
        public string? Resno { get; set; }


        [Column("SELLINGDATE", TypeName = "date")]
        
        public DateTime? Sellingdate { get; set; }


        [Column("SELLINGTIME")]
        
        public TimeSpan? Sellingtime { get; set; }


        [Column("DIRECT_BRANDING")]
        [StringLength(15)]
        
        public string? DirectBranding { get; set; }



            }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PAYMENT_EMAILS")]
    public partial class PaymentEmails : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        
        public Guid? Corpid { get; set; }


        [Column("PROJECTID")]
        
        public Guid? Projectid { get; set; }


        [Column("TO_EMAILS")]
        [StringLength(500)]
        
        public string? ToEmails { get; set; }


        [Column("CC_EMAILS")]
        [StringLength(500)]
        
        public string? CcEmails { get; set; }


        [Column("BCC_EMAILS")]
        [StringLength(500)]
        
        public string? BccEmails { get; set; }


        [Column("HOTELID")]
        
        public Guid? Hotelid { get; set; }


        [Column("PROJECT_DETAILID")]
        
        public Guid? ProjectDetailid { get; set; }


        [Column("SUCCESS_TEXT")]
        
        public string? SuccessText { get; set; }


        [Column("FAIL_TEXT")]
        
        public string? FailText { get; set; }



        [ForeignKey(nameof(Corpid))]
        [InverseProperty("PaymentEmails")]
        public virtual Corp? Corp { get; set; }
        [ForeignKey(nameof(Projectid))]
        [InverseProperty(nameof(ProjectGroup.PaymentEmails))]
        public virtual ProjectGroup? Project { get; set; }
        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.PaymentEmails))]
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }

            }
}

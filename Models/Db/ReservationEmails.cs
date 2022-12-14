using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("RESERVATION_EMAILS")]
    public partial class ReservationEmails : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        
        public Guid? Corpid { get; set; }


        [Column("PROJECT_DETAILID")]
        
        public Guid? ProjectDetailid { get; set; }


        [Column("PRODUCTID")]
        
        public Guid? Productid { get; set; }


        [Column("TO_EMAILS")]
        [StringLength(500)]
        
        public string? ToEmails { get; set; }


        [Column("CC_EMAILS")]
        [StringLength(500)]
        
        public string? CcEmails { get; set; }


        [Column("BCC_EMAILS")]
        [StringLength(500)]
        
        public string? BccEmails { get; set; }



        [ForeignKey(nameof(Corpid))]
        [InverseProperty("ReservationEmails")]
        public virtual Corp? Corp { get; set; }
        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.ReservationEmails))]
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }

            }
}

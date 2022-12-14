using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_EMAILS")]
    public partial class PortalEmails : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PORTALUID")]
        [RequiredIf]
        public Guid Portaluid { get; set; }


        [Column("TO_EMAILS")]
        [StringLength(500)]
        
        public string? ToEmails { get; set; }


        [Column("CC_EMAILS")]
        [StringLength(500)]
        
        public string? CcEmails { get; set; }


        [Column("BCC_EMAILS")]
        [StringLength(500)]
        
        public string? BccEmails { get; set; }



        public virtual Portal Portalu { get; set; } = null!;

            }
}

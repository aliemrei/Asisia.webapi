using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_URLREWRITE")]
    public partial class PortalUrlrewrite : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("LINK")]
        [RequiredIf]
        public string Link { get; set; } = null!;


        [Column("VALIDDATE", TypeName = "datetime")]
        
        public DateTime? Validdate { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }



            }
}

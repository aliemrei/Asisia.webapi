using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_LANGUAGES")]
    public partial class PortalLanguages : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("PORTALUID")]
        [RequiredIf]
        public Guid Portaluid { get; set; }


        [Column("LANGCODE")]
        [StringLength(5)]
        [RequiredIf]
        public string Langcode { get; set; } = null!;



        public virtual Portal Portalu { get; set; } = null!;

            }
}

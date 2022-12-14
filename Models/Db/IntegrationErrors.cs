using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("INTEGRATION_ERRORS")]
    public partial class IntegrationErrors : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("INSERTID")]
        
        public int? Insertid { get; set; }


        [Column("ERRORTEXT")]
        [StringLength(255)]
        
        public string? Errortext { get; set; }



            }
}

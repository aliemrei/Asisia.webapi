using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntDialPlan : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PARENTID")]
        
        public Guid? Parentid { get; set; }


        [Column("SWID")]
        [RequiredIf]
        public Guid Swid { get; set; }


        [Column("GROUPNAME")]
        [StringLength(150)]
        [RequiredIf]
        public string Groupname { get; set; } = null!;


        [Column("PRIORITY")]
        [RequiredIf]
        public int Priority { get; set; }


        [Column("APP")]
        [StringLength(100)]
        
        public string? App { get; set; }


        [Column("APPDATA")]
        [StringLength(250)]
        
        public string? Appdata { get; set; }



            }
}

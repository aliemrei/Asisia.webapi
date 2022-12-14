using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class DbLog : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("LOGTEXT", TypeName = "ntext")]
        
        public string? Logtext { get; set; }


        [Column("TRACEFLAG")]
        [StringLength(25)]
        
        public string? Traceflag { get; set; }


        [Column("GROUPID")]
        
        public Guid? Groupid { get; set; }


        [Column("TABLENAME")]
        [StringLength(150)]
        
        public string? Tablename { get; set; }


        [Column("RECID")]
        [StringLength(45)]
        
        public string? Recid { get; set; }


        [Column("USERCODE")]
        [StringLength(150)]
        
        public string? Usercode { get; set; }


        [Column("LOGTIME", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Logtime { get; set; }



            }
}

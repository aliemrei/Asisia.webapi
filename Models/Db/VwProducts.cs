using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwProducts : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("NAME")]
        [StringLength(250)]
        
        public string? Name { get; set; }


        [Column("TYPE")]
        [StringLength(10)]
        [Unicode(false)]
        
        public string? Type { get; set; }



            }
}

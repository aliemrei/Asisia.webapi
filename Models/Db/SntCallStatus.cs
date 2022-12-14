using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCallStatus : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(25)]
        [RequiredIf]
        public string Description { get; set; } = null!;


        [Column("ISFINISHED")]
        [RequiredIf]
        public bool Isfinished { get; set; }



            }
}

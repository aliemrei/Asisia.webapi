using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwStdhotelDiscountTypes : EntityBase 
    {
        [Column("TYPEID")]
        
        public int? Typeid { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(13)]
        [Unicode(false)]
        [RequiredIf]
        public string Description { get; set; } = null!;



            }
}

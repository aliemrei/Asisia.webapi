using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("VIRTUAL_POS_SWAP")]
    public partial class VirtualPosSwap : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("POSID1")]
        [RequiredIf]
        public Guid Posid1 { get; set; }


        [Column("POSID2")]
        [RequiredIf]
        public Guid Posid2 { get; set; }



        [ForeignKey(nameof(Posid1))]
        public virtual VirtualPos Posid1Navigation { get; set; } = null!;
        [ForeignKey(nameof(Posid2))]
        public virtual VirtualPos Posid2Navigation { get; set; } = null!;

            }
}

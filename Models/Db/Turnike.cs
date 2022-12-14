using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TURNIKE")]
    [Index(nameof(Corpid), nameof(Gatenumber), Name = "UQ__TURNIKE__7049794427ADDDCD", IsUnique = true)]
    public partial class Turnike : EntityBase 
    {
        public Turnike()
        {
            TicketActivations = new HashSet<TicketActivations>();
        }

        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Key]
        [Column("GATENUMBER")]
        [StringLength(30)]
        [RequiredIf]
        public string Gatenumber { get; set; } = null!;


        [Required]
        [Column("DIRECTION")]
        
        public bool? Direction { get; set; }



        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Turnike")]
        public virtual Corp Corp { get; set; } = null!;
        [InverseProperty("GatenumberNavigation")]
        public virtual ICollection<TicketActivations> TicketActivations { get; set; }

            }
}

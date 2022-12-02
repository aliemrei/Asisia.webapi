using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TURNIKE")]
    [Index(nameof(Corpid), nameof(Gatenumber), Name = "UQ__TURNIKE__7049794427ADDDCD", IsUnique = true)]
    public partial class Turnike : EntityBase // My Handlebars Helper
    {
        public Turnike()
        {
            TicketActivations = new HashSet<TicketActivations>();
        }

        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Key]
        [Column("GATENUMBER")]
        [StringLength(30)]
        public string Gatenumber { get; set; } = null!;
        [Required]
        [Column("DIRECTION")]
        public bool? Direction { get; set; }

        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Turnike")]
        public virtual Corp Corp { get; set; } = null!;
        [InverseProperty("GatenumberNavigation")]
        public virtual ICollection<TicketActivations> TicketActivations { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

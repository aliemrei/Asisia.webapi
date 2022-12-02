using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TICKET_ACTIVATIONS")]
    public partial class TicketActivations : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("REQUEST_DETAILID")]
        public Guid? RequestDetailid { get; set; }
        [Column("GATENUMBER")]
        [StringLength(30)]
        public string? Gatenumber { get; set; }
        [Column("PERSONTYPE")]
        [StringLength(15)]
        public string Persontype { get; set; } = null!;
        [Column("PERSONNO")]
        public int Personno { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("DIRECTION")]
        public bool Direction { get; set; }
        [Column("ISALLOW")]
        public bool Isallow { get; set; }
        [Column("REASON")]
        [StringLength(250)]
        public string? Reason { get; set; }

        [ForeignKey(nameof(Gatenumber))]
        [InverseProperty(nameof(Turnike.TicketActivations))]
        public virtual Turnike? GatenumberNavigation { get; set; }
        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("TicketActivations")]
        public virtual RequestDetail? RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

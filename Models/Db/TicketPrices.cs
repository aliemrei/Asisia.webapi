using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TICKET_PRICES")]
    [Index(nameof(Pricesort), Name = "IX_TICKET_PRICES")]
    [Index(nameof(Sellfrom), nameof(Sellto), nameof(Ticketdatefrom), nameof(Ticketdateto), nameof(Checkindays), nameof(Maxvalidcapacity), Name = "IX_TICKET_PRICES_1")]
    public partial class TicketPrices : EntityBase // My Handlebars Helper
    {
        public TicketPrices()
        {
            RequestDetail = new HashSet<RequestDetail>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TICKETID")]
        public Guid Ticketid { get; set; }
        [Column("PRICETYPE")]
        public short Pricetype { get; set; }
        [Column("SELLFROM", TypeName = "datetime")]
        public DateTime? Sellfrom { get; set; }
        [Column("SELLTO", TypeName = "datetime")]
        public DateTime? Sellto { get; set; }
        [Column("TICKETDATEFROM", TypeName = "datetime")]
        public DateTime? Ticketdatefrom { get; set; }
        [Column("TICKETDATETO", TypeName = "datetime")]
        public DateTime? Ticketdateto { get; set; }
        [Column("CHECKINDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        public string? Checkindays { get; set; }
        [Column("MAXVALIDCAPACITY")]
        public int? Maxvalidcapacity { get; set; }
        [Column("PRICESORT")]
        public int? Pricesort { get; set; }
        [Column("ADULTPRICE", TypeName = "decimal(19, 2)")]
        public decimal? Adultprice { get; set; }
        [Column("CHILDPRICE", TypeName = "decimal(19, 2)")]
        public decimal? Childprice { get; set; }
        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string? Curcode { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("AGENCYID")]
        public Guid? Agencyid { get; set; }
        [Column("MARKETID")]
        public Guid? Marketid { get; set; }
        [Column("PRICEKIND")]
        public short Pricekind { get; set; }
        [Column("UNITPRICE")]
        public double? Unitprice { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.TicketPricesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Agencyid))]
        [InverseProperty("TicketPrices")]
        public virtual Agency? Agency { get; set; }
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("TicketPrices")]
        public virtual Curcode? CurcodeNavigation { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TicketPricesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Marketid))]
        [InverseProperty(nameof(Stdmarkets.TicketPrices))]
        public virtual Stdmarkets? Market { get; set; }
        [ForeignKey(nameof(Ticketid))]
        [InverseProperty("TicketPrices")]
        public virtual Ticket Ticket { get; set; } = null!;
        [InverseProperty("TicketPrice")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

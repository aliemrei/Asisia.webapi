using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("USERS_CUSTOMAUTH")]
    public partial class UsersCustomauth : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("USERID")]
        public Guid Userid { get; set; }
        [Column("ALLOWBUTGET_ONREELGRID")]
        public bool AllowbutgetOnreelgrid { get; set; }
        [Column("ALLOWCLIENT_INVOICE_INTEGRATION")]
        public bool AllowclientInvoiceIntegration { get; set; }
        [Column("EXTERNAL_PASSWORD")]
        [StringLength(50)]
        public string? ExternalPassword { get; set; }

        [ForeignKey(nameof(Userid))]
        [InverseProperty(nameof(Users.UsersCustomauth))]
        public virtual Users User { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

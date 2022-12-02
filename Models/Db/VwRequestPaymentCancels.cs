using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwRequestPaymentCancels : EntityBase // My Handlebars Helper
    {
        [Column("TYPE")]
        public int Type { get; set; }
        [Column("CANCELID")]
        public Guid Cancelid { get; set; }
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid? Corpid { get; set; }
        [Column("REQUESTID")]
        public Guid? Requestid { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("REFUND")]
        public double Refund { get; set; }
        [Column("VOID")]
        public double Void { get; set; }
        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string? Curcode { get; set; }
        [Column("REQUEST_DETAILID")]
        public Guid? RequestDetailid { get; set; }
        [Column("PAYMENTID")]
        public Guid Paymentid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class MailContents : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("MAILID")]
        public int Mailid { get; set; }
        [Column("CONTENT")]
        public string? Content { get; set; }
        [Column("MAILUID")]
        public Guid? Mailuid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

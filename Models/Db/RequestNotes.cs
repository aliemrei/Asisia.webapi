using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("REQUEST_NOTES")]
    public partial class RequestNotes : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("REQUESTID")]
        public Guid Requestid { get; set; }
        [Column("REQUEST_DETAILID")]
        public Guid? RequestDetailid { get; set; }
        [Column("NOTE")]
        public string? Note { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("NOTTYPE")]
        public byte Nottype { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.RequestNotesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.RequestNotesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Requestid))]
        [InverseProperty("RequestNotes")]
        public virtual Request Request { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

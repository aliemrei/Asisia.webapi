using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CONTACT_FORM")]
    public partial class ContactForm : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PERSONID")]
        public Guid? Personid { get; set; }
        [Column("TITLE")]
        [StringLength(200)]
        public string? Title { get; set; }
        [Column("CATEGORY")]
        public Guid? Category { get; set; }
        [Column("MESSAGETEXT")]
        public string? Messagetext { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.ContactFormAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Category))]
        [InverseProperty(nameof(ContactCategory.ContactForm))]
        public virtual ContactCategory? CategoryNavigation { get; set; }
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("ContactForm")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.ContactFormEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Personid))]
        [InverseProperty("ContactForm")]
        public virtual Person? Person { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

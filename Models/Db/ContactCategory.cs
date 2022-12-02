using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CONTACT_CATEGORY")]
    public partial class ContactCategory : EntityBase // My Handlebars Helper
    {
        public ContactCategory()
        {
            ContactForm = new HashSet<ContactForm>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("DEFINITION")]
        [StringLength(150)]
        public string Definition { get; set; } = null!;
        [Column("CORPID")]
        public Guid Corpid { get; set; }

        [ForeignKey(nameof(Corpid))]
        [InverseProperty("ContactCategory")]
        public virtual Corp Corp { get; set; } = null!;
        [InverseProperty("CategoryNavigation")]
        public virtual ICollection<ContactForm> ContactForm { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

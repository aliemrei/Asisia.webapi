using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PERSON_ADDRESS")]
    public partial class PersonAddress : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PERSONID")]
        public Guid Personid { get; set; }
        [Column("ADDRESSID")]
        public Guid? Addressid { get; set; }

        [ForeignKey(nameof(Addressid))]
        [InverseProperty(nameof(LocationAddress.PersonAddress))]
        public virtual LocationAddress? Address { get; set; }
        [ForeignKey(nameof(Personid))]
        [InverseProperty("PersonAddress")]
        public virtual Person Person { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

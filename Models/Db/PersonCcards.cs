using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PERSON_CCARDS")]
    public partial class PersonCcards : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PERSONID")]
        public Guid Personid { get; set; }
        [Column("CARDOWNER")]
        [StringLength(200)]
        public string? Cardowner { get; set; }
        [Column("CARDNUMBER")]
        [StringLength(50)]
        public string? Cardnumber { get; set; }
        [Column("VALIDYEAR")]
        public int? Validyear { get; set; }
        [Column("VALIDMONTH")]
        public int? Validmonth { get; set; }
        [Column("CVV")]
        [StringLength(5)]
        public string? Cvv { get; set; }
        [Column("UID")]
        public Guid Uid { get; set; }

        [ForeignKey(nameof(Personid))]
        [InverseProperty("PersonCcards")]
        public virtual Person Person { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

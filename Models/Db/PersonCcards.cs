using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PERSON_CCARDS")]
    public partial class PersonCcards : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("PERSONID")]
        [RequiredIf]
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
        [RequiredIf]
        public Guid Uid { get; set; }



        [ForeignKey(nameof(Personid))]
        [InverseProperty("PersonCcards")]
        public virtual Person Person { get; set; } = null!;

            }
}

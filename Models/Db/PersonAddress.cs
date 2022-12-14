using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PERSON_ADDRESS")]
    public partial class PersonAddress : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PERSONID")]
        [RequiredIf]
        public Guid Personid { get; set; }


        [Column("ADDRESSID")]
        
        public Guid? Addressid { get; set; }



        [ForeignKey(nameof(Addressid))]
        [InverseProperty(nameof(LocationAddress.PersonAddress))]
        public virtual LocationAddress? Address { get; set; }
        [ForeignKey(nameof(Personid))]
        [InverseProperty("PersonAddress")]
        public virtual Person Person { get; set; } = null!;

            }
}

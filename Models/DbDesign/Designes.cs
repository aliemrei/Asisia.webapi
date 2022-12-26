using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.DbDesign
{ // Comment
    [Table("DESIGNES")]
    [Index(nameof(Name), nameof(Formtype), Name = "UQ__DESIGNES__256EBFFE0F4598C6", IsUnique = true)]
    public partial class Designes : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("NAME")]
        [StringLength(200)]
        [RequiredIf]
        public string Name { get; set; } = null!;


        [Column("FORMTYPE")]
        [StringLength(25)]
        [RequiredIf]
        public string Formtype { get; set; } = null!;


        [Column("DESIGN", TypeName = "ntext")]
        
        public string? Design { get; set; }



            }
}

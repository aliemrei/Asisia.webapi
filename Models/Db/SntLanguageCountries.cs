using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntLanguageCountries : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("LANGCODE")]
        [StringLength(5)]
        [RequiredIf]
        public string Langcode { get; set; } = null!;


        [Column("COUNTRYCODE")]
        [StringLength(6)]
        [Unicode(false)]
        [RequiredIf]
        public string Countrycode { get; set; } = null!;



            }
}

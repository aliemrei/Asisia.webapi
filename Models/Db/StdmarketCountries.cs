using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDMARKET_COUNTRIES")]
    [Index(nameof(Countrycode), Name = "UQ__STDMARKE__FAC7CEB6C9F85917", IsUnique = true)]
    public partial class StdmarketCountries : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("STDMARKETID")]
        [RequiredIf]
        public Guid Stdmarketid { get; set; }


        [Column("COUNTRYCODE")]
        [StringLength(2)]
        [RequiredIf]
        public string Countrycode { get; set; } = null!;



        [ForeignKey(nameof(Stdmarketid))]
        [InverseProperty(nameof(Stdmarkets.StdmarketCountries))]
        public virtual Stdmarkets Stdmarket { get; set; } = null!;

            }
}

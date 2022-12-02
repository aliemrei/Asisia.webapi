using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDMARKET_COUNTRIES")]
    [Index(nameof(Countrycode), Name = "UQ__STDMARKE__FAC7CEB6C9F85917", IsUnique = true)]
    public partial class StdmarketCountries : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("STDMARKETID")]
        public Guid Stdmarketid { get; set; }
        [Column("COUNTRYCODE")]
        [StringLength(2)]
        public string Countrycode { get; set; } = null!;

        [ForeignKey(nameof(Stdmarketid))]
        [InverseProperty(nameof(Stdmarkets.StdmarketCountries))]
        public virtual Stdmarkets Stdmarket { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CITY")]
    public partial class City : EntityBase // My Handlebars Helper
    {
        public City()
        {
            District = new HashSet<District>();
            LocationAddress = new HashSet<LocationAddress>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("COUNTRYID")]
        public Guid? Countryid { get; set; }
        [Column("NAME")]
        [StringLength(70)]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(Countryid))]
        [InverseProperty("City")]
        public virtual Country? Country { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<District> District { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<LocationAddress> LocationAddress { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROPERTY_PROVIDERS")]
    [Index(nameof(Code), nameof(Corpid), Name = "UQ__PROPERTY__A871B86AD3936B19", IsUnique = true)]
    public partial class PropertyProviders : EntityBase // My Handlebars Helper
    {
        public PropertyProviders()
        {
            PropertyMapping = new HashSet<PropertyMapping>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid? Corpid { get; set; }
        [Column("CODE")]
        [StringLength(20)]
        public string Code { get; set; } = null!;
        [Column("NAME")]
        [StringLength(150)]
        public string? Name { get; set; }

        [ForeignKey(nameof(Corpid))]
        [InverseProperty("PropertyProviders")]
        public virtual Corp? Corp { get; set; }
        [InverseProperty("Provider")]
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

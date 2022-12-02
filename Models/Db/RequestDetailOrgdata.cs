using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("REQUEST_DETAIL_ORGDATA")]
    public partial class RequestDetailOrgdata : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("REQUEST_DETAILID")]
        public Guid RequestDetailid { get; set; }
        [Column("JSONDATA")]
        public string? Jsondata { get; set; }

        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("RequestDetailOrgdata")]
        public virtual RequestDetail RequestDetail { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

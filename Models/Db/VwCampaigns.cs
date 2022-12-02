using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwCampaigns : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CODE")]
        [StringLength(100)]
        public string Code { get; set; } = null!;
        [Column("DESCRIPTION")]
        [StringLength(100)]
        public string Description { get; set; } = null!;
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("RESOURCEID")]
        public Guid Resourceid { get; set; }
        [Column("PROJECTID")]
        public Guid Projectid { get; set; }
        [Column("PROJECT_DETAILID")]
        public Guid? ProjectDetailid { get; set; }
        [Column("STARTDATE", TypeName = "datetime")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "datetime")]
        public DateTime Enddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

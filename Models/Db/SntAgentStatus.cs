using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntAgentStatus : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("AGENTNAME")]
        [StringLength(150)]
        public string Agentname { get; set; } = null!;
        [Column("STATU")]
        [StringLength(30)]
        public string Statu { get; set; } = null!;
        [Column("ISBREAK")]
        public bool Isbreak { get; set; }
        [Column("STARTTIME", TypeName = "datetime")]
        public DateTime Starttime { get; set; }
        [Column("ENDTIME", TypeName = "datetime")]
        public DateTime? Endtime { get; set; }
        [Column("STATUID")]
        public int? Statuid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

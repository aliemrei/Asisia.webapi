using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("BONUS_DEF_USERS")]
    public partial class BonusDefUsers : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("BONUS_DEFID")]
        public Guid BonusDefid { get; set; }
        [Column("USERID")]
        public Guid Userid { get; set; }

        [ForeignKey(nameof(Userid))]
        [InverseProperty(nameof(Users.BonusDefUsers))]
        public virtual Users User { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

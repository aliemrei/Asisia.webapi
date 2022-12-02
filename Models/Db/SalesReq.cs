using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SALES_REQ")]
    public partial class SalesReq : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PERSONID")]
        public Guid Personid { get; set; }
        [Column("RESOURCE_DETAILID")]
        public Guid? ResourceDetailid { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.SalesReqAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.SalesReqEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Personid))]
        [InverseProperty("SalesReq")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey(nameof(ResourceDetailid))]
        [InverseProperty("SalesReq")]
        public virtual ResourceDetail? ResourceDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

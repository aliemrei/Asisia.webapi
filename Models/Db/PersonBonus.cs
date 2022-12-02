using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PERSON_BONUS")]
    public partial class PersonBonus : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PERSONID")]
        public Guid Personid { get; set; }
        [Column("TYPEID")]
        public Guid Typeid { get; set; }
        [Column("DATE", TypeName = "date")]
        public DateTime? Date { get; set; }
        [Column("POINT")]
        public double Point { get; set; }
        [Column("PRODUCTID")]
        public Guid? Productid { get; set; }
        [Column("REQUEST_DETAILID")]
        public Guid? RequestDetailid { get; set; }
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
        [Column("AMOUNT")]
        public double Amount { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PersonBonusAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PersonBonusEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Personid))]
        [InverseProperty("PersonBonus")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("PersonBonus")]
        public virtual RequestDetail? RequestDetail { get; set; }
        [ForeignKey(nameof(Typeid))]
        [InverseProperty(nameof(PersonBonusTypes.PersonBonus))]
        public virtual PersonBonusTypes Type { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

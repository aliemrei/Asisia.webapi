using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PERSON_BONUS_TYPES")]
    public partial class PersonBonusTypes : EntityBase // My Handlebars Helper
    {
        public PersonBonusTypes()
        {
            PersonBonus = new HashSet<PersonBonus>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("NAME")]
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [Column("ISNEGATIVE")]
        public bool Isnegative { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PersonBonusTypesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("PersonBonusTypes")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PersonBonusTypesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Type")]
        public virtual ICollection<PersonBonus> PersonBonus { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

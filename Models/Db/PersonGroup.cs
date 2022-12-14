using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PERSON_GROUP")]
    [Index(nameof(Corpid), nameof(Name), Name = "IX_PERSON_GROUP", IsUnique = true)]
    public partial class PersonGroup : EntityBase 
    {
        public PersonGroup()
        {
            Person = new HashSet<Person>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("NAME")]
        [StringLength(150)]
        [RequiredIf]
        public string Name { get; set; } = null!;


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PersonGroupAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("PersonGroup")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PersonGroupEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Group")]
        public virtual ICollection<Person> Person { get; set; }

            }
}

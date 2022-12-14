using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("DISTRICT")]
    public partial class District : EntityBase 
    {
        public District()
        {
            LocationAddress = new HashSet<LocationAddress>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CITYID")]
        [RequiredIf]
        public Guid Cityid { get; set; }


        [Column("NAME")]
        [StringLength(70)]
        
        public string? Name { get; set; }



        [ForeignKey(nameof(Cityid))]
        [InverseProperty("District")]
        public virtual City City { get; set; } = null!;
        [InverseProperty("District")]
        public virtual ICollection<LocationAddress> LocationAddress { get; set; }

            }
}

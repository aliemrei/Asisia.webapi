using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDROOMTYPES")]
    public partial class Stdroomtypes : EntityBase // My Handlebars Helper
    {
        public Stdroomtypes()
        {
            StdhotelRoomtypes = new HashSet<StdhotelRoomtypes>();
        }

        [Key]
        [Column("ROOMTYPE")]
        [StringLength(6)]
        public string Roomtype { get; set; } = null!;
        [Column("ENT_ROOMTYPE")]
        [StringLength(50)]
        public string? EntRoomtype { get; set; }

        [InverseProperty("RoomtypeNavigation")]
        public virtual ICollection<StdhotelRoomtypes> StdhotelRoomtypes { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

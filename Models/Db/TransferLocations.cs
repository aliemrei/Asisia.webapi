using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TRANSFER_LOCATIONS")]
    public partial class TransferLocations : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("DEFINITION")]
        [StringLength(170)]
        public string Definition { get; set; } = null!;
        [Column("LONGITUDE")]
        public double? Longitude { get; set; }
        [Column("LATITUDE")]
        public double? Latitude { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("AIRPORTCODE")]
        [StringLength(5)]
        public string? Airportcode { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.TransferLocationsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("TransferLocations")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TransferLocationsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TRANSFER_LOCATIONS")]
    public partial class TransferLocations : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("DEFINITION")]
        [StringLength(170)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("LONGITUDE")]
        
        public double? Longitude { get; set; }


        [Column("LATITUDE")]
        
        public double? Latitude { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


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

            }
}

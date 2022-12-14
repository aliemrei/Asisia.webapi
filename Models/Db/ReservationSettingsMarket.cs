using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("RESERVATION_SETTINGS_MARKET")]
    [Index(nameof(Settingsid), nameof(Marketid), Name = "UQ__RESERVATION_SETTINGS__4B96FBB176D8588E", IsUnique = true)]
    public partial class ReservationSettingsMarket : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("SETTINGSID")]
        [RequiredIf]
        public Guid Settingsid { get; set; }


        [Column("MARKETID")]
        [RequiredIf]
        public Guid Marketid { get; set; }



        [ForeignKey(nameof(Marketid))]
        [InverseProperty(nameof(StdhotelMarket.ReservationSettingsMarket))]
        public virtual StdhotelMarket Market { get; set; } = null!;
        [ForeignKey(nameof(Settingsid))]
        [InverseProperty(nameof(ReservationSettings.ReservationSettingsMarket))]
        public virtual ReservationSettings Settings { get; set; } = null!;

            }
}

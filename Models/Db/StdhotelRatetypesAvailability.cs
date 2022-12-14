using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("STDHOTEL_RATETYPES_AVAILABILITY")]
    [Index(nameof(Corpid), nameof(Roomtypeid), nameof(Ratetypeid), nameof(Date), nameof(Marketid), Name = "UQ__STDHOTEL__448ED8D9FD7F18D1", IsUnique = true)]
    public partial class StdhotelRatetypesAvailability : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("RATETYPEID")]
        [RequiredIf]
        public Guid Ratetypeid { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("DATE", TypeName = "date")]
        [RequiredIf]
        public DateTime Date { get; set; }


        [Column("DEFINEDQUOTA")]
        
        public int? Definedquota { get; set; }


        [Column("ROOMTYPEID")]
        [RequiredIf]
        public Guid Roomtypeid { get; set; }


        [Column("MARKETID")]
        
        public Guid? Marketid { get; set; }



        [ForeignKey(nameof(Marketid))]
        public virtual StdhotelMarket? Market { get; set; }
        [ForeignKey(nameof(Ratetypeid))]
        public virtual StdhotelRatetype Ratetype { get; set; } = null!;
        [ForeignKey(nameof(Roomtypeid))]
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;

            }
}

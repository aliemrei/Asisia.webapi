using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_ROOMTYPES_AVAILABILITY")]
    [Index(nameof(Corpid), nameof(Date), nameof(Roomtypeid), Name = "UQ__STDHOTEL__E5B25094C12D3A70", IsUnique = true)]
    public partial class StdhotelRoomtypesAvailability : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("ROOMTYPEID")]
        [RequiredIf]
        public Guid Roomtypeid { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("DATE", TypeName = "date")]
        [RequiredIf]
        public DateTime Date { get; set; }


        [Column("DEFINEDQUOTA")]
        
        public int? Definedquota { get; set; }


        [Column("SOLDQUOTA")]
        
        public int? Soldquota { get; set; }


        [Column("RELEASEDAYS")]
        [RequiredIf]
        public int Releasedays { get; set; }


        [Column("RELEASEDATE", TypeName = "date")]
        
        public DateTime? Releasedate { get; set; }



        [ForeignKey(nameof(Corpid))]
        [InverseProperty("StdhotelRoomtypesAvailability")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Roomtypeid))]
        [InverseProperty(nameof(StdhotelRoomtypes.StdhotelRoomtypesAvailability))]
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;

            }
}

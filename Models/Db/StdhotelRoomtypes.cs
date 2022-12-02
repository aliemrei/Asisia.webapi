using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_ROOMTYPES")]
    [Index(nameof(Roomgroup), Name = "IX_STDHOTEL_ROOMTYPES")]
    [Index(nameof(Roomtype), Name = "IX_STDHOTEL_ROOMTYPES_1")]
    [Index(nameof(Isdeleted), Name = "IX_STDHOTEL_ROOMTYPES_2")]
    [Index(nameof(Isdisabled), Name = "IX_STDHOTEL_ROOMTYPES_3")]
    public partial class StdhotelRoomtypes : EntityBase // My Handlebars Helper
    {
        public StdhotelRoomtypes()
        {
            PropertyMapping = new HashSet<PropertyMapping>();
            RequestDetail = new HashSet<RequestDetail>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
            StdhotelRatecodeDiscountRoomtype = new HashSet<StdhotelRatecodeDiscountRoomtype>();
            StdhotelRatecodeMarkupRoomtype = new HashSet<StdhotelRatecodeMarkupRoomtype>();
            StdhotelRoomtypesAvailability = new HashSet<StdhotelRoomtypesAvailability>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("ROOMTYPE")]
        [StringLength(6)]
        public string Roomtype { get; set; } = null!;
        [Column("ROOMCOUNT")]
        public int Roomcount { get; set; }
        [Column("MAXBEDCOUNT")]
        public int? Maxbedcount { get; set; }
        [Column("HOTELID")]
        public Guid Hotelid { get; set; }
        [Column("DEFINITION")]
        [StringLength(50)]
        public string? Definition { get; set; }
        [Column("ENT_ID")]
        [StringLength(50)]
        public string? EntId { get; set; }
        [Column("MINBEDCOUNT")]
        public int? Minbedcount { get; set; }
        [Column("MINADULTCOUNT")]
        public int? Minadultcount { get; set; }
        [Column("MAXADULTCOUNT")]
        public int? Maxadultcount { get; set; }
        [Column("MINCHILDCOUNT")]
        public int? Minchildcount { get; set; }
        [Column("MAXCHILDCOUNT")]
        public int? Maxchildcount { get; set; }
        [Column("MINBABYCOUNT")]
        public int? Minbabycount { get; set; }
        [Column("MAXBABYCOUNT")]
        public int? Maxbabycount { get; set; }
        [Column("THUMBNAILIMG")]
        [StringLength(250)]
        public string? Thumbnailimg { get; set; }
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("ENT_ETSID")]
        [StringLength(50)]
        public string? EntEtsid { get; set; }
        [Column("ENT_TOURISTICAID")]
        [StringLength(50)]
        public string? EntTouristicaid { get; set; }
        [Column("ENT_TATILBUDURID")]
        [StringLength(50)]
        public string? EntTatilbudurid { get; set; }
        [Column("ENT_IATIID")]
        [StringLength(50)]
        public string? EntIatiid { get; set; }
        [Column("ENT_TRAVELCLICKID")]
        [StringLength(50)]
        public string? EntTravelclickid { get; set; }
        [Column("ENT_JOLLYTOURID")]
        [StringLength(150)]
        public string? EntJollytourid { get; set; }
        [Column("ENT_SEDNAID")]
        [StringLength(250)]
        public string? EntSednaid { get; set; }
        [Column("BABYCOUNTS_INC_TO_BEDS")]
        public byte BabycountsIncToBeds { get; set; }
        [Column("ADULT_RATE")]
        public double? AdultRate { get; set; }
        [Column("CHILD_RATE")]
        public double? ChildRate { get; set; }
        [Column("BABY_RATE")]
        public double? BabyRate { get; set; }
        [Column("ENT_HOTELRUNNERID")]
        [StringLength(100)]
        public string? EntHotelrunnerid { get; set; }
        [Column("ENT_SETURID")]
        [StringLength(150)]
        public string? EntSeturid { get; set; }
        [Column("DISPLAY_PERSON_COUNT")]
        public int? DisplayPersonCount { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ADDUSER")]
        public Guid? Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("ROOMGROUP")]
        [StringLength(50)]
        public string? Roomgroup { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdhotelRoomtypesAdduserNavigation))]
        public virtual Users? AdduserNavigation { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdhotelRoomtypesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelRoomtypes))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [ForeignKey(nameof(Roomtype))]
        [InverseProperty(nameof(Stdroomtypes.StdhotelRoomtypes))]
        public virtual Stdroomtypes RoomtypeNavigation { get; set; } = null!;
        [InverseProperty("Room")]
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }
        [InverseProperty("RoomtypeNavigation")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Roomtype")]
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        [InverseProperty("Roomtype")]
        public virtual ICollection<StdhotelRatecodeDiscountRoomtype> StdhotelRatecodeDiscountRoomtype { get; set; }
        [InverseProperty("Roomtype")]
        public virtual ICollection<StdhotelRatecodeMarkupRoomtype> StdhotelRatecodeMarkupRoomtype { get; set; }
        [InverseProperty("Roomtype")]
        public virtual ICollection<StdhotelRoomtypesAvailability> StdhotelRoomtypesAvailability { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

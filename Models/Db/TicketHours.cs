using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TICKET_HOURS")]
    [Index(nameof(Datesort), Name = "IX_TICKET_HOURS")]
    [Index(nameof(Startdate), nameof(Enddate), Name = "IX_TICKET_HOURS_1")]
    public partial class TicketHours : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TICKETID")]
        public Guid Ticketid { get; set; }
        [Column("DEFINITION")]
        [StringLength(100)]
        public string Definition { get; set; } = null!;
        [Column("CAPACITY")]
        public int? Capacity { get; set; }
        [Column("STARTDATE", TypeName = "datetime")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "datetime")]
        public DateTime Enddate { get; set; }
        [Required]
        [Column("MONDAY_USE")]
        public bool? MondayUse { get; set; }
        [Column("MONDAY_STARTTIME")]
        public byte? MondayStarttime { get; set; }
        [Column("MONDAY_ENDTIME")]
        public byte? MondayEndtime { get; set; }
        [Column("MONDAY_MAXRESCOUNT")]
        public int? MondayMaxrescount { get; set; }
        [Required]
        [Column("TUESDAY_USE")]
        public bool? TuesdayUse { get; set; }
        [Column("TUESDAY_STARTTIME")]
        public byte? TuesdayStarttime { get; set; }
        [Column("TUESDAY_ENDTIME")]
        public byte? TuesdayEndtime { get; set; }
        [Column("TUESDAY_MAXRESCOUNT")]
        public int? TuesdayMaxrescount { get; set; }
        [Required]
        [Column("WEDNESDAY_USE")]
        public bool? WednesdayUse { get; set; }
        [Column("WEDNESDAY_STARTTIME")]
        public byte? WednesdayStarttime { get; set; }
        [Column("WEDNESDAY_ENDTIME")]
        public byte? WednesdayEndtime { get; set; }
        [Column("WEDNESDAY_MAXRESCOUNT")]
        public int? WednesdayMaxrescount { get; set; }
        [Required]
        [Column("THURSDAY_USE")]
        public bool? ThursdayUse { get; set; }
        [Column("THURSDAY_STARTTIME")]
        public byte? ThursdayStarttime { get; set; }
        [Column("THURSDAY_ENDTIME")]
        public byte? ThursdayEndtime { get; set; }
        [Column("THURSDAY_MAXRESCOUNT")]
        public int? ThursdayMaxrescount { get; set; }
        [Required]
        [Column("FRIDAY_USE")]
        public bool? FridayUse { get; set; }
        [Column("FRIDAY_STARTTIME")]
        public byte? FridayStarttime { get; set; }
        [Column("FRIDAY_ENDTIME")]
        public byte? FridayEndtime { get; set; }
        [Column("FRIDAY_MAXRESCOUNT")]
        public int? FridayMaxrescount { get; set; }
        [Required]
        [Column("SATURDAY_USE")]
        public bool? SaturdayUse { get; set; }
        [Column("SATURDAY_STARTTIME")]
        public byte? SaturdayStarttime { get; set; }
        [Column("SATURDAY_ENDTIME")]
        public byte? SaturdayEndtime { get; set; }
        [Column("SATURDAY_MAXRESCOUNT")]
        public int? SaturdayMaxrescount { get; set; }
        [Required]
        [Column("SUNDAY_USE")]
        public bool? SundayUse { get; set; }
        [Column("SUNDAY_STARTTIME")]
        public byte? SundayStarttime { get; set; }
        [Column("SUNDAY_ENDTIME")]
        public byte? SundayEndtime { get; set; }
        [Column("SUNDAY_MAXRESCOUNT")]
        public int? SundayMaxrescount { get; set; }
        [Column("MINUTEPERIOD")]
        public byte Minuteperiod { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("DATESORT")]
        public int? Datesort { get; set; }
        [Column("MONDAY_STARTTIME_M")]
        public byte? MondayStarttimeM { get; set; }
        [Column("MONDAY_ENDTIME_M")]
        public byte? MondayEndtimeM { get; set; }
        [Column("TUESDAY_STARTTIME_M")]
        public byte? TuesdayStarttimeM { get; set; }
        [Column("TUESDAY_ENDTIME_M")]
        public byte? TuesdayEndtimeM { get; set; }
        [Column("WEDNESDAY_STARTTIME_M")]
        public byte? WednesdayStarttimeM { get; set; }
        [Column("WEDNESDAY_ENDTIME_M")]
        public byte? WednesdayEndtimeM { get; set; }
        [Column("THURSDAY_STARTTIME_M")]
        public byte? ThursdayStarttimeM { get; set; }
        [Column("THURSDAY_ENDTIME_M")]
        public byte? ThursdayEndtimeM { get; set; }
        [Column("FRIDAY_STARTTIME_M")]
        public byte? FridayStarttimeM { get; set; }
        [Column("FRIDAY_ENDTIME_M")]
        public byte? FridayEndtimeM { get; set; }
        [Column("SATURDAY_STARTTIME_M")]
        public byte? SaturdayStarttimeM { get; set; }
        [Column("SATURDAY_ENDTIME_M")]
        public byte? SaturdayEndtimeM { get; set; }
        [Column("SUNDAY_STARTTIME_M")]
        public byte? SundayStarttimeM { get; set; }
        [Column("SUNDAY_ENDTIME_M")]
        public byte? SundayEndtimeM { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.TicketHoursAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TicketHoursEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Ticketid))]
        [InverseProperty("TicketHours")]
        public virtual Ticket Ticket { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

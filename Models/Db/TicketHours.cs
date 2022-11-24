using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TicketHours : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Ticketid { get; set; }
        public string Definition { get; set; } = null!;
        public int? Capacity { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public bool? MondayUse { get; set; }
        public byte? MondayStarttime { get; set; }
        public byte? MondayEndtime { get; set; }
        public int? MondayMaxrescount { get; set; }
        public bool? TuesdayUse { get; set; }
        public byte? TuesdayStarttime { get; set; }
        public byte? TuesdayEndtime { get; set; }
        public int? TuesdayMaxrescount { get; set; }
        public bool? WednesdayUse { get; set; }
        public byte? WednesdayStarttime { get; set; }
        public byte? WednesdayEndtime { get; set; }
        public int? WednesdayMaxrescount { get; set; }
        public bool? ThursdayUse { get; set; }
        public byte? ThursdayStarttime { get; set; }
        public byte? ThursdayEndtime { get; set; }
        public int? ThursdayMaxrescount { get; set; }
        public bool? FridayUse { get; set; }
        public byte? FridayStarttime { get; set; }
        public byte? FridayEndtime { get; set; }
        public int? FridayMaxrescount { get; set; }
        public bool? SaturdayUse { get; set; }
        public byte? SaturdayStarttime { get; set; }
        public byte? SaturdayEndtime { get; set; }
        public int? SaturdayMaxrescount { get; set; }
        public bool? SundayUse { get; set; }
        public byte? SundayStarttime { get; set; }
        public byte? SundayEndtime { get; set; }
        public int? SundayMaxrescount { get; set; }
        public byte Minuteperiod { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public int? Datesort { get; set; }
        public byte? MondayStarttimeM { get; set; }
        public byte? MondayEndtimeM { get; set; }
        public byte? TuesdayStarttimeM { get; set; }
        public byte? TuesdayEndtimeM { get; set; }
        public byte? WednesdayStarttimeM { get; set; }
        public byte? WednesdayEndtimeM { get; set; }
        public byte? ThursdayStarttimeM { get; set; }
        public byte? ThursdayEndtimeM { get; set; }
        public byte? FridayStarttimeM { get; set; }
        public byte? FridayEndtimeM { get; set; }
        public byte? SaturdayStarttimeM { get; set; }
        public byte? SaturdayEndtimeM { get; set; }
        public byte? SundayStarttimeM { get; set; }
        public byte? SundayEndtimeM { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Ticket Ticket { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

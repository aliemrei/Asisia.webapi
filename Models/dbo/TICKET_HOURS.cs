using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TICKET_HOURS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid TICKETID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public int? CAPACITY { get; set; }
        public DateTime STARTDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public bool? MONDAY_USE { get; set; }
        public byte? MONDAY_STARTTIME { get; set; }
        public byte? MONDAY_ENDTIME { get; set; }
        public int? MONDAY_MAXRESCOUNT { get; set; }
        public bool? TUESDAY_USE { get; set; }
        public byte? TUESDAY_STARTTIME { get; set; }
        public byte? TUESDAY_ENDTIME { get; set; }
        public int? TUESDAY_MAXRESCOUNT { get; set; }
        public bool? WEDNESDAY_USE { get; set; }
        public byte? WEDNESDAY_STARTTIME { get; set; }
        public byte? WEDNESDAY_ENDTIME { get; set; }
        public int? WEDNESDAY_MAXRESCOUNT { get; set; }
        public bool? THURSDAY_USE { get; set; }
        public byte? THURSDAY_STARTTIME { get; set; }
        public byte? THURSDAY_ENDTIME { get; set; }
        public int? THURSDAY_MAXRESCOUNT { get; set; }
        public bool? FRIDAY_USE { get; set; }
        public byte? FRIDAY_STARTTIME { get; set; }
        public byte? FRIDAY_ENDTIME { get; set; }
        public int? FRIDAY_MAXRESCOUNT { get; set; }
        public bool? SATURDAY_USE { get; set; }
        public byte? SATURDAY_STARTTIME { get; set; }
        public byte? SATURDAY_ENDTIME { get; set; }
        public int? SATURDAY_MAXRESCOUNT { get; set; }
        public bool? SUNDAY_USE { get; set; }
        public byte? SUNDAY_STARTTIME { get; set; }
        public byte? SUNDAY_ENDTIME { get; set; }
        public int? SUNDAY_MAXRESCOUNT { get; set; }
        public byte MINUTEPERIOD { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public int? DATESORT { get; set; }
        public byte? MONDAY_STARTTIME_M { get; set; }
        public byte? MONDAY_ENDTIME_M { get; set; }
        public byte? TUESDAY_STARTTIME_M { get; set; }
        public byte? TUESDAY_ENDTIME_M { get; set; }
        public byte? WEDNESDAY_STARTTIME_M { get; set; }
        public byte? WEDNESDAY_ENDTIME_M { get; set; }
        public byte? THURSDAY_STARTTIME_M { get; set; }
        public byte? THURSDAY_ENDTIME_M { get; set; }
        public byte? FRIDAY_STARTTIME_M { get; set; }
        public byte? FRIDAY_ENDTIME_M { get; set; }
        public byte? SATURDAY_STARTTIME_M { get; set; }
        public byte? SATURDAY_ENDTIME_M { get; set; }
        public byte? SUNDAY_STARTTIME_M { get; set; }
        public byte? SUNDAY_ENDTIME_M { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual TICKET TICKET { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

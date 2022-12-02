using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntQueueAbandon : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("QUEUEID")]
        public Guid Queueid { get; set; }
        [Column("MAXTRYCOUNT")]
        public int Maxtrycount { get; set; }
        [Column("TRY1MINUTELATER")]
        public int Try1minutelater { get; set; }
        [Column("TRY2MINUTELATER")]
        public int Try2minutelater { get; set; }
        [Column("TRY3MINUTELATER")]
        public int Try3minutelater { get; set; }
        [Column("TRY4MINUTELATER")]
        public int Try4minutelater { get; set; }
        [Column("TRY5MINUTELATER")]
        public int Try5minutelater { get; set; }
        [Column("MAXTRYCOUNT_FORBUSY")]
        public int MaxtrycountForbusy { get; set; }
        [Column("TRY1MINUTELATER_FORBUSY")]
        public int Try1minutelaterForbusy { get; set; }
        [Column("TRY2MINUTELATER_FORBUSY")]
        public int Try2minutelaterForbusy { get; set; }
        [Column("TRY3MINUTELATER_FORBUSY")]
        public int Try3minutelaterForbusy { get; set; }
        [Column("TRY4MINUTELATER_FORBUSY")]
        public int Try4minutelaterForbusy { get; set; }
        [Column("TRY5MINUTELATER_FORBUSY")]
        public int Try5minutelaterForbusy { get; set; }
        [Column("MAX_HOUR")]
        public int MaxHour { get; set; }
        [Column("MAX_MIN")]
        public int MaxMin { get; set; }
        [Column("INC_HOUR")]
        public int IncHour { get; set; }
        [Column("WEEKEND_MAX_HOUR")]
        public int? WeekendMaxHour { get; set; }
        [Column("WEEKEND_MAX_MIN")]
        public int? WeekendMaxMin { get; set; }
        [Column("WEEKEND_INC_HOUR")]
        public int? WeekendIncHour { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

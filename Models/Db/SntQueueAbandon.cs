using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntQueueAbandon : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Queueid { get; set; }
        public int Maxtrycount { get; set; }
        public int Try1minutelater { get; set; }
        public int Try2minutelater { get; set; }
        public int Try3minutelater { get; set; }
        public int Try4minutelater { get; set; }
        public int Try5minutelater { get; set; }
        public int MaxtrycountForbusy { get; set; }
        public int Try1minutelaterForbusy { get; set; }
        public int Try2minutelaterForbusy { get; set; }
        public int Try3minutelaterForbusy { get; set; }
        public int Try4minutelaterForbusy { get; set; }
        public int Try5minutelaterForbusy { get; set; }
        public int MaxHour { get; set; }
        public int MaxMin { get; set; }
        public int IncHour { get; set; }
        public int? WeekendMaxHour { get; set; }
        public int? WeekendMaxMin { get; set; }
        public int? WeekendIncHour { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

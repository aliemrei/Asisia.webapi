using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_QUEUE_ABANDON : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid QUEUEID { get; set; }
        public int MAXTRYCOUNT { get; set; }
        public int TRY1MINUTELATER { get; set; }
        public int TRY2MINUTELATER { get; set; }
        public int TRY3MINUTELATER { get; set; }
        public int TRY4MINUTELATER { get; set; }
        public int TRY5MINUTELATER { get; set; }
        public int MAXTRYCOUNT_FORBUSY { get; set; }
        public int TRY1MINUTELATER_FORBUSY { get; set; }
        public int TRY2MINUTELATER_FORBUSY { get; set; }
        public int TRY3MINUTELATER_FORBUSY { get; set; }
        public int TRY4MINUTELATER_FORBUSY { get; set; }
        public int TRY5MINUTELATER_FORBUSY { get; set; }
        public int MAX_HOUR { get; set; }
        public int MAX_MIN { get; set; }
        public int INC_HOUR { get; set; }
        public int? WEEKEND_MAX_HOUR { get; set; }
        public int? WEEKEND_MAX_MIN { get; set; }
        public int? WEEKEND_INC_HOUR { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

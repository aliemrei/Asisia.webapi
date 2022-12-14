using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntQueueAbandon : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("QUEUEID")]
        [RequiredIf]
        public Guid Queueid { get; set; }


        [Column("MAXTRYCOUNT")]
        [RequiredIf]
        public int Maxtrycount { get; set; }


        [Column("TRY1MINUTELATER")]
        [RequiredIf]
        public int Try1minutelater { get; set; }


        [Column("TRY2MINUTELATER")]
        [RequiredIf]
        public int Try2minutelater { get; set; }


        [Column("TRY3MINUTELATER")]
        [RequiredIf]
        public int Try3minutelater { get; set; }


        [Column("TRY4MINUTELATER")]
        [RequiredIf]
        public int Try4minutelater { get; set; }


        [Column("TRY5MINUTELATER")]
        [RequiredIf]
        public int Try5minutelater { get; set; }


        [Column("MAXTRYCOUNT_FORBUSY")]
        [RequiredIf]
        public int MaxtrycountForbusy { get; set; }


        [Column("TRY1MINUTELATER_FORBUSY")]
        [RequiredIf]
        public int Try1minutelaterForbusy { get; set; }


        [Column("TRY2MINUTELATER_FORBUSY")]
        [RequiredIf]
        public int Try2minutelaterForbusy { get; set; }


        [Column("TRY3MINUTELATER_FORBUSY")]
        [RequiredIf]
        public int Try3minutelaterForbusy { get; set; }


        [Column("TRY4MINUTELATER_FORBUSY")]
        [RequiredIf]
        public int Try4minutelaterForbusy { get; set; }


        [Column("TRY5MINUTELATER_FORBUSY")]
        [RequiredIf]
        public int Try5minutelaterForbusy { get; set; }


        [Column("MAX_HOUR")]
        [RequiredIf]
        public int MaxHour { get; set; }


        [Column("MAX_MIN")]
        [RequiredIf]
        public int MaxMin { get; set; }


        [Column("INC_HOUR")]
        [RequiredIf]
        public int IncHour { get; set; }


        [Column("WEEKEND_MAX_HOUR")]
        
        public int? WeekendMaxHour { get; set; }


        [Column("WEEKEND_MAX_MIN")]
        
        public int? WeekendMaxMin { get; set; }


        [Column("WEEKEND_INC_HOUR")]
        
        public int? WeekendIncHour { get; set; }



            }
}

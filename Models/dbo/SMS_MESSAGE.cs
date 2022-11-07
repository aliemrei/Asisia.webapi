using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SMS_MESSAGE : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? REQUEST_DETAILID { get; set; }
        public bool ISSENT { get; set; }
        public DateTime? SENDDATE { get; set; }
        public string MESSAGEBODY { get; set; } = null!;
        public string NUMBERS { get; set; } = null!;
        public short TYPE { get; set; }
        public Guid? SMSID { get; set; }
        public string? SENDERROR { get; set; }

        public virtual REQUEST_DETAIL? REQUEST_DETAIL { get; set; }
        public virtual SMS_SETTINGS? SMS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SmsMessage : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? RequestDetailid { get; set; }
        public bool Issent { get; set; }
        public DateTime? Senddate { get; set; }
        public string Messagebody { get; set; } = null!;
        public string Numbers { get; set; } = null!;
        public short Type { get; set; }
        public Guid? Smsid { get; set; }
        public string? Senderror { get; set; }

        public virtual RequestDetail? RequestDetail { get; set; }
        public virtual SmsSettings? Sms { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

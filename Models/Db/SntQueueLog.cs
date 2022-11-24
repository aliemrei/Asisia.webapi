using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntQueueLog : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public DateTime? Time { get; set; }
        public string? Callid { get; set; }
        public string? Queuename { get; set; }
        public string? Agent { get; set; }
        public string? Event { get; set; }
        public string? Data1 { get; set; }
        public string? Data2 { get; set; }
        public string? Data3 { get; set; }
        public string? Data4 { get; set; }
        public string? Data5 { get; set; }
        public string? Data { get; set; }
        public DateTime? Logdate { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_QUEUE_LOG : EntityBase // My Handlebars Helper
    {
        public int id { get; set; }
        public DateTime? time { get; set; }
        public string? callid { get; set; }
        public string? queuename { get; set; }
        public string? agent { get; set; }
        public string? _event { get; set; }
        public string? data1 { get; set; }
        public string? data2 { get; set; }
        public string? data3 { get; set; }
        public string? data4 { get; set; }
        public string? data5 { get; set; }
        public string? data { get; set; }
        public DateTime? logdate { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

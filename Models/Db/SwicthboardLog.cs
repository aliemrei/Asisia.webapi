using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SwicthboardLog : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string? Logkey { get; set; }
        public DateTime Adddate { get; set; }
        public string? Jsondata { get; set; }
        public string? Dst { get; set; }
        public string? Clid { get; set; }
        public string? Dstchannel { get; set; }
        public int? Channelstate { get; set; }
        public string? Channelstatedesc { get; set; }
        public int? Cause { get; set; }
        public string? Causetxt { get; set; }
        public string? Accountcode { get; set; }
        public string? Campaignname { get; set; }
        public string? Linkedid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

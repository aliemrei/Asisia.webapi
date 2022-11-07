using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SWICTHBOARD_LOG : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public string? LOGKEY { get; set; }
        public DateTime ADDDATE { get; set; }
        public string? JSONDATA { get; set; }
        public string? DST { get; set; }
        public string? CLID { get; set; }
        public string? DSTCHANNEL { get; set; }
        public int? CHANNELSTATE { get; set; }
        public string? CHANNELSTATEDESC { get; set; }
        public int? CAUSE { get; set; }
        public string? CAUSETXT { get; set; }
        public string? ACCOUNTCODE { get; set; }
        public string? CAMPAIGNNAME { get; set; }
        public string? LINKEDID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

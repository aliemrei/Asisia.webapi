using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntQueueMembers : EntityBase // My Handlebars Helper
    {
        public int Uniqueid { get; set; }
        public string? Membername { get; set; }
        public string? QueueName { get; set; }
        public string? Interface { get; set; }
        public int? Penalty { get; set; }
        public int? Paused { get; set; }
        public Guid Queueid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

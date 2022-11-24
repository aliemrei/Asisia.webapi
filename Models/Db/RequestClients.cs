using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class RequestClients : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? RequestDetailid { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? Birthdate { get; set; }
        public byte Kind { get; set; }
        public string? Hescode { get; set; }
        public bool? Gender { get; set; }
        public string? Entid { get; set; }

        public virtual RequestDetail? RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

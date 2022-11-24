using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Reports : EntityBase // My Handlebars Helper
    {
        public Reports()
        {
            CorpAutoPasswordForgetNavigation = new HashSet<Corp>();
            CorpAutoResmailClientNavigation = new HashSet<Corp>();
            CorpAutoResmailHostNavigation = new HashSet<Corp>();
            SmtpMails = new HashSet<SmtpMails>();
        }

        public Guid Id { get; set; }
        public string Reportname { get; set; } = null!;
        public Guid? Parentid { get; set; }
        public string? Design { get; set; }
        public string? Classname { get; set; }
        public string? Exporttype { get; set; }
        public byte? Kind { get; set; }

        public virtual ICollection<Corp> CorpAutoPasswordForgetNavigation { get; set; }
        public virtual ICollection<Corp> CorpAutoResmailClientNavigation { get; set; }
        public virtual ICollection<Corp> CorpAutoResmailHostNavigation { get; set; }
        public virtual ICollection<SmtpMails> SmtpMails { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

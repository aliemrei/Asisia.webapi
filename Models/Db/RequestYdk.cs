using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class RequestYdk : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid? Personid { get; set; }
        public Guid Corpid { get; set; }
        public Guid Resourceid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public string? ReqUrl { get; set; }
        public string? Campaigncode { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public DateTime? Creationdate { get; set; }
        public TimeSpan? Creationtime { get; set; }
        public Guid ProjectGroupid { get; set; }
        public Guid? Status { get; set; }
        public Guid? Substatus { get; set; }
        public string? RakamId { get; set; }
        public int? PersonCcardid { get; set; }
        public string? Curcode { get; set; }
        public Guid? Posaccountid { get; set; }
        public Guid? Posinstalmentid { get; set; }
        public bool Iscalltransfer { get; set; }
        public bool? Org { get; set; }
        public Guid? SellerUserid { get; set; }
        public DateTime? SellDate { get; set; }
        public string? Resno { get; set; }
        public DateTime? Sellingdate { get; set; }
        public TimeSpan? Sellingtime { get; set; }
        public string? DirectBranding { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

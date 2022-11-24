using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class CallJobs : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? Requestid { get; set; }
        public DateTime Calldate { get; set; }
        public long Callnumber { get; set; }
        public Guid? Userid { get; set; }
        public Guid? Personid { get; set; }
        public short Reason { get; set; }
        public short Result { get; set; }
        public short? Cancelation { get; set; }
        public string? Campaigncode { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public string? EntId { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? OutputExten { get; set; }
        public Guid? Qaid { get; set; }
        public int? Priority { get; set; }
        public string? Description { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public Guid? Corpid { get; set; }
        public string? Fullname { get; set; }
        public string Kind { get; set; } = null!;
        public Guid? ProjectGroupid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public string? ResultText { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp? Corp { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Person? Person { get; set; }
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }
        public virtual ProjectGroup? ProjectGroup { get; set; }
        public virtual Request? Request { get; set; }
        public virtual Users? User { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

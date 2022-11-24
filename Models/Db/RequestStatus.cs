using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class RequestStatus : EntityBase // My Handlebars Helper
    {
        public RequestStatus()
        {
            Payments = new HashSet<Payments>();
            Request = new HashSet<Request>();
            RequestDetailStatusNavigation = new HashSet<RequestDetail>();
            RequestDetailSubstatusNavigation = new HashSet<RequestDetail>();
            UserRoleRequestStatus = new HashSet<UserRoleRequestStatus>();
            VirtualPosDepPayments = new HashSet<VirtualPosDepPayments>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; } = null!;
        public short Substatus { get; set; }
        public short Type { get; set; }
        public int? Sortorder { get; set; }
        public string? AllowedSubstatus { get; set; }
        public short? RakamType { get; set; }
        public string? RakamId { get; set; }

        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<RequestDetail> RequestDetailStatusNavigation { get; set; }
        public virtual ICollection<RequestDetail> RequestDetailSubstatusNavigation { get; set; }
        public virtual ICollection<UserRoleRequestStatus> UserRoleRequestStatus { get; set; }
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPayments { get; set; }
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

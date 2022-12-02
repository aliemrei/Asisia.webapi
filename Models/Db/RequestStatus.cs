using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("REQUEST_STATUS")]
    [Index(nameof(Substatus), Name = "IX_REQUEST_STATUS")]
    [Index(nameof(Type), Name = "IX_REQUEST_STATUS_1")]
    [Index(nameof(Sortorder), Name = "IX_REQUEST_STATUS_2")]
    [Index(nameof(Sortorder), nameof(Type), Name = "IX_REQUEST_STATUS_3")]
    [Index(nameof(Substatus), nameof(Type), Name = "IX_REQUEST_STATUS_4")]
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

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(200)]
        public string Description { get; set; } = null!;
        [Column("SUBSTATUS")]
        public short Substatus { get; set; }
        [Column("TYPE")]
        public short Type { get; set; }
        [Column("SORTORDER")]
        public int? Sortorder { get; set; }
        [Column("ALLOWED_SUBSTATUS")]
        [StringLength(20)]
        public string? AllowedSubstatus { get; set; }
        [Column("RAKAM_TYPE")]
        public short? RakamType { get; set; }
        [Column("RAKAM_ID")]
        [StringLength(15)]
        public string? RakamId { get; set; }

        [InverseProperty("StatusNavigation")]
        public virtual ICollection<Payments> Payments { get; set; }
        [InverseProperty("StatusNavigation")]
        public virtual ICollection<Request> Request { get; set; }
        [InverseProperty(nameof(RequestDetail.StatusNavigation))]
        public virtual ICollection<RequestDetail> RequestDetailStatusNavigation { get; set; }
        [InverseProperty(nameof(RequestDetail.SubstatusNavigation))]
        public virtual ICollection<RequestDetail> RequestDetailSubstatusNavigation { get; set; }
        [InverseProperty("Statu")]
        public virtual ICollection<UserRoleRequestStatus> UserRoleRequestStatus { get; set; }
        [InverseProperty("StatusNavigation")]
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPayments { get; set; }
        [InverseProperty("StatusNavigation")]
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

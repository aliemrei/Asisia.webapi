using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PAYMENTS")]
    public partial class Payments : EntityBase // My Handlebars Helper
    {
        public Payments()
        {
            RequestPayments = new HashSet<RequestPayments>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("REQUESTID")]
        public Guid? Requestid { get; set; }
        [Column("RESOURCEID")]
        public Guid? Resourceid { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(250)]
        public string? Description { get; set; }
        [Column("ISCASH")]
        public bool Iscash { get; set; }
        [Column("ISCCARD")]
        public bool Isccard { get; set; }
        [Column("HARDPOSIDENTITY")]
        [StringLength(50)]
        public string? Hardposidentity { get; set; }
        [Column("DEBT")]
        public double Debt { get; set; }
        [Column("CREDIT")]
        public double Credit { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("STATUS")]
        public Guid Status { get; set; }
        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string Curcode { get; set; } = null!;
        [Column("PAYTYPE")]
        public byte Paytype { get; set; }
        [Column("ISBONUS")]
        public bool Isbonus { get; set; }
        [Column("TL_AMOUNT")]
        public double? TlAmount { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PaymentsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Payments")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("Payments")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PaymentsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Requestid))]
        [InverseProperty("Payments")]
        public virtual Request? Request { get; set; }
        [ForeignKey(nameof(Resourceid))]
        [InverseProperty(nameof(Resources.Payments))]
        public virtual Resources? Resource { get; set; }
        [ForeignKey(nameof(Status))]
        [InverseProperty(nameof(RequestStatus.Payments))]
        public virtual RequestStatus StatusNavigation { get; set; } = null!;
        [InverseProperty("Payment")]
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

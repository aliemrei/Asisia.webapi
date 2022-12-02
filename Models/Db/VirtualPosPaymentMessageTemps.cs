using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS")]
    public partial class VirtualPosPaymentMessageTemps : EntityBase // My Handlebars Helper
    {
        public VirtualPosPaymentMessageTemps()
        {
            VirtualPosPaymentRequestsEmailtemp = new HashSet<VirtualPosPaymentRequests>();
            VirtualPosPaymentRequestsSmstemp = new HashSet<VirtualPosPaymentRequests>();
            VirtualPosPaymentTempsEmailtemp = new HashSet<VirtualPosPaymentTemps>();
            VirtualPosPaymentTempsSmstemp = new HashSet<VirtualPosPaymentTemps>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("KIND")]
        public short Kind { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(150)]
        public string Description { get; set; } = null!;
        [Column("MESSAGETEXT")]
        public string? Messagetext { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("SUCCESSTEXT")]
        public string? Successtext { get; set; }
        [Column("ERRORTEXT")]
        public string? Errortext { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentMessageTempsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("VirtualPosPaymentMessageTemps")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentMessageTempsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentRequests.Emailtemp))]
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequestsEmailtemp { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentRequests.Smstemp))]
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequestsSmstemp { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentTemps.Emailtemp))]
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTempsEmailtemp { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentTemps.Smstemp))]
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTempsSmstemp { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS")]
    public partial class VirtualPosPaymentMessageTemps : EntityBase 
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
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("KIND")]
        [RequiredIf]
        public short Kind { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(150)]
        [RequiredIf]
        public string Description { get; set; } = null!;


        [Column("MESSAGETEXT")]
        
        public string? Messagetext { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
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

            }
}

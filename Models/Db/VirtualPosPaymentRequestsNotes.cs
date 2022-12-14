using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_PAYMENT_REQUESTS_NOTES")]
    public partial class VirtualPosPaymentRequestsNotes : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PAYMENTID")]
        [RequiredIf]
        public Guid Paymentid { get; set; }


        [Column("NOTE")]
        
        public string? Note { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("NOTTYPE")]
        [RequiredIf]
        public byte Nottype { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentRequestsNotesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentRequestsNotesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Paymentid))]
        [InverseProperty(nameof(VirtualPosPaymentRequests.VirtualPosPaymentRequestsNotes))]
        public virtual VirtualPosPaymentRequests Payment { get; set; } = null!;

            }
}

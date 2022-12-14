using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_PAYMENT_EMAILS")]
    public partial class VirtualPosPaymentEmails : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("TEMPID")]
        
        public Guid? Tempid { get; set; }


        [Column("PAYMENTID")]
        
        public Guid? Paymentid { get; set; }


        [Column("FIRSTNAME")]
        [StringLength(70)]
        [RequiredIf]
        public string Firstname { get; set; } = null!;


        [Column("LASTNAME")]
        [StringLength(70)]
        [RequiredIf]
        public string Lastname { get; set; } = null!;


        [Column("EMAIL")]
        [StringLength(200)]
        [RequiredIf]
        public string Email { get; set; } = null!;


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


        [Column("PHONENUMBER")]
        [StringLength(50)]
        
        public string? Phonenumber { get; set; }


        [Column("RESULT_MAIL")]
        
        public bool? ResultMail { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentEmailsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentEmailsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Paymentid))]
        [InverseProperty(nameof(VirtualPosPaymentRequests.VirtualPosPaymentEmails))]
        public virtual VirtualPosPaymentRequests? Payment { get; set; }
        [ForeignKey(nameof(Tempid))]
        [InverseProperty(nameof(VirtualPosPaymentTemps.VirtualPosPaymentEmails))]
        public virtual VirtualPosPaymentTemps? Temp { get; set; }

            }
}

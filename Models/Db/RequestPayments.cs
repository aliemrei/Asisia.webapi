using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("REQUEST_PAYMENTS")]
    public partial class RequestPayments : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("REQUEST_DETAILID")]
        [RequiredIf]
        public Guid RequestDetailid { get; set; }


        [Column("VIRTUAL_POS_PAYMENTID")]
        
        public Guid? VirtualPosPaymentid { get; set; }


        [Column("RATE")]
        
        public double? Rate { get; set; }


        [Column("VIRTUAL_POS_DEP_PAYMENTID")]
        
        public Guid? VirtualPosDepPaymentid { get; set; }


        [Column("VIRTUAL_POS_PAYMENT_CANCELID")]
        
        public Guid? VirtualPosPaymentCancelid { get; set; }


        [Column("VIRTUAL_POS_DEP_PAYMENT_CANCELID")]
        
        public Guid? VirtualPosDepPaymentCancelid { get; set; }


        [Column("CANCEL_RATE")]
        
        public double? CancelRate { get; set; }


        [Column("PAYMENTID")]
        
        public Guid? Paymentid { get; set; }


        [Column("ENTID")]
        [StringLength(150)]
        
        public string? Entid { get; set; }



        [ForeignKey(nameof(Paymentid))]
        [InverseProperty(nameof(Payments.RequestPayments))]
        public virtual Payments? Payment { get; set; }
        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("RequestPayments")]
        public virtual RequestDetail RequestDetail { get; set; } = null!;
        [ForeignKey(nameof(VirtualPosDepPaymentid))]
        [InverseProperty(nameof(VirtualPosDepPayments.RequestPayments))]
        public virtual VirtualPosDepPayments? VirtualPosDepPayment { get; set; }
        [ForeignKey(nameof(VirtualPosDepPaymentCancelid))]
        [InverseProperty(nameof(VirtualPosDepPaymentsCancel.RequestPayments))]
        public virtual VirtualPosDepPaymentsCancel? VirtualPosDepPaymentCancel { get; set; }
        [ForeignKey(nameof(VirtualPosPaymentid))]
        [InverseProperty(nameof(VirtualPosPayments.RequestPayments))]
        public virtual VirtualPosPayments? VirtualPosPayment { get; set; }
        [ForeignKey(nameof(VirtualPosPaymentCancelid))]
        [InverseProperty(nameof(VirtualPosPaymentsCancel.RequestPayments))]
        public virtual VirtualPosPaymentsCancel? VirtualPosPaymentCancel { get; set; }

            }
}

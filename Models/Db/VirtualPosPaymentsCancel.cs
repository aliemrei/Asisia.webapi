using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_PAYMENTS_CANCEL")]
    [Index(nameof(Success), Name = "IX_VIRTUAL_POS_PAYMENTS_CANCEL")]
    [Index(nameof(Adddate), Name = "IX_VIRTUAL_POS_PAYMENTS_CANCEL_1")]
    [Index(nameof(Adddate), Name = "IX_VIRTUAL_POS_PAYMENTS_CANCEL_2")]
    [Index(nameof(Paymentid), nameof(Success), Name = "IX_VIRTUAL_POS_PAYMENTS_CANCEL_3")]
    [Index(nameof(Entid), Name = "IX_VIRTUAL_POS_PAYMENTS_CANCEL_4")]
    public partial class VirtualPosPaymentsCancel : EntityBase 
    {
        public VirtualPosPaymentsCancel()
        {
            RequestPayments = new HashSet<RequestPayments>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PAYMENTID")]
        [RequiredIf]
        public Guid Paymentid { get; set; }


        [Column("AMOUNT")]
        [RequiredIf]
        public double Amount { get; set; }


        [Column("ISVOID")]
        [RequiredIf]
        public bool Isvoid { get; set; }


        [Column("ISREFUND")]
        [RequiredIf]
        public bool Isrefund { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("SUCCESS")]
        [RequiredIf]
        public bool Success { get; set; }


        [Column("REQUEST_DETAILID")]
        
        public Guid? RequestDetailid { get; set; }


        [Column("ENTID")]
        [StringLength(100)]
        
        public string? Entid { get; set; }



        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("VirtualPosPaymentsCancel")]
        public virtual RequestDetail? RequestDetail { get; set; }
        [InverseProperty("VirtualPosPaymentCancel")]
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }

            }
}

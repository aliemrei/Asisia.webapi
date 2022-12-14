using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_ACCOUNT_INSTALMENTS")]
    public partial class VirtualPosAccountInstalments : EntityBase 
    {
        public VirtualPosAccountInstalments()
        {
            VirtualPosPaymentVposes = new HashSet<VirtualPosPaymentVposes>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("ACCOUNTID")]
        [RequiredIf]
        public Guid Accountid { get; set; }


        [Column("OFFSET")]
        [RequiredIf]
        public int Offset { get; set; }


        [Column("COMMISSION")]
        [RequiredIf]
        public double Commission { get; set; }


        [Column("BANK_COMMISSION")]
        [RequiredIf]
        public double BankCommission { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


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


        [Column("PLUS")]
        [RequiredIf]
        public int Plus { get; set; }


        [Column("EXPIRYDAY")]
        [RequiredIf]
        public int Expiryday { get; set; }



        [ForeignKey(nameof(Accountid))]
        [InverseProperty(nameof(VirtualPosAccounts.VirtualPosAccountInstalments))]
        public virtual VirtualPosAccounts Account { get; set; } = null!;
        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosAccountInstalmentsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosAccountInstalmentsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Installment")]
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposes { get; set; }
        [InverseProperty("Posinstalment")]
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

            }
}

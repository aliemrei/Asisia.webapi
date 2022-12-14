using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("AGENCY")]
    [Index(nameof(Corpid), nameof(Fullname), nameof(Isdeleted), Name = "UQ__AGENCY__E0A4B5DC409567EB", IsUnique = true)]
    public partial class Agency : EntityBase 
    {
        public Agency()
        {
            Request = new HashSet<Request>();
            StdhotelRatecodeDiscount = new HashSet<StdhotelRatecodeDiscount>();
            TicketPrices = new HashSet<TicketPrices>();
            TransferPrices = new HashSet<TransferPrices>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("FULLNAME")]
        [StringLength(250)]
        [RequiredIf]
        public string Fullname { get; set; } = null!;


        [Column("TEL1")]
        
        public long? Tel1 { get; set; }


        [Column("TEL2")]
        
        public long? Tel2 { get; set; }


        [Column("EMAIL")]
        [StringLength(200)]
        
        public string? Email { get; set; }


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


        [Column("AUTHORIZEDID")]
        
        public Guid? Authorizedid { get; set; }


        [Column("INTID")]
        [RequiredIf]
        public int Intid { get; set; }


        [Column("GROUPID")]
        
        public Guid? Groupid { get; set; }


        [Column("DEFAULT_CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? DefaultCurcode { get; set; }


        [Column("QUOTA")]
        [RequiredIf]
        public double Quota { get; set; }


        [Column("PAYMENT_RATE")]
        [RequiredIf]
        public double PaymentRate { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.AgencyAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Authorizedid))]
        [InverseProperty(nameof(Person.Agency))]
        public virtual Person? Authorized { get; set; }
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Agency")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(DefaultCurcode))]
        [InverseProperty(nameof(Curcode.Agency))]
        public virtual Curcode? DefaultCurcodeNavigation { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.AgencyEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Groupid))]
        [InverseProperty(nameof(AgencyGroup.Agency))]
        public virtual AgencyGroup? Group { get; set; }
        [InverseProperty("Agency")]
        public virtual ICollection<Request> Request { get; set; }
        [InverseProperty("Agency")]
        public virtual ICollection<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; }
        [InverseProperty("Agency")]
        public virtual ICollection<TicketPrices> TicketPrices { get; set; }
        [InverseProperty("Agency")]
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }

            }
}

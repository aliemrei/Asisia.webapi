using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VEHICLETYPES")]
    public partial class Vehicletypes : EntityBase 
    {
        public Vehicletypes()
        {
            RequestDetail = new HashSet<RequestDetail>();
            TransferPrices = new HashSet<TransferPrices>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("VEHICLETYPE")]
        [StringLength(40)]
        [RequiredIf]
        public string Vehicletype { get; set; } = null!;


        [Column("DEFINITION")]
        [StringLength(70)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("DESCRIPTION")]
        [StringLength(250)]
        
        public string? Description { get; set; }


        [Column("PERSON_COUNT")]
        [RequiredIf]
        public int PersonCount { get; set; }


        [Column("SPECIAL_CODE")]
        [StringLength(15)]
        
        public string? SpecialCode { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


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


        [Column("BAGGAGE_CAPACITY")]
        [StringLength(10)]
        
        public string? BaggageCapacity { get; set; }


        [Required]
        [Column("AIRCONDITION")]
        
        public bool? Aircondition { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VehicletypesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Vehicletypes")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VehicletypesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Vehicletype))]
        [InverseProperty(nameof(Stdvehicletypes.Vehicletypes))]
        public virtual Stdvehicletypes VehicletypeNavigation { get; set; } = null!;
        [InverseProperty("Vehicle")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Vehicletype1")]
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }

            }
}

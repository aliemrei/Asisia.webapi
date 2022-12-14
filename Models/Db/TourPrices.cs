using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TOUR_PRICES")]
    public partial class TourPrices : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("TOURID")]
        [RequiredIf]
        public Guid Tourid { get; set; }


        [Column("DEPARTURE_DATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime DepartureDate { get; set; }


        [Column("DEPARTURE_LOCATION")]
        [StringLength(100)]
        [RequiredIf]
        public string DepartureLocation { get; set; } = null!;


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("COMMISSIONPERCENT")]
        
        public double? Commissionpercent { get; set; }


        [Column("COMMISSIONINCLUDED")]
        
        public bool? Commissionincluded { get; set; }


        [Column("SNG", TypeName = "decimal(19, 2)")]
        
        public decimal? Sng { get; set; }


        [Column("DBL", TypeName = "decimal(19, 2)")]
        
        public decimal? Dbl { get; set; }


        [Column("TRP", TypeName = "decimal(19, 2)")]
        
        public decimal? Trp { get; set; }


        [Column("QUAD", TypeName = "decimal(19, 2)")]
        
        public decimal? Quad { get; set; }


        [Column("EXBED", TypeName = "decimal(19, 2)")]
        
        public decimal? Exbed { get; set; }


        [Column("BABY", TypeName = "decimal(19, 2)")]
        
        public decimal? Baby { get; set; }


        [Column("CHDY", TypeName = "decimal(19, 2)")]
        
        public decimal? Chdy { get; set; }


        [Column("CHDE", TypeName = "decimal(19, 2)")]
        
        public decimal? Chde { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        [RequiredIf]
        public string Curcode { get; set; } = null!;


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



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.TourPricesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("TourPrices")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TourPricesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Tourid))]
        [InverseProperty("TourPrices")]
        public virtual Tour Tour { get; set; } = null!;

            }
}

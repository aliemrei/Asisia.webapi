using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TRANSFER_PRICES")]
    [Index(nameof(Tolocationid), Name = "IX_TRANSFER_PRICES")]
    [Index(nameof(Fromlocationid), Name = "IX_TRANSFER_PRICES_1")]
    [Index(nameof(Pricesort), Name = "IX_TRANSFER_PRICES_2")]
    public partial class TransferPrices : EntityBase 
    {
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


        [Column("FROMLOCATIONID")]
        [RequiredIf]
        public Guid Fromlocationid { get; set; }


        [Column("TOLOCATIONID")]
        [RequiredIf]
        public Guid Tolocationid { get; set; }


        [Column("PRICETYPE")]
        [RequiredIf]
        public short Pricetype { get; set; }


        [Column("SELLFROM", TypeName = "datetime")]
        
        public DateTime? Sellfrom { get; set; }


        [Column("SELLTO", TypeName = "datetime")]
        
        public DateTime? Sellto { get; set; }


        [Column("TICKETDATEFROM", TypeName = "datetime")]
        
        public DateTime? Ticketdatefrom { get; set; }


        [Column("TICKETDATETO", TypeName = "datetime")]
        
        public DateTime? Ticketdateto { get; set; }


        [Column("ARRIVALDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Arrivaldays { get; set; }


        [Column("DEPARTUREDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Departuredays { get; set; }


        [Column("SELLDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Selldays { get; set; }


        [Column("PRICESORT")]
        
        public int? Pricesort { get; set; }


        [Column("ADULTPRICE_ONEWAY", TypeName = "decimal(19, 2)")]
        
        public decimal? AdultpriceOneway { get; set; }


        [Column("CHILDPRICE_ONEWAY", TypeName = "decimal(19, 2)")]
        
        public decimal? ChildpriceOneway { get; set; }


        [Column("BABYPRICE_ONEWAY", TypeName = "decimal(19, 2)")]
        
        public decimal? BabypriceOneway { get; set; }


        [Column("ADULTPRICE_TWOWAY", TypeName = "decimal(19, 2)")]
        
        public decimal? AdultpriceTwoway { get; set; }


        [Column("CHILDPRICE_TWOWAY", TypeName = "decimal(19, 2)")]
        
        public decimal? ChildpriceTwoway { get; set; }


        [Column("BABYPRICE_TWOWAY", TypeName = "decimal(19, 2)")]
        
        public decimal? BabypriceTwoway { get; set; }


        [Column("VEHICLEPRICE_ONEWAY", TypeName = "decimal(19, 2)")]
        
        public decimal? VehiclepriceOneway { get; set; }


        [Column("VEHICLEPRICE_TWOWAY", TypeName = "decimal(19, 2)")]
        
        public decimal? VehiclepriceTwoway { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


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


        [Column("AGENCYID")]
        
        public Guid? Agencyid { get; set; }


        [Column("MARKETID")]
        
        public Guid? Marketid { get; set; }


        [Column("VEHICLETYPEID")]
        [RequiredIf]
        public Guid Vehicletypeid { get; set; }


        [Column("PROVIDERID")]
        
        public Guid? Providerid { get; set; }


        [Column("USEONLINE")]
        [RequiredIf]
        public short Useonline { get; set; }


        [Column("USEINBASKET")]
        [RequiredIf]
        public bool Useinbasket { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.TransferPricesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Agencyid))]
        [InverseProperty("TransferPrices")]
        public virtual Agency? Agency { get; set; }
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("TransferPrices")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("TransferPrices")]
        public virtual Curcode? CurcodeNavigation { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TransferPricesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Marketid))]
        [InverseProperty(nameof(Stdmarkets.TransferPrices))]
        public virtual Stdmarkets? Market { get; set; }
        [ForeignKey(nameof(Providerid))]
        [InverseProperty(nameof(TransferProviders.TransferPrices))]
        public virtual TransferProviders? Provider { get; set; }
        [ForeignKey(nameof(Vehicletypeid))]
        [InverseProperty(nameof(Vehicletypes.TransferPrices))]
        public virtual Vehicletypes Vehicletype1 { get; set; } = null!;
        [ForeignKey(nameof(Vehicletype))]
        [InverseProperty(nameof(Stdvehicletypes.TransferPrices))]
        public virtual Stdvehicletypes VehicletypeNavigation { get; set; } = null!;

            }
}

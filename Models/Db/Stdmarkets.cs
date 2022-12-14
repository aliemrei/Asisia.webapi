using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDMARKETS")]
    [Index(nameof(Corpid), nameof(Definition), Name = "UQ__STDMARKE__D0FAF608463C925A", IsUnique = true)]
    public partial class Stdmarkets : EntityBase 
    {
        public Stdmarkets()
        {
            PromotionCodesMarket = new HashSet<PromotionCodesMarket>();
            StdhotelMarket = new HashSet<StdhotelMarket>();
            StdmarketCountries = new HashSet<StdmarketCountries>();
            TicketMarket = new HashSet<TicketMarket>();
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


        [Column("DEFINITION")]
        [StringLength(50)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("CURCODE")]
        [StringLength(4)]
        
        public string? Curcode { get; set; }


        [Column("LANGUAGE")]
        [StringLength(5)]
        
        public string? Language { get; set; }


        [Column("FORCE_BASKETTOCURCODE")]
        [RequiredIf]
        public bool ForceBaskettocurcode { get; set; }



        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Stdmarkets")]
        public virtual Corp Corp { get; set; } = null!;
        [InverseProperty("Market")]
        public virtual ICollection<PromotionCodesMarket> PromotionCodesMarket { get; set; }
        [InverseProperty("Stdmarket")]
        public virtual ICollection<StdhotelMarket> StdhotelMarket { get; set; }
        [InverseProperty("Stdmarket")]
        public virtual ICollection<StdmarketCountries> StdmarketCountries { get; set; }
        [InverseProperty("Stdmarket")]
        public virtual ICollection<TicketMarket> TicketMarket { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<TicketPrices> TicketPrices { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }

            }
}

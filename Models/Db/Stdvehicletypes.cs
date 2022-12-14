using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDVEHICLETYPES")]
    public partial class Stdvehicletypes : EntityBase 
    {
        public Stdvehicletypes()
        {
            TransferPrices = new HashSet<TransferPrices>();
            Vehicletypes = new HashSet<Vehicletypes>();
        }

        [Key]
        [Column("VEHICLETYPE")]
        [StringLength(40)]
        [RequiredIf]
        public string Vehicletype { get; set; } = null!;


        [Column("IMGTYPE")]
        [StringLength(30)]
        
        public string? Imgtype { get; set; }



        [InverseProperty("VehicletypeNavigation")]
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }
        [InverseProperty("VehicletypeNavigation")]
        public virtual ICollection<Vehicletypes> Vehicletypes { get; set; }

            }
}

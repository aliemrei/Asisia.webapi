using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwHotelMarketCountry : EntityBase 
    {
        [Column("ID")]
        
        public Guid? Id { get; set; }


        [Column("HOTELID")]
        [RequiredIf]
        public Guid Hotelid { get; set; }


        [Column("COUNTRYCODE")]
        [StringLength(2)]
        [RequiredIf]
        public string Countrycode { get; set; } = null!;


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }



            }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class PortalLangdictionary : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("tr-TR")]
        [StringLength(250)]
        
        public string? TrTr { get; set; }


        [Column("en-US")]
        [StringLength(250)]
        
        public string? EnUs { get; set; }


        [Column("de-DE")]
        [StringLength(250)]
        
        public string? DeDe { get; set; }


        [Column("ru-RU")]
        [StringLength(250)]
        
        public string? RuRu { get; set; }


        [Column("ar-SA")]
        [StringLength(250)]
        
        public string? ArSa { get; set; }


        [Column("KEYVALUE2")]
        [StringLength(150)]
        
        public string? Keyvalue2 { get; set; }


        [Column("KEYVALUE")]
        [StringLength(150)]
        
        public string? Keyvalue { get; set; }


        [Column("fi-FI")]
        [StringLength(150)]
        
        public string? FiFi { get; set; }



            }
}

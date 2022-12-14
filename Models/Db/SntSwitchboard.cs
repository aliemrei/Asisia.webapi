using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntSwitchboard : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("NAME")]
        [StringLength(100)]
        [RequiredIf]
        public string Name { get; set; } = null!;


        [Column("IPADDRESS")]
        [StringLength(30)]
        
        public string? Ipaddress { get; set; }


        [Column("USERNAME")]
        [StringLength(40)]
        
        public string? Username { get; set; }


        [Column("PASS")]
        [StringLength(50)]
        
        public string? Pass { get; set; }


        [Column("PORT")]
        [RequiredIf]
        public int Port { get; set; }


        [Column("EXTENSIONS_FIX")]
        
        public string? ExtensionsFix { get; set; }


        [Column("CORPID")]
        
        public Guid? Corpid { get; set; }


        [Column("EXTENSIONS_OUTBOUND_FIX")]
        
        public string? ExtensionsOutboundFix { get; set; }



            }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_SETTINGS")]
    public partial class PortalSettings : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PORTALID")]
        [RequiredIf]
        public Guid Portalid { get; set; }


        [Column("BASKET_HIDE_CLIENT_DETAILS")]
        [RequiredIf]
        public bool BasketHideClientDetails { get; set; }


        [Column("BASKET_SHOW_CLIENT_GENDER")]
        [RequiredIf]
        public bool BasketShowClientGender { get; set; }


        [Column("BASKET_SHOW_TRANSFER_OPTIONS")]
        [RequiredIf]
        public bool BasketShowTransferOptions { get; set; }


        [Column("KVKK")]
        
        public string? Kvkk { get; set; }


        [Column("PRIVACY")]
        
        public string? Privacy { get; set; }


        [Column("SALES_RULES")]
        
        public string? SalesRules { get; set; }


        [Column("CANCELATION_RULES")]
        
        public string? CancelationRules { get; set; }


        [Column("POLICIES")]
        
        public string? Policies { get; set; }



        public virtual Portal Portal { get; set; } = null!;

            }
}

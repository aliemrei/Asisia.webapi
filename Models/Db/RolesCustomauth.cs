using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("ROLES_CUSTOMAUTH")]
    public partial class RolesCustomauth : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("ROLEID")]
        public Guid Roleid { get; set; }
        [Column("DISCOUNT_ADMIN")]
        public bool DiscountAdmin { get; set; }
        [Column("CREDITCARD_ADMIN")]
        public bool CreditcardAdmin { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

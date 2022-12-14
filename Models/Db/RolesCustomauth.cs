using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("ROLES_CUSTOMAUTH")]
    public partial class RolesCustomauth : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("ROLEID")]
        [RequiredIf]
        public Guid Roleid { get; set; }


        [Column("DISCOUNT_ADMIN")]
        [RequiredIf]
        public bool DiscountAdmin { get; set; }


        [Column("CREDITCARD_ADMIN")]
        [RequiredIf]
        public bool CreditcardAdmin { get; set; }



            }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("USER_HISTORY")]
    public partial class UserHistory : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("USERID")]
        [RequiredIf]
        public Guid Userid { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("IPADDRESS")]
        [StringLength(25)]
        
        public string? Ipaddress { get; set; }


        [Column("CORPTID")]
        
        public int? Corptid { get; set; }


        [Column("CORPID")]
        
        public Guid? Corpid { get; set; }



        [ForeignKey(nameof(Userid))]
        [InverseProperty(nameof(Users.UserHistory))]
        public virtual Users User { get; set; } = null!;

            }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("BASKET_DATA")]
    public partial class BasketData : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("REQUESTID")]
        
        public Guid? Requestid { get; set; }


        [Column("DATA", TypeName = "ntext")]
        
        public string? Data { get; set; }



        [ForeignKey(nameof(Requestid))]
        [InverseProperty("BasketData")]
        public virtual Request? Request { get; set; }

            }
}

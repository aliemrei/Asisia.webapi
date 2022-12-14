using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TICKET_GIFTS")]
    [Index(nameof(Corpid), nameof(Definition), Name = "UQ__TICKET_G__D0FAF60846C03765", IsUnique = true)]
    public partial class TicketGifts : EntityBase 
    {
        public TicketGifts()
        {
            RequestDetail = new HashSet<RequestDetail>();
            TileItemoption = new HashSet<TileItemoption>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("DEFINITION")]
        [StringLength(100)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("PRICE")]
        
        public double? Price { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        [RequiredIf]
        public string Curcode { get; set; } = null!;


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("PLU")]
        [StringLength(10)]
        
        public string? Plu { get; set; }



        [ForeignKey(nameof(Corpid))]
        [InverseProperty("TicketGifts")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("TicketGifts")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        [InverseProperty("Ticketgift")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Gift")]
        public virtual ICollection<TileItemoption> TileItemoption { get; set; }

            }
}

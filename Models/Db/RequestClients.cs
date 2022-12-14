using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("REQUEST_CLIENTS")]
    [Index(nameof(Firstname), Name = "IX_REQUEST_CLIENTS")]
    [Index(nameof(Lastname), Name = "IX_REQUEST_CLIENTS_1")]
    [Index(nameof(RequestDetailid), Name = "MISS_IDX_POS_PAYMENTS_LIST")]
    public partial class RequestClients : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("REQUEST_DETAILID")]
        
        public Guid? RequestDetailid { get; set; }


        [Column("FIRSTNAME")]
        [StringLength(100)]
        
        public string? Firstname { get; set; }


        [Column("LASTNAME")]
        [StringLength(100)]
        
        public string? Lastname { get; set; }


        [Column("BIRTHDATE", TypeName = "datetime")]
        
        public DateTime? Birthdate { get; set; }


        [Column("KIND")]
        [RequiredIf]
        public byte Kind { get; set; }


        [Column("HESCODE")]
        [StringLength(60)]
        
        public string? Hescode { get; set; }


        [Column("GENDER")]
        
        public bool? Gender { get; set; }


        [Column("ENTID")]
        [StringLength(100)]
        
        public string? Entid { get; set; }



        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("RequestClients")]
        public virtual RequestDetail? RequestDetail { get; set; }

            }
}

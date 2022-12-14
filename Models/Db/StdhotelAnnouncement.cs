using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_ANNOUNCEMENT")]
    public partial class StdhotelAnnouncement : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("HOTELID")]
        [RequiredIf]
        public Guid Hotelid { get; set; }


        [Column("KIND")]
        [RequiredIf]
        public short Kind { get; set; }


        [Column("DEFINITION")]
        [StringLength(150)]
        
        public string? Definition { get; set; }


        [Column("STARTDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Startdate { get; set; }


        [Column("ENDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Enddate { get; set; }


        [Column("INNERHTML")]
        
        public string? Innerhtml { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("MARKETS")]
        
        public string? Markets { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdhotelAnnouncementAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdhotelAnnouncementEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelAnnouncement))]
        public virtual Stdhotel Hotel { get; set; } = null!;

            }
}

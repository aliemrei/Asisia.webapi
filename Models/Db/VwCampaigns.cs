using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwCampaigns : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CODE")]
        [StringLength(100)]
        [RequiredIf]
        public string Code { get; set; } = null!;


        [Column("DESCRIPTION")]
        [StringLength(100)]
        [RequiredIf]
        public string Description { get; set; } = null!;


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("RESOURCEID")]
        [RequiredIf]
        public Guid Resourceid { get; set; }


        [Column("PROJECTID")]
        [RequiredIf]
        public Guid Projectid { get; set; }


        [Column("PROJECT_DETAILID")]
        
        public Guid? ProjectDetailid { get; set; }


        [Column("STARTDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Startdate { get; set; }


        [Column("ENDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Enddate { get; set; }


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



            }
}

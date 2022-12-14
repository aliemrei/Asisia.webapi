using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDLANGUAGES")]
    public partial class Stdlanguages : EntityBase 
    {
        public Stdlanguages()
        {
            PortalSeo = new HashSet<PortalSeo>();
            ProjectGroupdetailSeo = new HashSet<ProjectGroupdetailSeo>();
            Request = new HashSet<Request>();
            VirtualPosPaymentTemps = new HashSet<VirtualPosPaymentTemps>();
        }

        [Key]
        [Column("CODE")]
        [StringLength(6)]
        [Unicode(false)]
        [RequiredIf]
        public string Code { get; set; } = null!;


        [Column("DEFINITION")]
        [StringLength(100)]
        [RequiredIf]
        public string Definition { get; set; } = null!;



        [InverseProperty("LangNavigation")]
        public virtual ICollection<PortalSeo> PortalSeo { get; set; }
        [InverseProperty("LangNavigation")]
        public virtual ICollection<ProjectGroupdetailSeo> ProjectGroupdetailSeo { get; set; }
        [InverseProperty("LangcodeNavigation")]
        public virtual ICollection<Request> Request { get; set; }
        [InverseProperty("LangcodeNavigation")]
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTemps { get; set; }

            }
}

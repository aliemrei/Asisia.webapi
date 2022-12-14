using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("REPORTS")]
    public partial class Reports : EntityBase 
    {
        public Reports()
        {
            CorpAutoPasswordForgetNavigation = new HashSet<Corp>();
            CorpAutoResmailClientNavigation = new HashSet<Corp>();
            CorpAutoResmailHostNavigation = new HashSet<Corp>();
            SmtpMails = new HashSet<SmtpMails>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("REPORTNAME")]
        [StringLength(150)]
        [RequiredIf]
        public string Reportname { get; set; } = null!;


        [Column("PARENTID")]
        
        public Guid? Parentid { get; set; }


        [Column("DESIGN")]
        
        public string? Design { get; set; }


        [Column("CLASSNAME")]
        [StringLength(50)]
        
        public string? Classname { get; set; }


        [Column("EXPORTTYPE")]
        [StringLength(25)]
        
        public string? Exporttype { get; set; }


        [Column("KIND")]
        
        public byte? Kind { get; set; }



        [InverseProperty(nameof(Corp.AutoPasswordForgetNavigation))]
        public virtual ICollection<Corp> CorpAutoPasswordForgetNavigation { get; set; }
        [InverseProperty(nameof(Corp.AutoResmailClientNavigation))]
        public virtual ICollection<Corp> CorpAutoResmailClientNavigation { get; set; }
        [InverseProperty(nameof(Corp.AutoResmailHostNavigation))]
        public virtual ICollection<Corp> CorpAutoResmailHostNavigation { get; set; }
        [InverseProperty("Report")]
        public virtual ICollection<SmtpMails> SmtpMails { get; set; }

            }
}

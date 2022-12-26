using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.DbDesign
{ // Comment
    [Table("CUSTOM_MENU")]
    [Index(nameof(Parentid), nameof(Text), Name = "UQ__CUSTOM_M__6F3B28C208CB3BF3", IsUnique = true)]
    public partial class CustomMenu : EntityBase 
    {
        public CustomMenu()
        {
            InverseParent = new HashSet<CustomMenu>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PARENTID")]
        
        public Guid? Parentid { get; set; }


        [Column("TEXT")]
        [StringLength(250)]
        [RequiredIf]
        public string Text { get; set; } = null!;


        [Column("ICON")]
        [StringLength(50)]
        
        public string? Icon { get; set; }


        [Column("AUTHNAME")]
        [StringLength(250)]
        
        public string? Authname { get; set; }



        [ForeignKey(nameof(Parentid))]
        [InverseProperty(nameof(CustomMenu.InverseParent))]
        public virtual CustomMenu? Parent { get; set; }
        [InverseProperty(nameof(CustomMenu.Parent))]
        public virtual ICollection<CustomMenu> InverseParent { get; set; }

            }
}

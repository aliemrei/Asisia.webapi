using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCallbackIgnores : EntityBase 
    {
        [RequiredIf]
        public int Id { get; set; }


        [StringLength(25)]
        [RequiredIf]
        public string Number { get; set; } = null!;


        [RequiredIf]
        public bool IsDisabled { get; set; }



            }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCallbackIgnores : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        [StringLength(25)]
        public string Number { get; set; } = null!;
        public bool IsDisabled { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

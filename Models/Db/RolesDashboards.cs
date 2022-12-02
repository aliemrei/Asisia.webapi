using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("ROLES_DASHBOARDS")]
    public partial class RolesDashboards : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("ROLEID")]
        public Guid Roleid { get; set; }
        [Column("DASHBOARDID")]
        public Guid Dashboardid { get; set; }
        [Column("ALLOW")]
        public bool? Allow { get; set; }

        [ForeignKey(nameof(Dashboardid))]
        [InverseProperty("RolesDashboards")]
        public virtual Dashboard Dashboard { get; set; } = null!;
        [ForeignKey(nameof(Roleid))]
        [InverseProperty(nameof(Roles.RolesDashboards))]
        public virtual Roles Role { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

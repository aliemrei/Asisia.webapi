using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PropertyProviders : EntityBase // My Handlebars Helper
    {
        public PropertyProviders()
        {
            PropertyMapping = new HashSet<PropertyMapping>();
        }

        public Guid Id { get; set; }
        public Guid? Corpid { get; set; }
        public string Code { get; set; } = null!;
        public string? Name { get; set; }

        public virtual Corp? Corp { get; set; }
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

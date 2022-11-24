using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRoomtypesAvailability : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Roomtypeid { get; set; }
        public Guid Corpid { get; set; }
        public DateTime Date { get; set; }
        public int? Definedquota { get; set; }
        public int? Soldquota { get; set; }
        public int Releasedays { get; set; }
        public DateTime? Releasedate { get; set; }

        public virtual Corp Corp { get; set; } = null!;
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

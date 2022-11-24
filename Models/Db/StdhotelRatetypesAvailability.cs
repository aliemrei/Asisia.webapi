using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatetypesAvailability : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Ratetypeid { get; set; }
        public Guid Corpid { get; set; }
        public DateTime Date { get; set; }
        public int? Definedquota { get; set; }
        public Guid Roomtypeid { get; set; }
        public Guid? Marketid { get; set; }

        public virtual StdhotelMarket? Market { get; set; }
        public virtual StdhotelRatetype Ratetype { get; set; } = null!;
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

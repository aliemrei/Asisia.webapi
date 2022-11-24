using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwBasketPayments : EntityBase // My Handlebars Helper
    {
        public int Paytpe { get; set; }
        public Guid? Corpid { get; set; }
        public Guid? Statuid { get; set; }
        public string? Description { get; set; }
        public short? Substatus { get; set; }
        public Guid Id { get; set; }
        public Guid? Requestid { get; set; }
        public string? Pos { get; set; }
        public double Amount { get; set; }
        public double? LastAmount { get; set; }
        public string? Curcode { get; set; }
        public int? Instalment { get; set; }
        public string? Trantype { get; set; }
        public string? Storetype { get; set; }
        public DateTime Endtime { get; set; }
        public bool? Preauth { get; set; }
        public bool? Postauth { get; set; }
        public bool? Void { get; set; }
        public bool? Refund { get; set; }
        public double? Ctotal { get; set; }
        public double? Camount { get; set; }
        public string? Ccurcode { get; set; }
        public int? Intid { get; set; }
        public string? Authcode { get; set; }
        public string? Retrefnumber { get; set; }
        public string? Cardno { get; set; }
        public string? Cardowner { get; set; }
        public string? Accountname { get; set; }
        public string? Terminalid { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public double CancelAmount { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

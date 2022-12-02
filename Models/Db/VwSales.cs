using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwSales : EntityBase // My Handlebars Helper
    {
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("ID")]
        public Guid? Id { get; set; }
        [Column("REQUESTID")]
        public Guid Requestid { get; set; }
        [Column("SELL_DATE", TypeName = "date")]
        public DateTime? SellDate { get; set; }
        [Column("RDADDATE", TypeName = "date")]
        public DateTime? Rdaddate { get; set; }
        [Column("REQADDATE", TypeName = "date")]
        public DateTime? Reqaddate { get; set; }
        [Column("PRODUCTID")]
        public Guid? Productid { get; set; }
        [Column("PRODUCTNAME")]
        [StringLength(250)]
        public string? Productname { get; set; }
        [Column("PRODUCTTYPE")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Producttype { get; set; }
        [Column("STATUSCODE")]
        public short? Statuscode { get; set; }
        [Column("STATUS")]
        [StringLength(200)]
        public string? Status { get; set; }
        [Column("SUBSTATUS")]
        [StringLength(200)]
        public string? Substatus { get; set; }
        [Column("SELLER_USERID")]
        public Guid? SellerUserid { get; set; }
        [Column("AGENTID")]
        public Guid? Agentid { get; set; }
        [Column("PROJECT_GROUPID")]
        public Guid ProjectGroupid { get; set; }
        [Column("RESOURCEID")]
        public Guid Resourceid { get; set; }
        [Column("GRAND_TOTAL")]
        public double? GrandTotal { get; set; }
        [Column("CURCODE")]
        [StringLength(4)]
        [Unicode(false)]
        public string? Curcode { get; set; }
        [Column("USERNAME")]
        [StringLength(100)]
        public string? Username { get; set; }
        [Column("PROFIT_PERCENT")]
        public double? ProfitPercent { get; set; }
        [Column("PROJECT_DETAILID")]
        public Guid? ProjectDetailid { get; set; }
        [Column("PROJECT_DETAIL_INTID")]
        public int? ProjectDetailIntid { get; set; }
        [Column("ADULT")]
        public int? Adult { get; set; }
        [Column("ROOMCOUNT")]
        public int? Roomcount { get; set; }
        [Column("DATE1", TypeName = "datetime")]
        public DateTime? Date1 { get; set; }
        [Column("DATE2", TypeName = "datetime")]
        public DateTime? Date2 { get; set; }
        [Column("CHD1")]
        public int? Chd1 { get; set; }
        [Column("CHD2")]
        public int? Chd2 { get; set; }
        [Column("BABY")]
        public int? Baby { get; set; }
        [Column("PERSONID")]
        public Guid? Personid { get; set; }
        [Column("PERSONNAME")]
        [StringLength(212)]
        public string? Personname { get; set; }
        [Column("DIRECT_BRANDING")]
        [StringLength(15)]
        public string? DirectBranding { get; set; }
        [Column("NIGHTS")]
        public int? Nights { get; set; }
        [Column("PAX")]
        public int? Pax { get; set; }
        [Column("SUBPRODUCT")]
        [StringLength(50)]
        public string? Subproduct { get; set; }
        [Column("COUNTRY")]
        [StringLength(70)]
        public string? Country { get; set; }
        [Column("MARKET")]
        [StringLength(50)]
        public string? Market { get; set; }
        [Column("CANCELATION_WARRANTY")]
        public bool? CancelationWarranty { get; set; }
        [Column("CANCELLATION_WARRANTY_RATE")]
        public double? CancellationWarrantyRate { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwSalesReportAll : EntityBase // My Handlebars Helper
    {
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column("MONTH")]
        public int? Month { get; set; }
        [Column("DAY")]
        public int? Day { get; set; }
        [Column("DATE", TypeName = "date")]
        public DateTime? Date { get; set; }
        [Column("PRODUCTNAME")]
        [StringLength(200)]
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
        [Column("AGENTID")]
        public Guid? Agentid { get; set; }
        [Column("PROJECT_GROUPID")]
        public Guid ProjectGroupid { get; set; }
        [Column("RESOURCEID")]
        public Guid Resourceid { get; set; }
        [Column("DIRECT_BRANDING")]
        [StringLength(15)]
        public string? DirectBranding { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("COUNT")]
        public int? Count { get; set; }
        [Column("PAX")]
        public int? Pax { get; set; }
        [Column("ROOMCOUNT")]
        public int? Roomcount { get; set; }
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
        [Column("COST", TypeName = "decimal(38, 2)")]
        public decimal? Cost { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

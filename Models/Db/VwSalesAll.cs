using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwSalesAll : EntityBase 
    {
        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("ID")]
        
        public Guid? Id { get; set; }


        [Column("REQUESTID")]
        [RequiredIf]
        public Guid Requestid { get; set; }


        [Column("TDATE", TypeName = "datetime")]
        
        public DateTime? Tdate { get; set; }


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


        [Column("AGENTID")]
        
        public Guid? Agentid { get; set; }


        [Column("PROJECT_GROUPID")]
        [RequiredIf]
        public Guid ProjectGroupid { get; set; }


        [Column("RESOURCEID")]
        [RequiredIf]
        public Guid Resourceid { get; set; }


        [Column("TOTAL")]
        
        public double? Total { get; set; }


        [Column("EXTRA_TOTAL")]
        
        public double? ExtraTotal { get; set; }


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


        [Column("NATIONAL")]
        [StringLength(70)]
        
        public string? National { get; set; }


        [Column("MARKET")]
        [StringLength(50)]
        
        public string? Market { get; set; }


        [Column("ROOMTYPE")]
        [StringLength(50)]
        
        public string? Roomtype { get; set; }


        [Column("BOARDTYPE")]
        [StringLength(25)]
        
        public string? Boardtype { get; set; }


        [Column("RESID")]
        [StringLength(22)]
        
        public string? Resid { get; set; }


        [Column("COST", TypeName = "decimal(38, 2)")]
        
        public decimal? Cost { get; set; }


        [Column("CHDY")]
        
        public int? Chdy { get; set; }


        [Column("CHDE")]
        
        public int? Chde { get; set; }


        [Column("STATUSID")]
        
        public Guid? Statusid { get; set; }


        [Column("RESOURCECODE")]
        [StringLength(30)]
        
        public string? Resourcecode { get; set; }


        [Column("RESOURCENAME")]
        [StringLength(150)]
        
        public string? Resourcename { get; set; }



            }
}

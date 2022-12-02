using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SWICTHBOARD_LOG")]
    [Index(nameof(Adddate), Name = "IX_SWICTHBOARD_LOG")]
    [Index(nameof(Logkey), Name = "IX_SWICTHBOARD_LOG_1")]
    [Index(nameof(Logkey), nameof(Adddate), Name = "IX_SWICTHBOARD_LOG_2")]
    [Index(nameof(Linkedid), Name = "IX_SWICTHBOARD_LOG_3")]
    [Index(nameof(Dstchannel), Name = "IX_SWICTHBOARD_LOG_4")]
    [Index(nameof(Clid), nameof(Dstchannel), Name = "IX_SWICTHBOARD_LOG_5")]
    public partial class SwicthboardLog : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("LOGKEY")]
        [StringLength(50)]
        public string? Logkey { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("JSONDATA")]
        public string? Jsondata { get; set; }
        [Column("DST")]
        [StringLength(80)]
        public string? Dst { get; set; }
        [Column("CLID")]
        [StringLength(80)]
        public string? Clid { get; set; }
        [Column("DSTCHANNEL")]
        [StringLength(80)]
        public string? Dstchannel { get; set; }
        [Column("CHANNELSTATE")]
        public int? Channelstate { get; set; }
        [Column("CHANNELSTATEDESC")]
        [StringLength(90)]
        public string? Channelstatedesc { get; set; }
        [Column("CAUSE")]
        public int? Cause { get; set; }
        [Column("CAUSETXT")]
        [StringLength(150)]
        public string? Causetxt { get; set; }
        [Column("ACCOUNTCODE")]
        [StringLength(50)]
        public string? Accountcode { get; set; }
        [Column("CAMPAIGNNAME")]
        [StringLength(150)]
        public string? Campaignname { get; set; }
        [Column("LINKEDID")]
        [StringLength(50)]
        public string? Linkedid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

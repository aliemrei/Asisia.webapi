using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntQueueLog : EntityBase 
    {
        [Column("id")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("time")]
        
        public DateTime? Time { get; set; }


        [Column("callid")]
        [StringLength(32)]
        
        public string? Callid { get; set; }


        [Column("queuename")]
        [StringLength(32)]
        
        public string? Queuename { get; set; }


        [Column("agent")]
        [StringLength(32)]
        
        public string? Agent { get; set; }


        [Column("event")]
        [StringLength(32)]
        
        public string? Event { get; set; }


        [Column("data1")]
        [StringLength(255)]
        
        public string? Data1 { get; set; }


        [Column("data2")]
        [StringLength(255)]
        
        public string? Data2 { get; set; }


        [Column("data3")]
        [StringLength(255)]
        
        public string? Data3 { get; set; }


        [Column("data4")]
        [StringLength(255)]
        
        public string? Data4 { get; set; }


        [Column("data5")]
        [StringLength(255)]
        
        public string? Data5 { get; set; }


        [Column("data")]
        [StringLength(255)]
        
        public string? Data { get; set; }


        [Column("logdate", TypeName = "date")]
        
        public DateTime? Logdate { get; set; }



            }
}

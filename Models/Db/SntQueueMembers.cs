using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntQueueMembers : EntityBase 
    {
        [Column("uniqueid")]
        [RequiredIf]
        public int Uniqueid { get; set; }


        [Column("membername")]
        [StringLength(40)]
        [Unicode(false)]
        
        public string? Membername { get; set; }


        [Column("queue_name")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueName { get; set; }


        [Column("interface")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? Interface { get; set; }


        [Column("penalty")]
        
        public int? Penalty { get; set; }


        [Column("paused")]
        
        public int? Paused { get; set; }


        [Column("queueid")]
        [RequiredIf]
        public Guid Queueid { get; set; }



            }
}

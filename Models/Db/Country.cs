using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("COUNTRY")]
    public partial class Country : EntityBase 
    {
        public Country()
        {
            City = new HashSet<City>();
            LocationAddress = new HashSet<LocationAddress>();
            Person = new HashSet<Person>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("NAME")]
        [StringLength(70)]
        [RequiredIf]
        public string Name { get; set; } = null!;


        [Column("ISOCODE2")]
        [StringLength(2)]
        [Unicode(false)]
        
        public string? Isocode2 { get; set; }


        [Column("DIAL_CODE")]
        [StringLength(15)]
        
        public string? DialCode { get; set; }



        [InverseProperty("Country")]
        public virtual ICollection<City> City { get; set; }
        [InverseProperty("Country")]
        public virtual ICollection<LocationAddress> LocationAddress { get; set; }
        [InverseProperty("NationalityNavigation")]
        public virtual ICollection<Person> Person { get; set; }

            }
}

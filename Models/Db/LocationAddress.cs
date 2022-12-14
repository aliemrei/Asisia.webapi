using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("LOCATION_ADDRESS")]
    public partial class LocationAddress : EntityBase 
    {
        public LocationAddress()
        {
            Corp = new HashSet<Corp>();
            PersonAddress = new HashSet<PersonAddress>();
            ProjectGroup = new HashSet<ProjectGroup>();
            Request = new HashSet<Request>();
            Stdhotel = new HashSet<Stdhotel>();
            Stdstore = new HashSet<Stdstore>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("TYPE")]
        
        public short? Type { get; set; }


        [Column("LINE1")]
        [StringLength(100)]
        
        public string? Line1 { get; set; }


        [Column("LINE2")]
        [StringLength(100)]
        
        public string? Line2 { get; set; }


        [Column("COUNTRYID")]
        
        public Guid? Countryid { get; set; }


        [Column("CITYID")]
        
        public Guid? Cityid { get; set; }


        [Column("LATITUDE")]
        
        public double? Latitude { get; set; }


        [Column("LONGITUDE")]
        
        public double? Longitude { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("ZIPCODE")]
        [StringLength(30)]
        
        public string? Zipcode { get; set; }


        [Column("DISTRICTID")]
        
        public Guid? Districtid { get; set; }


        [Column("INVOICE_TYPE")]
        [RequiredIf]
        public byte InvoiceType { get; set; }


        [Column("INVOICE_TAXNO")]
        [StringLength(25)]
        
        public string? InvoiceTaxno { get; set; }


        [Column("INVOICE_TAXPLACENAME")]
        [StringLength(100)]
        
        public string? InvoiceTaxplacename { get; set; }


        [Column("INVOICE_EMAIL")]
        [StringLength(200)]
        
        public string? InvoiceEmail { get; set; }


        [Column("INVOICE_TITLE")]
        [StringLength(200)]
        
        public string? InvoiceTitle { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.LocationAddressAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Cityid))]
        [InverseProperty("LocationAddress")]
        public virtual City? City { get; set; }
        [ForeignKey(nameof(Countryid))]
        [InverseProperty("LocationAddress")]
        public virtual Country? Country { get; set; }
        [ForeignKey(nameof(Districtid))]
        [InverseProperty("LocationAddress")]
        public virtual District? District { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.LocationAddressEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Corp> Corp { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<PersonAddress> PersonAddress { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<ProjectGroup> ProjectGroup { get; set; }
        [InverseProperty("InvoiceAddress")]
        public virtual ICollection<Request> Request { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Stdhotel> Stdhotel { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Stdstore> Stdstore { get; set; }

            }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROJECT_GROUPDETAIL")]
    [Index(nameof(Intid), Name = "IX_PROJECT_GROUPDETAIL", IsUnique = true)]
    public partial class ProjectGroupdetail : EntityBase // My Handlebars Helper
    {
        public ProjectGroupdetail()
        {
            CallJobs = new HashSet<CallJobs>();
            PaymentEmails = new HashSet<PaymentEmails>();
            Portal = new HashSet<Portal>();
            PortalSeo = new HashSet<PortalSeo>();
            ProjectGroupdetailBankdep = new HashSet<ProjectGroupdetailBankdep>();
            ProjectGroupdetailVpos = new HashSet<ProjectGroupdetailVpos>();
            RequestDetail = new HashSet<RequestDetail>();
            ReservationEmails = new HashSet<ReservationEmails>();
            ResourceDetail = new HashSet<ResourceDetail>();
            SmsSettings = new HashSet<SmsSettings>();
            UserProjectDetails = new HashSet<UserProjectDetails>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("INTID")]
        public int Intid { get; set; }
        [Column("PROJECT_GROUPID")]
        public Guid ProjectGroupid { get; set; }
        [Column("HOTELID")]
        public Guid? Hotelid { get; set; }
        [Column("TICKETID")]
        public Guid? Ticketid { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(200)]
        public string? Description { get; set; }
        [Column("ENT_ID")]
        [StringLength(25)]
        public string? EntId { get; set; }
        [Column("PROFIT_PERCENT")]
        public double ProfitPercent { get; set; }
        [Column("GA_CUSTOMERID")]
        [StringLength(15)]
        public string? GaCustomerid { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ACC_INV_CODE")]
        [StringLength(30)]
        public string? AccInvCode { get; set; }
        [Column("ACC_PAY_CODE")]
        [StringLength(30)]
        public string? AccPayCode { get; set; }
        [Column("TEL1")]
        public long? Tel1 { get; set; }
        [Column("TEL2")]
        public long? Tel2 { get; set; }
        [Column("EMAIL")]
        [StringLength(150)]
        public string? Email { get; set; }
        [Column("DONT_MERGE")]
        public bool DontMerge { get; set; }
        [Column("INVOICE_DUEDAY")]
        public int? InvoiceDueday { get; set; }
        [Column("TOURID")]
        public Guid? Tourid { get; set; }
        [Column("ENT_ETSID")]
        [StringLength(50)]
        public string? EntEtsid { get; set; }
        [Column("ENT_TOURISTICAID")]
        [StringLength(50)]
        public string? EntTouristicaid { get; set; }
        [Column("ENT_TATILBUDURID")]
        [StringLength(20)]
        public string? EntTatilbudurid { get; set; }
        [Column("PRODUCTID")]
        public Guid? Productid { get; set; }
        [Column("ENT_IATIID")]
        [StringLength(50)]
        public string? EntIatiid { get; set; }
        [Column("ENT_ETSURL")]
        [StringLength(350)]
        public string? EntEtsurl { get; set; }
        [Column("ENT_TOURISTICAURL")]
        [StringLength(350)]
        public string? EntTouristicaurl { get; set; }
        [Column("ENT_TATILBUDURURL")]
        [StringLength(350)]
        public string? EntTatilbudururl { get; set; }
        [Column("ENT_IATIURL")]
        [StringLength(350)]
        public string? EntIatiurl { get; set; }
        [Column("ENT_TRAVELCLICKID")]
        [StringLength(50)]
        public string? EntTravelclickid { get; set; }
        [Column("ENT_TRAVELCLCIKURL")]
        [StringLength(350)]
        public string? EntTravelclcikurl { get; set; }
        [Column("ENT_JOLLYTOURURL")]
        [StringLength(250)]
        public string? EntJollytoururl { get; set; }
        [Column("ENT_JOLLYTOURID")]
        [StringLength(150)]
        public string? EntJollytourid { get; set; }
        [Column("RES_MAILURL")]
        [StringLength(250)]
        public string? ResMailurl { get; set; }
        [Column("ENT_SEDNAURL")]
        [StringLength(250)]
        public string? EntSednaurl { get; set; }
        [Column("ENT_SEDNAID")]
        [StringLength(250)]
        public string? EntSednaid { get; set; }
        [Column("ENT_PORTALID")]
        public int? EntPortalid { get; set; }
        [Column("ENT_URL")]
        [StringLength(250)]
        public string? EntUrl { get; set; }
        [Column("ENT_HOTELRUNNERID")]
        [StringLength(150)]
        public string? EntHotelrunnerid { get; set; }
        [Column("ENT_HOTELRUNNERURL")]
        [StringLength(150)]
        public string? EntHotelrunnerurl { get; set; }
        [Column("HIDE_CONTRACTTAB_FROMAGENTS")]
        public bool HideContracttabFromagents { get; set; }
        [Column("ENT_SETURID")]
        [StringLength(150)]
        public string? EntSeturid { get; set; }
        [Column("ENT_SETURURL")]
        [StringLength(150)]
        public string? EntSetururl { get; set; }
        [Column("STOREID")]
        public Guid? Storeid { get; set; }

        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.ProjectGroupdetail))]
        public virtual Stdhotel? Hotel { get; set; }
        [ForeignKey(nameof(ProjectGroupid))]
        [InverseProperty("ProjectGroupdetail")]
        public virtual ProjectGroup ProjectGroup { get; set; } = null!;
        [ForeignKey(nameof(Storeid))]
        [InverseProperty(nameof(Stdstore.ProjectGroupdetail))]
        public virtual Stdstore? Store { get; set; }
        [ForeignKey(nameof(Ticketid))]
        [InverseProperty("ProjectGroupdetail")]
        public virtual Ticket? Ticket { get; set; }
        [ForeignKey(nameof(Tourid))]
        [InverseProperty("ProjectGroupdetail")]
        public virtual Tour? Tour { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ReservationRules? ReservationRules { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ICollection<PaymentEmails> PaymentEmails { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ICollection<Portal> Portal { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ICollection<PortalSeo> PortalSeo { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ICollection<ProjectGroupdetailBankdep> ProjectGroupdetailBankdep { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ICollection<ProjectGroupdetailVpos> ProjectGroupdetailVpos { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ICollection<ReservationEmails> ReservationEmails { get; set; }
        [InverseProperty("ProjectGroupdetail")]
        public virtual ICollection<ResourceDetail> ResourceDetail { get; set; }
        [InverseProperty("ProjectDetail")]
        public virtual ICollection<SmsSettings> SmsSettings { get; set; }
        [InverseProperty("ProjectGroupdetail")]
        public virtual ICollection<UserProjectDetails> UserProjectDetails { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

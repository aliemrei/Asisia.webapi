using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
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

        public Guid Id { get; set; }
        public int Intid { get; set; }
        public Guid ProjectGroupid { get; set; }
        public Guid? Hotelid { get; set; }
        public Guid? Ticketid { get; set; }
        public string? Description { get; set; }
        public string? EntId { get; set; }
        public double ProfitPercent { get; set; }
        public string? GaCustomerid { get; set; }
        public bool Isdisabled { get; set; }
        public string? AccInvCode { get; set; }
        public string? AccPayCode { get; set; }
        public long? Tel1 { get; set; }
        public long? Tel2 { get; set; }
        public string? Email { get; set; }
        public bool DontMerge { get; set; }
        public int? InvoiceDueday { get; set; }
        public Guid? Tourid { get; set; }
        public string? EntEtsid { get; set; }
        public string? EntTouristicaid { get; set; }
        public string? EntTatilbudurid { get; set; }
        public Guid? Productid { get; set; }
        public string? EntIatiid { get; set; }
        public string? EntEtsurl { get; set; }
        public string? EntTouristicaurl { get; set; }
        public string? EntTatilbudururl { get; set; }
        public string? EntIatiurl { get; set; }
        public string? EntTravelclickid { get; set; }
        public string? EntTravelclcikurl { get; set; }
        public string? EntJollytoururl { get; set; }
        public string? EntJollytourid { get; set; }
        public string? ResMailurl { get; set; }
        public string? EntSednaurl { get; set; }
        public string? EntSednaid { get; set; }
        public int? EntPortalid { get; set; }
        public string? EntUrl { get; set; }
        public string? EntHotelrunnerid { get; set; }
        public string? EntHotelrunnerurl { get; set; }
        public bool HideContracttabFromagents { get; set; }
        public string? EntSeturid { get; set; }
        public string? EntSetururl { get; set; }
        public Guid? Storeid { get; set; }

        public virtual Stdhotel? Hotel { get; set; }
        public virtual ProjectGroup ProjectGroup { get; set; } = null!;
        public virtual Stdstore? Store { get; set; }
        public virtual Ticket? Ticket { get; set; }
        public virtual Tour? Tour { get; set; }
        public virtual ReservationRules? ReservationRules { get; set; }
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        public virtual ICollection<PaymentEmails> PaymentEmails { get; set; }
        public virtual ICollection<Portal> Portal { get; set; }
        public virtual ICollection<PortalSeo> PortalSeo { get; set; }
        public virtual ICollection<ProjectGroupdetailBankdep> ProjectGroupdetailBankdep { get; set; }
        public virtual ICollection<ProjectGroupdetailVpos> ProjectGroupdetailVpos { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<ReservationEmails> ReservationEmails { get; set; }
        public virtual ICollection<ResourceDetail> ResourceDetail { get; set; }
        public virtual ICollection<SmsSettings> SmsSettings { get; set; }
        public virtual ICollection<UserProjectDetails> UserProjectDetails { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

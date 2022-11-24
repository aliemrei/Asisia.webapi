using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class RequestDetail : EntityBase // My Handlebars Helper
    {
        public RequestDetail()
        {
            HotelReservations = new HashSet<HotelReservations>();
            InverseCorrelation = new HashSet<RequestDetail>();
            PersonBonus = new HashSet<PersonBonus>();
            RequestClients = new HashSet<RequestClients>();
            RequestDetailOrgdata = new HashSet<RequestDetailOrgdata>();
            RequestPayments = new HashSet<RequestPayments>();
            SmsMessage = new HashSet<SmsMessage>();
            SmtpMails = new HashSet<SmtpMails>();
            TicketActivations = new HashSet<TicketActivations>();
            VirtualPosDepPaymentsCancel = new HashSet<VirtualPosDepPaymentsCancel>();
            VirtualPosPaymentsCancel = new HashSet<VirtualPosPaymentsCancel>();
        }

        public Guid Id { get; set; }
        public Guid Requestid { get; set; }
        public DateTime? InterviewDate { get; set; }
        public int Kind { get; set; }
        public string? Description { get; set; }
        public Guid? Hotelid { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public int? Roomcount { get; set; }
        public int? Bedcount { get; set; }
        public int? Adult { get; set; }
        public int? Chd1 { get; set; }
        public int? Chd2 { get; set; }
        public int? Age1 { get; set; }
        public int? Age2 { get; set; }
        public int? Age3 { get; set; }
        public int? Age4 { get; set; }
        public int? Baby { get; set; }
        public string? Childages { get; set; }
        public double? Total { get; set; }
        public double? ExtraTotal { get; set; }
        public double? GrandTotal { get; set; }
        public string? Curcode { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }
        public string? Roomtype { get; set; }
        public int? SwLogid { get; set; }
        public string? Boardtype { get; set; }
        public Guid? Status { get; set; }
        public Guid? Substatus { get; set; }
        public short Possibility { get; set; }
        public string? EBoardtypeid { get; set; }
        public string? ERoomtypeid { get; set; }
        public string? Extra { get; set; }
        public double? ContractPrice { get; set; }
        public double? DiscountPercent { get; set; }
        public string? DiscountCombination { get; set; }
        public Guid? Campaignid { get; set; }
        public Guid? Productid { get; set; }
        public Guid? Resourceid { get; set; }
        public string? Icon { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public bool? Isnotavailable { get; set; }
        public byte? DiscountReq { get; set; }
        public double? DiscountRate { get; set; }
        public string? DiscountDescription { get; set; }
        public byte? DiscountResult { get; set; }
        public string? DiscountResultdesc { get; set; }
        public string? Resno { get; set; }
        public Guid? SellerUserid { get; set; }
        public DateTime? SellDate { get; set; }
        public DateTime? Sellingdate { get; set; }
        public TimeSpan? Sellingtime { get; set; }
        public DateTime? Creationdate { get; set; }
        public TimeSpan? Creationtime { get; set; }
        public Guid? Ticketid { get; set; }
        public int? Entid { get; set; }
        public Guid? Roomtypeid { get; set; }
        public Guid? Boardtypeid { get; set; }
        public Guid? Ratetypeid { get; set; }
        public Guid? Marketid { get; set; }
        public Guid? Ratecodeid { get; set; }
        public Guid? Correlationid { get; set; }
        public double? Currate { get; set; }
        public Guid? PriceConditionid { get; set; }
        public int? Chde { get; set; }
        public int? Chdy { get; set; }
        public Guid? Ticketgiftid { get; set; }
        public double? Quantity { get; set; }
        public double? AdultPrice { get; set; }
        public double? ChdPrice { get; set; }
        public int? TicketPriceid { get; set; }
        public int Validday { get; set; }
        public DateTime? Validdate { get; set; }
        public int Intid { get; set; }
        public Guid? Tourid { get; set; }
        public string? ManualPrice { get; set; }
        public Guid? Fromlocationid { get; set; }
        public Guid? Tolocationid { get; set; }
        public bool? Roundtrip { get; set; }
        public Guid? TransferPriceid { get; set; }
        public Guid? Vehicleid { get; set; }
        public Guid? Promotionid { get; set; }
        public Guid? ReservationSettingsid { get; set; }
        public string? Ipaddress { get; set; }
        public string? Country { get; set; }
        public string? Pnr1 { get; set; }
        public string? Pnr2 { get; set; }
        public string? Extnotes { get; set; }
        public double? CancelationRate { get; set; }
        public int? CancelationDays { get; set; }
        public double? PaymentRate { get; set; }
        public double? CancellationWarrantyRate { get; set; }
        public string? National { get; set; }
        public DateTime? CancellationDate { get; set; }
        public Guid? CancellationUserid { get; set; }
        public bool? MenAccommodationForbidden { get; set; }
        public bool? UseInoffer { get; set; }
        public string? Finalprices { get; set; }
        public Guid? AdditionalDiscountid { get; set; }
        public DateTime? Chd1Birthdate { get; set; }
        public DateTime? Chd2Birthdate { get; set; }
        public DateTime? Chd3Birthdate { get; set; }
        public DateTime? Chd4Birthdate { get; set; }
        public string? Cancellationid { get; set; }
        public double BonusTotal { get; set; }
        public double? DiscountTotal { get; set; }
        public int? InvoiceEntid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual StdhotelBoardtypes? BoardtypeNavigation { get; set; }
        public virtual Campaigns? Campaign { get; set; }
        public virtual Users? CancellationUser { get; set; }
        public virtual RequestDetail? Correlation { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdhotel? Hotel { get; set; }
        public virtual StdhotelMarket? Market { get; set; }
        public virtual StdhotelPricecondition? PriceCondition { get; set; }
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }
        public virtual PromotionCodes? Promotion { get; set; }
        public virtual StdhotelRatecode? Ratecode { get; set; }
        public virtual StdhotelRatetype? Ratetype { get; set; }
        public virtual Request Request { get; set; } = null!;
        public virtual ReservationSettings? ReservationSettings { get; set; }
        public virtual Resources? Resource { get; set; }
        public virtual StdhotelRoomtypes? RoomtypeNavigation { get; set; }
        public virtual Users? SellerUser { get; set; }
        public virtual RequestStatus? StatusNavigation { get; set; }
        public virtual RequestStatus? SubstatusNavigation { get; set; }
        public virtual Ticket? Ticket { get; set; }
        public virtual TicketPrices? TicketPrice { get; set; }
        public virtual TicketGifts? Ticketgift { get; set; }
        public virtual Tour? Tour { get; set; }
        public virtual Vehicletypes? Vehicle { get; set; }
        public virtual ICollection<HotelReservations> HotelReservations { get; set; }
        public virtual ICollection<RequestDetail> InverseCorrelation { get; set; }
        public virtual ICollection<PersonBonus> PersonBonus { get; set; }
        public virtual ICollection<RequestClients> RequestClients { get; set; }
        public virtual ICollection<RequestDetailOrgdata> RequestDetailOrgdata { get; set; }
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }
        public virtual ICollection<SmsMessage> SmsMessage { get; set; }
        public virtual ICollection<SmtpMails> SmtpMails { get; set; }
        public virtual ICollection<TicketActivations> TicketActivations { get; set; }
        public virtual ICollection<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancel { get; set; }
        public virtual ICollection<VirtualPosPaymentsCancel> VirtualPosPaymentsCancel { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

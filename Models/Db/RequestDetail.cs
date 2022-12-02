using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("REQUEST_DETAIL")]
    [Index(nameof(Kind), Name = "IDX_MIS_DASHBOARD_REPORT")]
    [Index(nameof(Status), nameof(Roomtypeid), nameof(Date1), Name = "IX_MISSING_HOTELSEARCH1")]
    [Index(nameof(Kind), nameof(Correlationid), Name = "IX_RD_KIND_CORRELATIOIN")]
    [Index(nameof(Kind), nameof(Status), Name = "IX_RD_KIND_STATUS")]
    [Index(nameof(Kind), nameof(Sellingdate), Name = "IX_RECOMMEND_RD_KIND_SELLINGDATE")]
    [Index(nameof(Requestid), nameof(Kind), Name = "IX_REQUEST_DETAIL")]
    [Index(nameof(Adduser), nameof(Edituser), nameof(Requestid), Name = "IX_REQUEST_DETAIL_1")]
    [Index(nameof(DiscountReq), Name = "IX_REQUEST_DETAIL_2")]
    [Index(nameof(DiscountResult), Name = "IX_REQUEST_DETAIL_3")]
    [Index(nameof(SellDate), Name = "IX_REQUEST_DETAIL_4")]
    [Index(nameof(Intid), Name = "IX_REQUEST_DETAIL_5")]
    [Index(nameof(Requestid), nameof(Adduser), nameof(Edituser), Name = "IX_REQUEST_DETAIL_IMP")]
    [Index(nameof(Kind), Name = "MIS_INDEX_DASHBOARD_SALES_ANALYSIS_1")]
    [Index(nameof(SwLogid), Name = "MIS_IX_REQUESTID")]
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

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("REQUESTID")]
        public Guid Requestid { get; set; }
        [Column("INTERVIEW_DATE", TypeName = "datetime")]
        public DateTime? InterviewDate { get; set; }
        [Column("KIND")]
        public int Kind { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(250)]
        public string? Description { get; set; }
        [Column("HOTELID")]
        public Guid? Hotelid { get; set; }
        [Column("DATE1", TypeName = "datetime")]
        public DateTime? Date1 { get; set; }
        [Column("DATE2", TypeName = "datetime")]
        public DateTime? Date2 { get; set; }
        [Column("ROOMCOUNT")]
        public int? Roomcount { get; set; }
        [Column("BEDCOUNT")]
        public int? Bedcount { get; set; }
        [Column("ADULT")]
        public int? Adult { get; set; }
        [Column("CHD1")]
        public int? Chd1 { get; set; }
        [Column("CHD2")]
        public int? Chd2 { get; set; }
        [Column("AGE1")]
        public int? Age1 { get; set; }
        [Column("AGE2")]
        public int? Age2 { get; set; }
        [Column("AGE3")]
        public int? Age3 { get; set; }
        [Column("AGE4")]
        public int? Age4 { get; set; }
        [Column("BABY")]
        public int? Baby { get; set; }
        [Column("CHILDAGES")]
        [StringLength(40)]
        public string? Childages { get; set; }
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
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("ROOMTYPE")]
        [StringLength(60)]
        public string? Roomtype { get; set; }
        [Column("SW_LOGID")]
        public int? SwLogid { get; set; }
        [Column("BOARDTYPE")]
        [StringLength(100)]
        public string? Boardtype { get; set; }
        [Column("STATUS")]
        public Guid? Status { get; set; }
        [Column("SUBSTATUS")]
        public Guid? Substatus { get; set; }
        [Column("POSSIBILITY")]
        public short Possibility { get; set; }
        [Column("E_BOARDTYPEID")]
        [StringLength(25)]
        public string? EBoardtypeid { get; set; }
        [Column("E_ROOMTYPEID")]
        [StringLength(25)]
        public string? ERoomtypeid { get; set; }
        [Column("EXTRA")]
        public string? Extra { get; set; }
        [Column("CONTRACT_PRICE")]
        public double? ContractPrice { get; set; }
        [Column("DISCOUNT_PERCENT")]
        public double? DiscountPercent { get; set; }
        [Column("DISCOUNT_COMBINATION")]
        [StringLength(150)]
        public string? DiscountCombination { get; set; }
        [Column("CAMPAIGNID")]
        public Guid? Campaignid { get; set; }
        [Column("PRODUCTID")]
        public Guid? Productid { get; set; }
        [Column("RESOURCEID")]
        public Guid? Resourceid { get; set; }
        [Column("ICON")]
        [StringLength(250)]
        public string? Icon { get; set; }
        [Column("PROJECT_DETAILID")]
        public Guid? ProjectDetailid { get; set; }
        [Column("ISNOTAVAILABLE")]
        public bool? Isnotavailable { get; set; }
        [Column("DISCOUNT_REQ")]
        public byte? DiscountReq { get; set; }
        [Column("DISCOUNT_RATE")]
        public double? DiscountRate { get; set; }
        [Column("DISCOUNT_DESCRIPTION")]
        [StringLength(250)]
        public string? DiscountDescription { get; set; }
        [Column("DISCOUNT_RESULT")]
        public byte? DiscountResult { get; set; }
        [Column("DISCOUNT_RESULTDESC")]
        [StringLength(250)]
        public string? DiscountResultdesc { get; set; }
        [Column("RESNO")]
        [StringLength(50)]
        public string? Resno { get; set; }
        [Column("SELLER_USERID")]
        public Guid? SellerUserid { get; set; }
        [Column("SELL_DATE", TypeName = "datetime")]
        public DateTime? SellDate { get; set; }
        [Column("SELLINGDATE", TypeName = "date")]
        public DateTime? Sellingdate { get; set; }
        [Column("SELLINGTIME")]
        public TimeSpan? Sellingtime { get; set; }
        [Column("CREATIONDATE", TypeName = "date")]
        public DateTime? Creationdate { get; set; }
        [Column("CREATIONTIME")]
        public TimeSpan? Creationtime { get; set; }
        [Column("TICKETID")]
        public Guid? Ticketid { get; set; }
        [Column("ENTID")]
        public int? Entid { get; set; }
        [Column("ROOMTYPEID")]
        public Guid? Roomtypeid { get; set; }
        [Column("BOARDTYPEID")]
        public Guid? Boardtypeid { get; set; }
        [Column("RATETYPEID")]
        public Guid? Ratetypeid { get; set; }
        [Column("MARKETID")]
        public Guid? Marketid { get; set; }
        [Column("RATECODEID")]
        public Guid? Ratecodeid { get; set; }
        [Column("CORRELATIONID")]
        public Guid? Correlationid { get; set; }
        [Column("CURRATE")]
        public double? Currate { get; set; }
        [Column("PRICE_CONDITIONID")]
        public Guid? PriceConditionid { get; set; }
        [Column("CHDE")]
        public int? Chde { get; set; }
        [Column("CHDY")]
        public int? Chdy { get; set; }
        [Column("TICKETGIFTID")]
        public Guid? Ticketgiftid { get; set; }
        [Column("QUANTITY")]
        public double? Quantity { get; set; }
        [Column("ADULT_PRICE")]
        public double? AdultPrice { get; set; }
        [Column("CHD_PRICE")]
        public double? ChdPrice { get; set; }
        [Column("TICKET_PRICEID")]
        public int? TicketPriceid { get; set; }
        [Column("VALIDDAY")]
        public int Validday { get; set; }
        [Column("VALIDDATE", TypeName = "datetime")]
        public DateTime? Validdate { get; set; }
        [Column("INTID")]
        public int Intid { get; set; }
        [Column("TOURID")]
        public Guid? Tourid { get; set; }
        [Column("MANUAL_PRICE")]
        [StringLength(50)]
        public string? ManualPrice { get; set; }
        [Column("FROMLOCATIONID")]
        public Guid? Fromlocationid { get; set; }
        [Column("TOLOCATIONID")]
        public Guid? Tolocationid { get; set; }
        [Required]
        [Column("ROUNDTRIP")]
        public bool? Roundtrip { get; set; }
        [Column("TRANSFER_PRICEID")]
        public Guid? TransferPriceid { get; set; }
        [Column("VEHICLEID")]
        public Guid? Vehicleid { get; set; }
        [Column("PROMOTIONID")]
        public Guid? Promotionid { get; set; }
        [Column("RESERVATION_SETTINGSID")]
        public Guid? ReservationSettingsid { get; set; }
        [Column("IPADDRESS")]
        [StringLength(25)]
        public string? Ipaddress { get; set; }
        [Column("COUNTRY")]
        [StringLength(120)]
        public string? Country { get; set; }
        [Column("PNR1")]
        [StringLength(15)]
        public string? Pnr1 { get; set; }
        [Column("PNR2")]
        [StringLength(15)]
        public string? Pnr2 { get; set; }
        [Column("EXTNOTES")]
        [StringLength(250)]
        public string? Extnotes { get; set; }
        [Column("CANCELATION_RATE")]
        public double? CancelationRate { get; set; }
        [Column("CANCELATION_DAYS")]
        public int? CancelationDays { get; set; }
        [Column("PAYMENT_RATE")]
        public double? PaymentRate { get; set; }
        [Column("CANCELLATION_WARRANTY_RATE")]
        public double? CancellationWarrantyRate { get; set; }
        [Column("NATIONAL")]
        [StringLength(10)]
        public string? National { get; set; }
        [Column("CANCELLATION_DATE", TypeName = "datetime")]
        public DateTime? CancellationDate { get; set; }
        [Column("CANCELLATION_USERID")]
        public Guid? CancellationUserid { get; set; }
        [Column("MEN_ACCOMMODATION_FORBIDDEN")]
        public bool? MenAccommodationForbidden { get; set; }
        [Column("USE_INOFFER")]
        public bool? UseInoffer { get; set; }
        [Column("FINALPRICES")]
        [StringLength(350)]
        public string? Finalprices { get; set; }
        [Column("ADDITIONAL_DISCOUNTID")]
        public Guid? AdditionalDiscountid { get; set; }
        [Column("CHD1_BIRTHDATE", TypeName = "date")]
        public DateTime? Chd1Birthdate { get; set; }
        [Column("CHD2_BIRTHDATE", TypeName = "date")]
        public DateTime? Chd2Birthdate { get; set; }
        [Column("CHD3_BIRTHDATE", TypeName = "date")]
        public DateTime? Chd3Birthdate { get; set; }
        [Column("CHD4_BIRTHDATE", TypeName = "date")]
        public DateTime? Chd4Birthdate { get; set; }
        [Column("CANCELLATIONID")]
        [StringLength(50)]
        public string? Cancellationid { get; set; }
        [Column("BONUS_TOTAL")]
        public double BonusTotal { get; set; }
        [Column("DISCOUNT_TOTAL")]
        public double? DiscountTotal { get; set; }
        [Column("INVOICE_ENTID")]
        public int? InvoiceEntid { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.RequestDetailAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Boardtypeid))]
        [InverseProperty(nameof(StdhotelBoardtypes.RequestDetail))]
        public virtual StdhotelBoardtypes? BoardtypeNavigation { get; set; }
        [ForeignKey(nameof(Campaignid))]
        [InverseProperty(nameof(Campaigns.RequestDetail))]
        public virtual Campaigns? Campaign { get; set; }
        [ForeignKey(nameof(CancellationUserid))]
        [InverseProperty(nameof(Users.RequestDetailCancellationUser))]
        public virtual Users? CancellationUser { get; set; }
        [ForeignKey(nameof(Correlationid))]
        [InverseProperty(nameof(RequestDetail.InverseCorrelation))]
        public virtual RequestDetail? Correlation { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.RequestDetailEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.RequestDetail))]
        public virtual Stdhotel? Hotel { get; set; }
        [ForeignKey(nameof(Marketid))]
        [InverseProperty(nameof(StdhotelMarket.RequestDetail))]
        public virtual StdhotelMarket? Market { get; set; }
        [ForeignKey(nameof(PriceConditionid))]
        [InverseProperty(nameof(StdhotelPricecondition.RequestDetail))]
        public virtual StdhotelPricecondition? PriceCondition { get; set; }
        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.RequestDetail))]
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }
        [ForeignKey(nameof(Promotionid))]
        [InverseProperty(nameof(PromotionCodes.RequestDetail))]
        public virtual PromotionCodes? Promotion { get; set; }
        [ForeignKey(nameof(Ratecodeid))]
        [InverseProperty(nameof(StdhotelRatecode.RequestDetail))]
        public virtual StdhotelRatecode? Ratecode { get; set; }
        [ForeignKey(nameof(Ratetypeid))]
        [InverseProperty(nameof(StdhotelRatetype.RequestDetail))]
        public virtual StdhotelRatetype? Ratetype { get; set; }
        [ForeignKey(nameof(Requestid))]
        [InverseProperty("RequestDetail")]
        public virtual Request Request { get; set; } = null!;
        [ForeignKey(nameof(ReservationSettingsid))]
        [InverseProperty("RequestDetail")]
        public virtual ReservationSettings? ReservationSettings { get; set; }
        [ForeignKey(nameof(Resourceid))]
        [InverseProperty(nameof(Resources.RequestDetail))]
        public virtual Resources? Resource { get; set; }
        [ForeignKey(nameof(Roomtypeid))]
        [InverseProperty(nameof(StdhotelRoomtypes.RequestDetail))]
        public virtual StdhotelRoomtypes? RoomtypeNavigation { get; set; }
        [ForeignKey(nameof(SellerUserid))]
        [InverseProperty(nameof(Users.RequestDetailSellerUser))]
        public virtual Users? SellerUser { get; set; }
        [ForeignKey(nameof(Status))]
        [InverseProperty(nameof(RequestStatus.RequestDetailStatusNavigation))]
        public virtual RequestStatus? StatusNavigation { get; set; }
        [ForeignKey(nameof(Substatus))]
        [InverseProperty(nameof(RequestStatus.RequestDetailSubstatusNavigation))]
        public virtual RequestStatus? SubstatusNavigation { get; set; }
        [ForeignKey(nameof(Ticketid))]
        [InverseProperty("RequestDetail")]
        public virtual Ticket? Ticket { get; set; }
        [ForeignKey(nameof(TicketPriceid))]
        [InverseProperty(nameof(TicketPrices.RequestDetail))]
        public virtual TicketPrices? TicketPrice { get; set; }
        [ForeignKey(nameof(Ticketgiftid))]
        [InverseProperty(nameof(TicketGifts.RequestDetail))]
        public virtual TicketGifts? Ticketgift { get; set; }
        [ForeignKey(nameof(Tourid))]
        [InverseProperty("RequestDetail")]
        public virtual Tour? Tour { get; set; }
        [ForeignKey(nameof(Vehicleid))]
        [InverseProperty(nameof(Vehicletypes.RequestDetail))]
        public virtual Vehicletypes? Vehicle { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<HotelReservations> HotelReservations { get; set; }
        [InverseProperty(nameof(RequestDetail.Correlation))]
        public virtual ICollection<RequestDetail> InverseCorrelation { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<PersonBonus> PersonBonus { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<RequestClients> RequestClients { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<RequestDetailOrgdata> RequestDetailOrgdata { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<SmsMessage> SmsMessage { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<SmtpMails> SmtpMails { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<TicketActivations> TicketActivations { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancel { get; set; }
        [InverseProperty("RequestDetail")]
        public virtual ICollection<VirtualPosPaymentsCancel> VirtualPosPaymentsCancel { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

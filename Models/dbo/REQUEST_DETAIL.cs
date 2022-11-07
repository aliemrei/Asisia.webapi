using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class REQUEST_DETAIL : EntityBase // My Handlebars Helper
    {
        public REQUEST_DETAIL()
        {
            HOTEL_RESERVATIONS = new HashSet<HOTEL_RESERVATIONS>();
            InverseCORRELATION = new HashSet<REQUEST_DETAIL>();
            PERSON_BONUS = new HashSet<PERSON_BONUS>();
            REQUEST_CLIENTS = new HashSet<REQUEST_CLIENTS>();
            REQUEST_DETAIL_ORGDATA = new HashSet<REQUEST_DETAIL_ORGDATA>();
            REQUEST_PAYMENTS = new HashSet<REQUEST_PAYMENTS>();
            SMS_MESSAGE = new HashSet<SMS_MESSAGE>();
            SMTP_MAILS = new HashSet<SMTP_MAILS>();
            TICKET_ACTIVATIONS = new HashSet<TICKET_ACTIVATIONS>();
            VIRTUAL_POS_DEP_PAYMENTS_CANCEL = new HashSet<VIRTUAL_POS_DEP_PAYMENTS_CANCEL>();
            VIRTUAL_POS_PAYMENTS_CANCEL = new HashSet<VIRTUAL_POS_PAYMENTS_CANCEL>();
        }

        public Guid ID { get; set; }
        public Guid REQUESTID { get; set; }
        public DateTime? INTERVIEW_DATE { get; set; }
        public int KIND { get; set; }
        public string? DESCRIPTION { get; set; }
        public Guid? HOTELID { get; set; }
        public DateTime? DATE1 { get; set; }
        public DateTime? DATE2 { get; set; }
        public int? ROOMCOUNT { get; set; }
        public int? BEDCOUNT { get; set; }
        public int? ADULT { get; set; }
        public int? CHD1 { get; set; }
        public int? CHD2 { get; set; }
        public int? AGE1 { get; set; }
        public int? AGE2 { get; set; }
        public int? AGE3 { get; set; }
        public int? AGE4 { get; set; }
        public int? BABY { get; set; }
        public string? CHILDAGES { get; set; }
        public double? TOTAL { get; set; }
        public double? EXTRA_TOTAL { get; set; }
        public double? GRAND_TOTAL { get; set; }
        public string? CURCODE { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public string? ROOMTYPE { get; set; }
        public int? SW_LOGID { get; set; }
        public string? BOARDTYPE { get; set; }
        public Guid? STATUS { get; set; }
        public Guid? SUBSTATUS { get; set; }
        public short POSSIBILITY { get; set; }
        public string? E_BOARDTYPEID { get; set; }
        public string? E_ROOMTYPEID { get; set; }
        public string? EXTRA { get; set; }
        public double? CONTRACT_PRICE { get; set; }
        public double? DISCOUNT_PERCENT { get; set; }
        public string? DISCOUNT_COMBINATION { get; set; }
        public Guid? CAMPAIGNID { get; set; }
        public Guid? PRODUCTID { get; set; }
        public Guid? RESOURCEID { get; set; }
        public string? ICON { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public bool? ISNOTAVAILABLE { get; set; }
        public byte? DISCOUNT_REQ { get; set; }
        public double? DISCOUNT_RATE { get; set; }
        public string? DISCOUNT_DESCRIPTION { get; set; }
        public byte? DISCOUNT_RESULT { get; set; }
        public string? DISCOUNT_RESULTDESC { get; set; }
        public string? RESNO { get; set; }
        public Guid? SELLER_USERID { get; set; }
        public DateTime? SELL_DATE { get; set; }
        public DateTime? SELLINGDATE { get; set; }
        public TimeSpan? SELLINGTIME { get; set; }
        public DateTime? CREATIONDATE { get; set; }
        public TimeSpan? CREATIONTIME { get; set; }
        public Guid? TICKETID { get; set; }
        public int? ENTID { get; set; }
        public Guid? ROOMTYPEID { get; set; }
        public Guid? BOARDTYPEID { get; set; }
        public Guid? RATETYPEID { get; set; }
        public Guid? MARKETID { get; set; }
        public Guid? RATECODEID { get; set; }
        public Guid? CORRELATIONID { get; set; }
        public double? CURRATE { get; set; }
        public Guid? PRICE_CONDITIONID { get; set; }
        public int? CHDE { get; set; }
        public int? CHDY { get; set; }
        public Guid? TICKETGIFTID { get; set; }
        public double? QUANTITY { get; set; }
        public double? ADULT_PRICE { get; set; }
        public double? CHD_PRICE { get; set; }
        public int? TICKET_PRICEID { get; set; }
        public int VALIDDAY { get; set; }
        public DateTime? VALIDDATE { get; set; }
        public int INTID { get; set; }
        public Guid? TOURID { get; set; }
        public string? MANUAL_PRICE { get; set; }
        public Guid? FROMLOCATIONID { get; set; }
        public Guid? TOLOCATIONID { get; set; }
        public bool? ROUNDTRIP { get; set; }
        public Guid? TRANSFER_PRICEID { get; set; }
        public Guid? VEHICLEID { get; set; }
        public Guid? PROMOTIONID { get; set; }
        public Guid? RESERVATION_SETTINGSID { get; set; }
        public string? IPADDRESS { get; set; }
        public string? COUNTRY { get; set; }
        public string? PNR1 { get; set; }
        public string? PNR2 { get; set; }
        public string? EXTNOTES { get; set; }
        public double? CANCELATION_RATE { get; set; }
        public int? CANCELATION_DAYS { get; set; }
        public double? PAYMENT_RATE { get; set; }
        public double? CANCELLATION_WARRANTY_RATE { get; set; }
        public string? NATIONAL { get; set; }
        public DateTime? CANCELLATION_DATE { get; set; }
        public Guid? CANCELLATION_USERID { get; set; }
        public bool? MEN_ACCOMMODATION_FORBIDDEN { get; set; }
        public bool? USE_INOFFER { get; set; }
        public string? FINALPRICES { get; set; }
        public Guid? ADDITIONAL_DISCOUNTID { get; set; }
        public DateTime? CHD1_BIRTHDATE { get; set; }
        public DateTime? CHD2_BIRTHDATE { get; set; }
        public DateTime? CHD3_BIRTHDATE { get; set; }
        public DateTime? CHD4_BIRTHDATE { get; set; }
        public string? CANCELLATIONID { get; set; }
        public double BONUS_TOTAL { get; set; }
        public double? DISCOUNT_TOTAL { get; set; }
        public int? INVOICE_ENTID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual STDHOTEL_BOARDTYPES? BOARDTYPENavigation { get; set; }
        public virtual CAMPAIGNS? CAMPAIGN { get; set; }
        public virtual USERS? CANCELLATION_USER { get; set; }
        public virtual REQUEST_DETAIL? CORRELATION { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDHOTEL? HOTEL { get; set; }
        public virtual STDHOTEL_MARKET? MARKET { get; set; }
        public virtual STDHOTEL_PRICECONDITION? PRICE_CONDITION { get; set; }
        public virtual PROJECT_GROUPDETAIL? PROJECT_DETAIL { get; set; }
        public virtual PROMOTION_CODES? PROMOTION { get; set; }
        public virtual STDHOTEL_RATECODE? RATECODE { get; set; }
        public virtual STDHOTEL_RATETYPE? RATETYPE { get; set; }
        public virtual REQUEST REQUEST { get; set; } = null!;
        public virtual RESERVATION_SETTINGS? RESERVATION_SETTINGS { get; set; }
        public virtual RESOURCES? RESOURCE { get; set; }
        public virtual STDHOTEL_ROOMTYPES? ROOMTYPENavigation { get; set; }
        public virtual USERS? SELLER_USER { get; set; }
        public virtual REQUEST_STATUS? STATUSNavigation { get; set; }
        public virtual REQUEST_STATUS? SUBSTATUSNavigation { get; set; }
        public virtual TICKET? TICKET { get; set; }
        public virtual TICKET_GIFTS? TICKETGIFT { get; set; }
        public virtual TICKET_PRICES? TICKET_PRICE { get; set; }
        public virtual TOUR? TOUR { get; set; }
        public virtual VEHICLETYPES? VEHICLE { get; set; }
        public virtual ICollection<HOTEL_RESERVATIONS> HOTEL_RESERVATIONS { get; set; }
        public virtual ICollection<REQUEST_DETAIL> InverseCORRELATION { get; set; }
        public virtual ICollection<PERSON_BONUS> PERSON_BONUS { get; set; }
        public virtual ICollection<REQUEST_CLIENTS> REQUEST_CLIENTS { get; set; }
        public virtual ICollection<REQUEST_DETAIL_ORGDATA> REQUEST_DETAIL_ORGDATA { get; set; }
        public virtual ICollection<REQUEST_PAYMENTS> REQUEST_PAYMENTS { get; set; }
        public virtual ICollection<SMS_MESSAGE> SMS_MESSAGE { get; set; }
        public virtual ICollection<SMTP_MAILS> SMTP_MAILS { get; set; }
        public virtual ICollection<TICKET_ACTIVATIONS> TICKET_ACTIVATIONS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEP_PAYMENTS_CANCEL> VIRTUAL_POS_DEP_PAYMENTS_CANCEL { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENTS_CANCEL> VIRTUAL_POS_PAYMENTS_CANCEL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

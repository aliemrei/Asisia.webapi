using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_ROOMTYPES : EntityBase // My Handlebars Helper
    {
        public STDHOTEL_ROOMTYPES()
        {
            PROPERTY_MAPPING = new HashSet<PROPERTY_MAPPING>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            STDHOTEL_PRICECONDITION = new HashSet<STDHOTEL_PRICECONDITION>();
            STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE = new HashSet<STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE>();
            STDHOTEL_RATECODE_MARKUP_ROOMTYPE = new HashSet<STDHOTEL_RATECODE_MARKUP_ROOMTYPE>();
            STDHOTEL_ROOMTYPES_AVAILABILITY = new HashSet<STDHOTEL_ROOMTYPES_AVAILABILITY>();
        }

        public Guid ID { get; set; }
        public string ROOMTYPE { get; set; } = null!;
        public int ROOMCOUNT { get; set; }
        public int? MAXBEDCOUNT { get; set; }
        public Guid HOTELID { get; set; }
        public string? DEFINITION { get; set; }
        public string? ENT_ID { get; set; }
        public int? MINBEDCOUNT { get; set; }
        public int? MINADULTCOUNT { get; set; }
        public int? MAXADULTCOUNT { get; set; }
        public int? MINCHILDCOUNT { get; set; }
        public int? MAXCHILDCOUNT { get; set; }
        public int? MINBABYCOUNT { get; set; }
        public int? MAXBABYCOUNT { get; set; }
        public string? THUMBNAILIMG { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? ENT_ETSID { get; set; }
        public string? ENT_TOURISTICAID { get; set; }
        public string? ENT_TATILBUDURID { get; set; }
        public string? ENT_IATIID { get; set; }
        public string? ENT_TRAVELCLICKID { get; set; }
        public string? ENT_JOLLYTOURID { get; set; }
        public string? ENT_SEDNAID { get; set; }
        public byte BABYCOUNTS_INC_TO_BEDS { get; set; }
        public double? ADULT_RATE { get; set; }
        public double? CHILD_RATE { get; set; }
        public double? BABY_RATE { get; set; }
        public string? ENT_HOTELRUNNERID { get; set; }
        public string? ENT_SETURID { get; set; }
        public int? DISPLAY_PERSON_COUNT { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid? ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? ROOMGROUP { get; set; }

        public virtual USERS? ADDUSERNavigation { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual STDROOMTYPES ROOMTYPENavigation { get; set; } = null!;
        public virtual ICollection<PROPERTY_MAPPING> PROPERTY_MAPPING { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<STDHOTEL_PRICECONDITION> STDHOTEL_PRICECONDITION { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE> STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_MARKUP_ROOMTYPE> STDHOTEL_RATECODE_MARKUP_ROOMTYPE { get; set; }
        public virtual ICollection<STDHOTEL_ROOMTYPES_AVAILABILITY> STDHOTEL_ROOMTYPES_AVAILABILITY { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

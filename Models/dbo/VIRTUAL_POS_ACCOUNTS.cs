using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_ACCOUNTS : EntityBase // My Handlebars Helper
    {
        public VIRTUAL_POS_ACCOUNTS()
        {
            VIRTUAL_POS_ACCOUNTS_CURCODES = new HashSet<VIRTUAL_POS_ACCOUNTS_CURCODES>();
            VIRTUAL_POS_ACCOUNT_INSTALMENTS = new HashSet<VIRTUAL_POS_ACCOUNT_INSTALMENTS>();
            VIRTUAL_POS_PAYMENTS = new HashSet<VIRTUAL_POS_PAYMENTS>();
        }

        public Guid ID { get; set; }
        public Guid POSID { get; set; }
        public Guid CORPID { get; set; }
        public string? CLIENTID { get; set; }
        public string? TERMINALID { get; set; }
        public string? ACCOUNTNAME { get; set; }
        public string? PASSWORD { get; set; }
        public string? PASSWORD_3D { get; set; }
        public string? PARAMS { get; set; }
        public byte USE3D { get; set; }
        public string? POSTURL { get; set; }
        public bool INSTALMENT_MERGE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? DEFINITION { get; set; }
        public string? ENT_HOTELID { get; set; }
        public string? BINNUMBER_NAME { get; set; }
        public bool ISFOREIGN_POS { get; set; }
        public string? EMAIL { get; set; }
        public string? ENTID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual VIRTUAL_POS POS { get; set; } = null!;
        public virtual ICollection<VIRTUAL_POS_ACCOUNTS_CURCODES> VIRTUAL_POS_ACCOUNTS_CURCODES { get; set; }
        public virtual ICollection<VIRTUAL_POS_ACCOUNT_INSTALMENTS> VIRTUAL_POS_ACCOUNT_INSTALMENTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENTS> VIRTUAL_POS_PAYMENTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntSippeers : EntityBase // My Handlebars Helper
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("swid")]
        public Guid Swid { get; set; }
        [Column("uid")]
        public Guid Uid { get; set; }
        [Column("name")]
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Column("ipaddr")]
        [StringLength(15)]
        [Unicode(false)]
        public string? Ipaddr { get; set; }
        [Column("port")]
        public int? Port { get; set; }
        [Column("regseconds")]
        public int? Regseconds { get; set; }
        [Column("defaultuser")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Defaultuser { get; set; }
        [Column("fullcontact")]
        [StringLength(35)]
        [Unicode(false)]
        public string? Fullcontact { get; set; }
        [Column("regserver")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Regserver { get; set; }
        [Column("useragent")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Useragent { get; set; }
        [Column("lastms")]
        public int? Lastms { get; set; }
        [Column("host")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Host { get; set; }
        [Column("type")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Type { get; set; }
        [Column("context")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Context { get; set; }
        [Column("permit")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Permit { get; set; }
        [Column("deny")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Deny { get; set; }
        [Column("secret")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Secret { get; set; }
        [Column("md5secret")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Md5secret { get; set; }
        [Column("remotesecret")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Remotesecret { get; set; }
        [Column("transport")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Transport { get; set; }
        [Column("dtmfmode")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Dtmfmode { get; set; }
        [Column("directmedia")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Directmedia { get; set; }
        [Column("nat")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Nat { get; set; }
        [Column("callgroup")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Callgroup { get; set; }
        [Column("pickupgroup")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Pickupgroup { get; set; }
        [Column("language")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Language { get; set; }
        [Column("allow")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Allow { get; set; }
        [Column("disallow")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Disallow { get; set; }
        [Column("insecure")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Insecure { get; set; }
        [Column("trustrpid")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Trustrpid { get; set; }
        [Column("progressinband")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Progressinband { get; set; }
        [Column("promiscredir")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Promiscredir { get; set; }
        [Column("useclientcode")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Useclientcode { get; set; }
        [Column("accountcode")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Accountcode { get; set; }
        [Column("setvar")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Setvar { get; set; }
        [Column("callerid")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Callerid { get; set; }
        [Column("amaflags")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Amaflags { get; set; }
        [Column("callcounter")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Callcounter { get; set; }
        [Column("busylevel")]
        public int? Busylevel { get; set; }
        [Column("allowoverlap")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Allowoverlap { get; set; }
        [Column("allowsubscribe")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Allowsubscribe { get; set; }
        [Column("videosupport")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Videosupport { get; set; }
        [Column("maxcallbitrate")]
        public int? Maxcallbitrate { get; set; }
        [Column("rfc2833compensate")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Rfc2833compensate { get; set; }
        [Column("mailbox")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Mailbox { get; set; }
        [Column("session-timers")]
        [StringLength(100)]
        [Unicode(false)]
        public string? SessionTimers { get; set; }
        [Column("session-expires")]
        public int? SessionExpires { get; set; }
        [Column("session-minse")]
        public int? SessionMinse { get; set; }
        [Column("session-refresher")]
        [StringLength(100)]
        [Unicode(false)]
        public string? SessionRefresher { get; set; }
        [Column("t38pt_usertpsource")]
        [StringLength(40)]
        [Unicode(false)]
        public string? T38ptUsertpsource { get; set; }
        [Column("regexten")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Regexten { get; set; }
        [Column("fromdomain")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Fromdomain { get; set; }
        [Column("fromuser")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Fromuser { get; set; }
        [Column("qualify")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Qualify { get; set; }
        [Column("defaultip")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Defaultip { get; set; }
        [Column("rtptimeout")]
        public int? Rtptimeout { get; set; }
        [Column("rtpholdtimeout")]
        public int? Rtpholdtimeout { get; set; }
        [Column("sendrpid")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Sendrpid { get; set; }
        [Column("outboundproxy")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Outboundproxy { get; set; }
        [Column("callbackextension")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Callbackextension { get; set; }
        [Column("timert1")]
        public int? Timert1 { get; set; }
        [Column("timerb")]
        public int? Timerb { get; set; }
        [Column("qualifyfreq")]
        public int? Qualifyfreq { get; set; }
        [Column("constantssrc")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Constantssrc { get; set; }
        [Column("contactpermit")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Contactpermit { get; set; }
        [Column("contactdeny")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Contactdeny { get; set; }
        [Column("usereqphone")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Usereqphone { get; set; }
        [Column("textsupport")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Textsupport { get; set; }
        [Column("faxdetect")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Faxdetect { get; set; }
        [Column("buggymwi")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Buggymwi { get; set; }
        [Column("auth")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Auth { get; set; }
        [Column("fullname")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Fullname { get; set; }
        [Column("trunkname")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Trunkname { get; set; }
        [Column("cid_number")]
        [StringLength(40)]
        [Unicode(false)]
        public string? CidNumber { get; set; }
        [Column("callingpres")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Callingpres { get; set; }
        [Column("mohinterpret")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Mohinterpret { get; set; }
        [Column("mohsuggest")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Mohsuggest { get; set; }
        [Column("parkinglot")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Parkinglot { get; set; }
        [Column("hasvoicemail")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Hasvoicemail { get; set; }
        [Column("subscribemwi")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Subscribemwi { get; set; }
        [Column("vmexten")]
        [StringLength(40)]
        [Unicode(false)]
        public string? Vmexten { get; set; }
        [Column("autoframing")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Autoframing { get; set; }
        [Column("rtpkeepalive")]
        public int? Rtpkeepalive { get; set; }
        [Column("call-limit")]
        public int? CallLimit { get; set; }
        [Column("g726nonstandard")]
        [StringLength(100)]
        [Unicode(false)]
        public string? G726nonstandard { get; set; }
        [Column("ignoresdpversion")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Ignoresdpversion { get; set; }
        [Column("allowtransfer")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Allowtransfer { get; set; }
        [Column("dynamic")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Dynamic { get; set; }
        [Column("corpid")]
        public Guid? Corpid { get; set; }
        [Column("extension")]
        [StringLength(50)]
        public string? Extension { get; set; }
        [Column("isregister")]
        public bool Isregister { get; set; }
        [Column("ispeertopeer")]
        public bool Ispeertopeer { get; set; }
        [Column("prefix")]
        [StringLength(10)]
        public string? Prefix { get; set; }
        [Column("prefix_national")]
        [StringLength(10)]
        public string? PrefixNational { get; set; }
        [Column("extensions_fix")]
        public string? ExtensionsFix { get; set; }
        [Column("extensions_outound_fix")]
        public string? ExtensionsOutoundFix { get; set; }
        [Column("outbound_extension")]
        [StringLength(50)]
        public string? OutboundExtension { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

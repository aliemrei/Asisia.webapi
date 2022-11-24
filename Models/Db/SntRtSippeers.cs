using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntRtSippeers : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Swid { get; set; }
        public Guid Uid { get; set; }
        public string Name { get; set; } = null!;
        public string? Ipaddr { get; set; }
        public int? Port { get; set; }
        public int? Regseconds { get; set; }
        public string? Defaultuser { get; set; }
        public string? Fullcontact { get; set; }
        public string? Regserver { get; set; }
        public string? Useragent { get; set; }
        public int? Lastms { get; set; }
        public string? Host { get; set; }
        public string? Type { get; set; }
        public string? Context { get; set; }
        public string? Permit { get; set; }
        public string? Deny { get; set; }
        public string? Secret { get; set; }
        public string? Md5secret { get; set; }
        public string? Remotesecret { get; set; }
        public string? Transport { get; set; }
        public string? Dtmfmode { get; set; }
        public string? Directmedia { get; set; }
        public string? Nat { get; set; }
        public string? Callgroup { get; set; }
        public string? Pickupgroup { get; set; }
        public string? Language { get; set; }
        public string? Allow { get; set; }
        public string? Disallow { get; set; }
        public string? Insecure { get; set; }
        public string? Trustrpid { get; set; }
        public string? Progressinband { get; set; }
        public string? Promiscredir { get; set; }
        public string? Useclientcode { get; set; }
        public string? Accountcode { get; set; }
        public string? Setvar { get; set; }
        public string? Callerid { get; set; }
        public string? Amaflags { get; set; }
        public string? Callcounter { get; set; }
        public int? Busylevel { get; set; }
        public string? Allowoverlap { get; set; }
        public string? Allowsubscribe { get; set; }
        public string? Videosupport { get; set; }
        public int? Maxcallbitrate { get; set; }
        public string? Rfc2833compensate { get; set; }
        public string? Mailbox { get; set; }
        public string? SessionTimers { get; set; }
        public int? SessionExpires { get; set; }
        public int? SessionMinse { get; set; }
        public string? SessionRefresher { get; set; }
        public string? T38ptUsertpsource { get; set; }
        public string? Regexten { get; set; }
        public string? Fromdomain { get; set; }
        public string? Fromuser { get; set; }
        public string? Qualify { get; set; }
        public string? Defaultip { get; set; }
        public int? Rtptimeout { get; set; }
        public int? Rtpholdtimeout { get; set; }
        public string? Sendrpid { get; set; }
        public string? Outboundproxy { get; set; }
        public string? Callbackextension { get; set; }
        public int? Timert1 { get; set; }
        public int? Timerb { get; set; }
        public int? Qualifyfreq { get; set; }
        public string? Constantssrc { get; set; }
        public string? Contactpermit { get; set; }
        public string? Contactdeny { get; set; }
        public string? Usereqphone { get; set; }
        public string? Textsupport { get; set; }
        public string? Faxdetect { get; set; }
        public string? Buggymwi { get; set; }
        public string? Auth { get; set; }
        public string? Fullname { get; set; }
        public string? Trunkname { get; set; }
        public string? CidNumber { get; set; }
        public string? Callingpres { get; set; }
        public string? Mohinterpret { get; set; }
        public string? Mohsuggest { get; set; }
        public string? Parkinglot { get; set; }
        public string? Hasvoicemail { get; set; }
        public string? Subscribemwi { get; set; }
        public string? Vmexten { get; set; }
        public string? Autoframing { get; set; }
        public int? Rtpkeepalive { get; set; }
        public int? CallLimit { get; set; }
        public string? G726nonstandard { get; set; }
        public string? Ignoresdpversion { get; set; }
        public string? Allowtransfer { get; set; }
        public string? Dynamic { get; set; }
        public Guid? Corpid { get; set; }
        public string? Extension { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

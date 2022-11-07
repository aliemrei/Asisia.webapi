using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_SIPPEERS : EntityBase // My Handlebars Helper
    {
        public int id { get; set; }
        public Guid swid { get; set; }
        public Guid uid { get; set; }
        public string name { get; set; } = null!;
        public string? ipaddr { get; set; }
        public int? port { get; set; }
        public int? regseconds { get; set; }
        public string? defaultuser { get; set; }
        public string? fullcontact { get; set; }
        public string? regserver { get; set; }
        public string? useragent { get; set; }
        public int? lastms { get; set; }
        public string? host { get; set; }
        public string? type { get; set; }
        public string? context { get; set; }
        public string? permit { get; set; }
        public string? deny { get; set; }
        public string? secret { get; set; }
        public string? md5secret { get; set; }
        public string? remotesecret { get; set; }
        public string? transport { get; set; }
        public string? dtmfmode { get; set; }
        public string? directmedia { get; set; }
        public string? nat { get; set; }
        public string? callgroup { get; set; }
        public string? pickupgroup { get; set; }
        public string? language { get; set; }
        public string? allow { get; set; }
        public string? disallow { get; set; }
        public string? insecure { get; set; }
        public string? trustrpid { get; set; }
        public string? progressinband { get; set; }
        public string? promiscredir { get; set; }
        public string? useclientcode { get; set; }
        public string? accountcode { get; set; }
        public string? setvar { get; set; }
        public string? callerid { get; set; }
        public string? amaflags { get; set; }
        public string? callcounter { get; set; }
        public int? busylevel { get; set; }
        public string? allowoverlap { get; set; }
        public string? allowsubscribe { get; set; }
        public string? videosupport { get; set; }
        public int? maxcallbitrate { get; set; }
        public string? rfc2833compensate { get; set; }
        public string? mailbox { get; set; }
        public string? session_timers { get; set; }
        public int? session_expires { get; set; }
        public int? session_minse { get; set; }
        public string? session_refresher { get; set; }
        public string? t38pt_usertpsource { get; set; }
        public string? regexten { get; set; }
        public string? fromdomain { get; set; }
        public string? fromuser { get; set; }
        public string? qualify { get; set; }
        public string? defaultip { get; set; }
        public int? rtptimeout { get; set; }
        public int? rtpholdtimeout { get; set; }
        public string? sendrpid { get; set; }
        public string? outboundproxy { get; set; }
        public string? callbackextension { get; set; }
        public int? timert1 { get; set; }
        public int? timerb { get; set; }
        public int? qualifyfreq { get; set; }
        public string? constantssrc { get; set; }
        public string? contactpermit { get; set; }
        public string? contactdeny { get; set; }
        public string? usereqphone { get; set; }
        public string? textsupport { get; set; }
        public string? faxdetect { get; set; }
        public string? buggymwi { get; set; }
        public string? auth { get; set; }
        public string? fullname { get; set; }
        public string? trunkname { get; set; }
        public string? cid_number { get; set; }
        public string? callingpres { get; set; }
        public string? mohinterpret { get; set; }
        public string? mohsuggest { get; set; }
        public string? parkinglot { get; set; }
        public string? hasvoicemail { get; set; }
        public string? subscribemwi { get; set; }
        public string? vmexten { get; set; }
        public string? autoframing { get; set; }
        public int? rtpkeepalive { get; set; }
        public int? call_limit { get; set; }
        public string? g726nonstandard { get; set; }
        public string? ignoresdpversion { get; set; }
        public string? allowtransfer { get; set; }
        public string? dynamic { get; set; }
        public Guid? corpid { get; set; }
        public string? extension { get; set; }
        public bool isregister { get; set; }
        public bool ispeertopeer { get; set; }
        public string? prefix { get; set; }
        public string? prefix_national { get; set; }
        public string? extensions_fix { get; set; }
        public string? extensions_outound_fix { get; set; }
        public string? outbound_extension { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}

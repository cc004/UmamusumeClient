using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Umamusume.Model
{
    [JsonObject]
    public class ExtraData
    {
        public Dictionary<int, int> support_cards = new Dictionary<int, int>();
        public string password;
    }
    [JsonObject]
    public class Account
    {
        public Account(Guid udid)
        {
            Udid = udid;
        }

        public Account() : this(Guid.NewGuid()) { }

        public Guid Udid { get; set; }
        public long ViewerId { get; set; }
        [JsonIgnore]
        public string SessionId => Utils.Bin2Hex(Utils.MakeMd5($"{ViewerId}{Udid}"));
        public string Authkey { get; set; } = null;
        public ExtraData extra = new ExtraData();
    }
}

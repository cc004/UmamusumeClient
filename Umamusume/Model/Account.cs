using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Umamusume.Model
{
    [JsonObject]
    public class ExtraData
    {
        public HashSet<string> support_cards = new HashSet<string>();
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
        public int ViewerId { get; set; }
        [JsonIgnore]
        public string SessionId => Utils.Bin2Hex(Utils.MakeMd5($"{ViewerId}{Udid}"));
        public string Authkey { get; set; } = null;
        public ExtraData extra = new ExtraData();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Umamusume.Model
{
    public class AccountContext : DbContext
    {
        public static AccountContext context = new AccountContext();

        public DbSet<DBAccount> Account { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=accounts.db");
    }

    public class DBAccount
    {
        public int id { get; set; }
        public string udid { get; set; }
        public string authkey { get; set; }
        public string password { get; set; }
        public string cards { get; set; }
        public int cardnum { get; set; }
        public int viewer_id { get; set; }

    }
}

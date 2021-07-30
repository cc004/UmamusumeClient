using System;
using System.Collections.Generic;
using System.IO;
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
        {
            var sql = File.ReadAllText("sqlstring.txt");
            if (sql.StartsWith("sqlite:")) options.UseSqlite(sql.Substring(7));
            if (sql.StartsWith("mysql:")) options.UseMySQL(sql.Substring(6));
        }
    }

    public class DBAccount
    {
        public int id { get; set; }
        public string udid { get; set; }
        public string authkey { get; set; }
        public string password { get; set; }
        public string cards { get; set; }
        public int cardnum { get; set; }
        public long viewer_id { get; set; }

    }
}

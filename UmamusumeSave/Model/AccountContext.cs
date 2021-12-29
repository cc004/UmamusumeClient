using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UmamusumeSave.Model
{
    public class AccountNewContext : DbContext
    {
        public static AccountNewContext context = new AccountNewContext();

        public DbSet<DBAccountNew> Account { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=accounts_new.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBAccountNew>().ToTable("accounts").HasKey(e => e.viewer_id);
        }
    }

    public class AccountOldContext : DbContext
    {
        public static AccountOldContext context = new AccountOldContext();
        
        public DbSet<DBAccountOld> Account { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=accounts_old.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBAccountOld>().ToTable("accounts").HasKey(e => e.viewer_id);
        }
    }

    public class DBAccountOld
    {
        public string password { get; set; }
        public long viewer_id { get; set; }

    }
    public class DBAccountNew
    {
        public string udid { get; set; }
        public string authkey { get; set; }
        public string password { get; set; }
        public long viewer_id { get; set; }

    }
}

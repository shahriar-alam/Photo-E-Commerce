using ECEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRepository
{
    public class ECDBContext : DbContext
    {
        public DbSet<Stash> stashes { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Login> logins { get; set; }
        public DbSet<Transaction> transactions { get; set; }

        public System.Data.Entity.DbSet<ECEntity.UserStashData> UserStashDatas { get; set; }
    }
}

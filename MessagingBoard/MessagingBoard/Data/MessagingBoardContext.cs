using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MessagingBoard.Data
{
    public class MessagingBoardContext : DbContext
    {
        public MessagingBoardContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<MessagingBoardContext, MessageBoardMigrationsConfiguration>()
                );
        }
        public DbSet<Topic> Topiks { get; set; }
        public DbSet<Reply> Replys { get; set; }
    }
}
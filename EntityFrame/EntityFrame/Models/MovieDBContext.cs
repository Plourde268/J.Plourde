using EntityFrame.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrame.Models
{
    //Connection to the database
    public class MovieDBContext : DbContext
    {
        static MovieDBContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieDBContext, Configuration>());
        }
        public IDbSet<Movie> Movies { get; set; }
    }
}
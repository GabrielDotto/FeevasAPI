using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace FeevasApi.Models
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Direitos> Direitos { get; set; }
        public DbSet<Log> Log { get; set; }

        public Context() : base(ConfigurationManager.ConnectionStrings["Context"].ConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
    }
}
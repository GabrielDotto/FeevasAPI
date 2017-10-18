using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FeevasApi.Models
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Direitos> Direitos { get; set; }
        public DbSet<Log> Log { get; set; }

    }
}
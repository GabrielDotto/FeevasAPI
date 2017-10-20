using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using trabalho1.Models;

namespace trabalho1.Repo
{
    public class LogRepo : IDisposable
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public void Create(Log log)
        {
            var user = db.Users.Find(log.Usuario.Id);

            log.Usuario = user;

            db.Logs.Add(log);
            db.SaveChanges();
        }

        public Log FindById(long id)
        {
            return db.Logs.FirstOrDefault(x => x.Id == id);
        }

        public List<Log> FindByUsuario(string user)
        {
            return db.Logs.Where(x => x.Usuario.UserName == user).ToList();
        }

        public List<Log> List()
        {
            return db.Logs.ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
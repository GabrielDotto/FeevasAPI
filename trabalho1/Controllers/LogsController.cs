using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using trabalho1.Models;
using trabalho1.Repo;

namespace trabalho1.Controllers
{
    public class LogsController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        private LogRepo _logRepo = new LogRepo();

        public LogsController()
        {

        }

        // GET: Logs
        public ActionResult Index(string user)
        {
            var logList = _logRepo.List();
            if (User.IsInRole("User"))
            {
               logList = db.Logs.Where(x => x.Usuario.UserName == User.Identity.Name).ToList();
                return View(logList); 
            }
            if (!string.IsNullOrWhiteSpace(user))
            {
                logList = logList.Where(x => x.Usuario.UserName == user).ToList();
            }

            return View(logList);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

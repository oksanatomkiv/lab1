using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        Lab6Context db = new Lab6Context();

        public ActionResult Index()
        {

            IEnumerable<Users> users = db.Users;
            ViewBag.Users = users;
            return View();
        }
        [HttpGet]
        public ActionResult AddUsers(int id = 0)
        {
            ViewBag.UserId = id;
            return View();
        }
        [HttpPost]
        public void AddUsers(Users users)
        {
            db.Users.Add(users);
            db.SaveChanges();
            Response.Redirect("/Home");
        }

        public ActionResult RemoveUsers(int UserId = 0)
        {
            if (UserId > 0)
            {
                db.Users.Remove(db.Users.Where(x => x.UserId == UserId).FirstOrDefault());
                db.SaveChanges();
            }
            Response.Redirect("/Home");
            return View();
        }

        [HttpGet]
        public ActionResult EditUsers(int UserId = 0)
        {
            ViewBag.UserId = UserId;
            Users users = db.Users
                .Where(o => o.UserId == UserId)
                .FirstOrDefault();

            ViewBag.name = users.Name;
            ViewBag.userage = users.UserAge;
            return View();
        }
        [HttpPost]
        public void EditUsers(Users users)
        {
            Users user_update = db.Users
                .Where(o => o.UserId == users.UserId)
                .FirstOrDefault();

            user_update.Name = users.Name;
            user_update.UserAge = users.UserAge;

            db.SaveChanges();
            Response.Redirect("/Home");
        }
    }


}
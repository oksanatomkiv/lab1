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


    }
}
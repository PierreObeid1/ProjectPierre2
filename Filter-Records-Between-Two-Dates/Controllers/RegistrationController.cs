using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filter_Records_Between_Two_Dates.Models;

namespace Filter_Records_Between_Two_Dates.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User obj)

        {
            if (ModelState.IsValid)
            {
                Sample1Entities26 db = new Sample1Entities26();
                db.Users.Add(obj);
                db.SaveChanges();
            }
                return View(obj);
            
      
        }
    }
}
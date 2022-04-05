using Filter_Records_Between_Two_Dates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter_Records_Between_Two_Dates.Controllers
{
    public class DatesController : Controller
    {
        public Sample1Entities26 db = new Sample1Entities26();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(int value)
        {

            return PartialView(db.User2.Where(x => x.seel_code == value).ToList());

        }

    }
}
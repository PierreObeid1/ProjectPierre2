using Filter_Records_Between_Two_Dates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter_Records_Between_Two_Dates.Controllers
{
    public class CustomerSearchController : Controller
    {
        // GET: CustomerSearch    
            public ActionResult Index(string search)
            {
            Sample1Entities26 sd = new Sample1Entities26();
            List<Customer> customers = sd.Customers.ToList();
                return View(sd.Customers.Where(x=>x.Seel_code.StartsWith(search) || search==null).ToList());
            }
    }
  
}
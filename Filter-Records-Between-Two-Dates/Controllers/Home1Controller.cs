using Filter_Records_Between_Two_Dates.Models;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Filter_Records_Between_Two_Dates.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public bool loginWithActiveDirectory(string Email,string Password)
        {
            bool ret = false;

            if (Email == null || Password == null) return false;


            try

            {
                DirectoryEntry de = new DirectoryEntry("LDAP://eg.methode-emea.local", Email,Password);

                DirectorySearcher SearchResultresults = new DirectorySearcher(de);

                SearchResult results = null;
                


                results = SearchResultresults.FindOne();

                

                ret = true;

            }

            catch

            {

                ret = false;

            }
            return ret;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User u)
        {
            // this action is for handle post (login)
            if (ModelState.IsValid) // this is check validity
            {

                if (loginWithActiveDirectory(u.Email, u.Password))
                {
                    if (u.Email == "Pierre.Obeid@samaya-electronics.com")
                    return RedirectToAction("AfterLogin");
                    if (u.Email == "Pierrefffff.Obeid@samaya-electronics.com")
                        return RedirectToAction("AfterLogin2");
                }
                 
            }

            return View(u);
        }
        public ActionResult AfterLogin()
        {
            if (Session["LogedUserID"] != null)
            {
                return RedirectToAction("Index", "CustomerSearch");

            }
            else
            {
                return RedirectToAction("Index", "CustomerSearch");
            }
        }
        public ActionResult AfterLogin2()
        {
            if (Session["LogedUserID"] != null)
            {
                return RedirectToAction("Index", "DateSearch");

            }
            else
            {
                return RedirectToAction("Index", "DateSearch");
            }
        }



    }
}
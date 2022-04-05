using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filter_Records_Between_Two_Dates.Models;


namespace Filter_Records_Between_Two_Dates.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Sample1Entities26 db = new Sample1Entities26();
            ViewModel_Registration rg = new ViewModel_Registration();
            rg.Genders_samaya = db.Genders_samaya.Take(5).ToList<Genders_samaya>();
            rg.Positions_samaya = db.Positions_samaya.Take(5).ToList<Positions_samaya>();
            rg.Departments_samaya = db.Departments_samaya.Take(10).ToList<Departments_samaya>();
            rg.Shirts_samaya = db.Shirts_samaya.Take(5).ToList<Shirts_samaya>();
            rg.T_Shirt_Samaya = db.T_shirt_samaya.Take(5).ToList<T_shirt_samaya>();
            rg.Business_card = db.Business_Card.Take(2).ToList<Business_Card>();
            rg.Medical_insurance_card = db.Medical_Insurance_Card.Take(2).ToList<Medical_Insurance_Card>();
            rg.Hijab_Cap = db.Hijab_Cap.Take(3).ToList<Hijab_Cap>();
            rg.Safety_Shoes = db.Safety_Shoes.Take(6).ToList<Safety_Shoes>();
      

            return View(rg);
        }
   
        [HttpPost]
        public ActionResult Index(ViewModel_Registration rg)
        {

            Sample1Entities26 db = new Sample1Entities26();
            Customer obj_customer = new Customer();

            obj_customer.Seel_code = rg.Seel_code;
            obj_customer.Dates = rg.Dates;
    

            var listGenders = rg.Genders_samaya.Where(x => x.isChecked == true).ToList<Genders_samaya>();
            var result = Content(String.Join(",", listGenders.Select(x => x.Gender)));
            obj_customer.Genders = result.Content.ToString();



            var listPositions = rg.Positions_samaya.Where(x => x.isChecked == true).ToList<Positions_samaya>();
            var result1 = Content(String.Join(",", listPositions.Select(x => x.Position)));
            obj_customer.Positions = result1.Content.ToString();

            var listDepartments = rg.Departments_samaya.Where(x => x.isChecked == true).ToList<Departments_samaya>();
            var result2 = Content(String.Join(",", listDepartments.Select(x => x.Department)));
            obj_customer.Departments = result2.Content.ToString();

            var listShirts = rg.Shirts_samaya.Where(x => x.isChecked == true).ToList<Shirts_samaya>();
            var result3 = Content(String.Join(",", listShirts.Select(x => x.Shirt)));
            obj_customer.Shirts = result3.Content.ToString();

            var listT_shirt_samaya = rg.T_Shirt_Samaya.Where(x => x.isChecked == true).ToList<T_shirt_samaya>();
            var result4 = Content(String.Join(",", listT_shirt_samaya.Select(x => x.T_Shirt)));
            obj_customer.T_Shirts = result4.Content.ToString();

            var listBusiness_Card = rg.Business_card.Where(x => x.isChecked == true).ToList<Business_Card>();
            var result5 = Content(String.Join(",", listBusiness_Card.Select(x => x.Business)));
            obj_customer.Business_card = result5.Content.ToString();

            var listMedical_insurance_card = rg.Medical_insurance_card.Where(x => x.isChecked == true).ToList<Medical_Insurance_Card>();
            var result6 = Content(String.Join(",", listMedical_insurance_card.Select(x => x.Insurance)));
            obj_customer.Medical_insurance_card = result6.Content.ToString();

            var listHijab_Cap = rg.Hijab_Cap.Where(x => x.isChecked == true).ToList<Hijab_Cap>();
            var result7 = Content(String.Join(",", listHijab_Cap.Select(x => x.Hijab)));
            obj_customer.Hijab = result7.Content.ToString();

            var listSafety_Shoes = rg.Safety_Shoes.Where(x => x.isChecked == true).ToList<Safety_Shoes>();
            var result8 = Content(String.Join(",", listSafety_Shoes.Select(x => x.Safety)));
            obj_customer.Safety_Shoes = result8.Content.ToString();



         



            db.Customers.Add(obj_customer);


            db.SaveChanges();


            return RedirectToAction("Index", "home");


        }

        private List<SelectListItem> populateclass()
        {
            var selectList = new List<SelectListItem>();
            Sample1Entities26 db = new Sample1Entities26();
            var result = db.Customers.ToList();


            foreach (var item in result)
            {
                selectList.Add(new SelectListItem
                {
                    Value = item.id.ToString(),
                    Text = item.Seel_code,


                });

            }
            return selectList;


        }


    }

}
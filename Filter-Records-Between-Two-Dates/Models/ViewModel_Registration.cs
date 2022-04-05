using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filter_Records_Between_Two_Dates.Models
{
    public class ViewModel_Registration
    {
        

        public string Seel_code { get; set; }


        public DateTime Dates { get; set; }
        public List<Genders_samaya> Genders_samaya { get; set; }
        public List<Departments_samaya> Departments_samaya { get; set; }
        public List<Positions_samaya> Positions_samaya { get; set; }
        public List<Shirts_samaya> Shirts_samaya { get; set; }

        public List<T_shirt_samaya> T_Shirt_Samaya { get; set; }
        public List<Business_Card> Business_card { get; set; }
        public List<Medical_Insurance_Card> Medical_insurance_card { get; set; }
        public List<Hijab_Cap> Hijab_Cap { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Safety_Shoes> Safety_Shoes { get; set; }
        

    }
 

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filter_Records_Between_Two_Dates.Models
{
    public class Model
    {
        public string Seel_code { get; set; }
        public string Genders { get; set; }
        public string Positions { get; set; }
        public string Departments { get; set; }
        public string Shirts { get; set; }
        public string Colors { get; set; }
        public DateTime dates { get; set; }
    }
}
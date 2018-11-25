using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnicalTest.Models
{
    public class Member
    {
        public int memberNumber { get; set; } = 0;
        public string forename { get; set; } = "";
        public string surname { get; set; } = "";
        public List<Products> products { get; set; }
    }
    
    public class Products
    {
        public string name { get; set; } = "";
        public int cost { get; set; } = 0;
    }
}
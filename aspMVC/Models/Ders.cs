using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspMVC.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Egitmen { get; set; }
        public int Kredi { get; set; }
    }
}
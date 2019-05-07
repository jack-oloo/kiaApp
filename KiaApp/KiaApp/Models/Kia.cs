using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiaApp.Models
{
    public class Kia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
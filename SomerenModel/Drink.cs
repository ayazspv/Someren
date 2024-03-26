using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int DrinkNumber { get; set; } 
        public string DrinkName { get; set; }
        public double VAT { get; set; }
        public string IsAlcoholic { get; set; }
        public double Price { get; set; }   
        public int Stock { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Orders
    {
        public int StudentNumber { get; set; }
        public int DrinkNumber { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; }
    }
}

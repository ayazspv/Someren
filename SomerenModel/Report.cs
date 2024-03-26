using System;

namespace SomerenModel
{
    public class Report
    {
        public int DrinksAmount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchasedTime { get; set; }
        public override string ToString()
        {
            return $"{DrinksAmount} {TotalPrice} {PurchasedTime}";
        }
    }
}
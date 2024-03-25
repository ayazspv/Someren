using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class OrdersService
    {
        private OrdersDao ordersdb;

        public OrdersService()
        {
            ordersdb = new OrdersDao();
        }

        public void AddDrinkSale(Orders order)
        {
            ordersdb.AddOrder(order.StudentNumber, order.DrinkNumber, order.Quantity, order.TotalPrice, order.PurchaseDateTime);
        }

    }
}

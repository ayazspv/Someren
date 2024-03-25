using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }
        public List<Drink> GetDrink()
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
        // Method to update the stock of a drink
        public void UpdateDrinkStock(int drinkNumber, int newStock)
        {
            try
            {
                // Call the appropriate method from the DrinkDao to update the stock
                drinkdb.UpdateDrinkStock(drinkNumber, newStock);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating drink stock: " + ex.Message);
                throw;
            }
        }
    }
}

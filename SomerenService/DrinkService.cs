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
        public DrinkDao Drinkdb;

        public DrinkService()
        {
            Drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = Drinkdb.GetAllDrinks();
            return drinks;
        }
    }
}


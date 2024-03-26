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

        public void AddDrink(int drinkNumber, string drinkName, double VAT, string IsAlscholic,double price,int Stock)
        {
            // Create a Drink object using the user input
            Drink newDrink = new Drink
            {
               DrinkNumber  = drinkNumber,
                DrinkName = drinkName,
                VAT = VAT,
                IsAlcoholic = IsAlscholic,  
                Price = price,  
                Stock = Stock   
            };

            // Calling the method from DrinkDao to insert the Drink object into the database
            Drinkdb.InsertDrink(newDrink);
        }

     
        }


    }


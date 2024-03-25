// DrinkDAO.cs
using SomerenModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT [Drink Number], [Name], [VAT], [Is_Alcoholic], [Price], [Stock] FROM drink";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkNumber = (int)dr["Drink Number"],
                    Name = dr["Name"].ToString(),
                    VAT = (double)dr["VAT"],
                    IsAlcoholic = (bool)dr["Is_Alcoholic"],
                    Price = (double)dr["Price"],
                    Stock = (int)dr["Stock"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
        public void UpdateDrinkStock(int drinkNumber, int newStock)
        {
            string query = "UPDATE drink SET Stock = @NewStock WHERE [Drink Number] = @DrinkNumber";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NewStock", newStock),
                new SqlParameter("@DrinkNumber", drinkNumber)
            };

            ExecuteEditQuery(query, parameters);
        }

    }
}

using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        // Method to retrieve all drinks from the database
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT [Drink Number], [Name], [VAT], [Is_Alcoholic], [Price], [Stock] FROM drink";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            // Convert the DataTable to a list of Drinks objects
            return ReadTables(dataTable);
        }

        // Method to convert DataTable to a list of Drinks objects
        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            // Loop through each row in the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkNumber = (int)(dr["Drink Number"]),
                    DrinkName = dr["Name"].ToString(),
                    VAT = Convert.ToDouble(dr["VAT"]),
                    IsAlcoholic = (bool)(dr["Is_Alcoholic"]),
                    Price = Convert.ToDouble(dr["Price"]),
                    Stock = Convert.ToInt32(dr["Stock"])
                };

                // Add the Drinks object to the list
                drinks.Add(drink);
            }

            // Return the list of drinks
            return drinks;
        }
    }
}

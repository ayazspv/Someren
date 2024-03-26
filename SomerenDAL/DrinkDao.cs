using SomerenModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public void InsertDrink(Drink drink)
        {
            string query = "INSERT INTO [Drink] ([Drink Number], [Name], [VAT], [Is_Alcoholic], [Price], [Stock]) " +
                           "VALUES (@DrinkNumber, @Name, @VAT, @IsAlcoholic, @Price, @Stock)";

            
            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@DrinkNumber", SqlDbType.Int) { Value = drink.DrinkNumber};
            sqlParameters[1] = new SqlParameter("@Name", SqlDbType.VarChar) { Value = drink.DrinkName };
            sqlParameters[2] = new SqlParameter("@VAT", SqlDbType.Float) { Value = drink.VAT };
            sqlParameters[3] = new SqlParameter("@IsAlcoholic", SqlDbType.VarChar) { Value = drink.IsAlcoholic };
            sqlParameters[4] = new SqlParameter("@Price", SqlDbType.Float) { Value = drink.Price };
            sqlParameters[5] = new SqlParameter("@Stock", SqlDbType.Int) { Value = drink.Stock };

            ExecuteEditQuery(query,sqlParameters);

        }

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
                    IsAlcoholic = dr["Is_Alcoholic"].ToString(),
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
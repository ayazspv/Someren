using SomerenModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class OrdersDao : BaseDao
    {
        public void AddOrder(int studentNumber, int drinkNumber, int quantity, double totalPrice, DateTime purchaseDateTime)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("InsertOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters required by the stored procedure
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@DrinkNumber", drinkNumber);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    command.Parameters.AddWithValue("@PurchaseDateTime", purchaseDateTime); // Corrected parameter name

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {
        // Method to retrieve all lecturers from the database
        public List<Lecturer> GetAllLecturers()
        {
            // SQL query to select all lecturer data from the database
            string query = "SELECT [Lecturer Number], [First Name], [Last Name], [Telephone Number], [Age], [Room Number] FROM lecturer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            // Convert the DataTable to a list of Lecturer objects
            return ReadTables(dataTable);
        }
        public List<Lecturer> GetByActivityNumber(int activityNumber)
        {
            // SQL query to select all lecturers associated with the provided activity number
            string query = "SELECT l.* FROM Lecturer l " +
                           "JOIN Supervisor s ON l.[Lecturer Number] = s.[Lecturer Number] " +
                           "WHERE s.[Activity Number] = @ActivityNumber";

            // Parameters for the query
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ActivityNumber", SqlDbType.Int);
            sqlParameters[0].Value = activityNumber;

            // Execute the query and retrieve data
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            // Convert the DataTable to a list of Lecturer objects
            return ReadTables(dataTable);
        }


        // Method to convert DataTable to a list of Lecturer objects
        private List<Lecturer> ReadTables(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            // Loop through each row in the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    LecturerNumber = (int)dr["Lecturer Number"],
                    FirstName = dr["First Name"].ToString(),
                    LastName = dr["Last Name"].ToString(),
                    Telephone = dr["Telephone Number"].ToString(),
                    Age = (int)dr["Age"],
                    RoomNumber = (int)dr["Room Number"]
                };

                // Add the Lecturer object to the list
                lecturers.Add(lecturer);
            }

            // Return the list of lecturers
            return lecturers;
        }


    }
}

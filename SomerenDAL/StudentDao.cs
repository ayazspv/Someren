using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT [Student Number], [First Name], [Last Name], [Telephone Number], [Class], [Room Number] FROM student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadStudentTables(ExecuteSelectQuery(query, sqlParameters));
        }

        // Method to fetch participating students by activity number
        public List<Student> GetByParticipantsNumber(int activityNumber)
        {
            // SQL query to select all students associated with the provided activity number
            string query = "SELECT s.* FROM student s " +
                           "JOIN participates_in p ON s.[Student Number] = p.[Student Number] " +
                           "WHERE p.[Activity Number] = @ActivityNumber";

            // Parameters for the query
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ActivityNumber", SqlDbType.Int);
            sqlParameters[0].Value = activityNumber;

            // Execute the query and retrieve data
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            // Convert the DataTable to a list of Student objects
            return ReadStudentTables(dataTable);
        }

        private List<Student> ReadStudentTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentNumber = (int)dr["Student Number"],
                    FirstName = dr["First Name"].ToString(),
                    LastName = dr["Last Name"].ToString(),
                    TelephoneNumber = dr["Telephone Number"].ToString(),
                    Class = dr["Class"].ToString(),
                    RoomNumber = (int)dr["Room Number"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao


    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT [Student Number], [First Name], [Last Name], [Telephone Number], [Class], [Room Number] FROM student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
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
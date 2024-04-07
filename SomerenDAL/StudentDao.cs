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

        public void AddStudent(Student student)
        {
            string query = "INSERT INTO student ([Student Number], [First Name], [Last Name], [Telephone Number], [Class], [Room Number]) " +
                           "VALUES (@StudentNumber, @FirstName, @LastName, @TelephoneNumber, @Class, @RoomNumber)";

            SqlParameter[] sqlParameters = new SqlParameter[6]
            {
                new SqlParameter("@StudentNumber", student.StudentNumber),
                new SqlParameter("@FirstName", student.FirstName),
                new SqlParameter("@LastName", student.LastName),
                new SqlParameter("@TelephoneNumber", student.TelephoneNumber),
                new SqlParameter("@Class", student.Class),
                new SqlParameter("@RoomNumber", student.RoomNumber)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateStudent(Student student)
        {
            string query = "UPDATE student SET [First Name] = @FirstName, [Last Name] = @LastName, " +
                           "[Telephone Number] = @TelephoneNumber, [Class] = @Class, [Room Number] = @RoomNumber " +
                           "WHERE [Student Number] = @StudentNumber";

            SqlParameter[] sqlParameters = new SqlParameter[6]
            {
                new SqlParameter("@FirstName", student.FirstName),
                new SqlParameter("@LastName", student.LastName),
                new SqlParameter("@TelephoneNumber", student.TelephoneNumber),
                new SqlParameter("@Class", student.Class),
                new SqlParameter("@RoomNumber", student.RoomNumber),
                new SqlParameter("@StudentNumber", student.StudentNumber)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteStudent(int studentNumber)
        {
            string query = "DELETE FROM student WHERE [Student Number] = @StudentNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@StudentNumber", studentNumber)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

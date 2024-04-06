using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class ParticipantsDao : BaseDao
    {

        public void RemoveStudentFromDatabase(int studentNumber, int activityNumber)
        {
            string query = "DELETE FROM participates_in WHERE [Student Number] = @StudentNumber AND [Activity Number] = @ActivityNumber";
            SqlParameter[] sqlParameters ={
        new SqlParameter("@StudentNumber", studentNumber),
        new SqlParameter("@ActivityNumber", activityNumber)
    };

            // Execute the SQL DELETE statement
            ExecuteEditQuery(query, sqlParameters);
        }


        public void AddStudentToDatabase(int studentNumber, int activityNumber)
        {
            string query = "INSERT INTO participates_in ([Student Number], [Activity Number]) VALUES (@StudentNumber, @ActivityNumber)";
            SqlParameter[] sqlParameters ={
        new SqlParameter("@StudentNumber", studentNumber),
        new SqlParameter("@ActivityNumber", activityNumber)
    };

            // Execute the SQL INSERT statement
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}

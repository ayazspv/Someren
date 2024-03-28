using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class SupervisorDao : BaseDao
    {

        public void RemoveSupervisorFromDatabase(int lecturerNumber, int activityNumber)
        {
            string query = "DELETE FROM supervisor WHERE [Lecturer Number] = @LecturerNumber AND [Activity Number] = @ActivityNumber";
            SqlParameter[] sqlParameters ={
        new SqlParameter("@LecturerNumber", lecturerNumber),
        new SqlParameter("@ActivityNumber", activityNumber)
    };

            // Execute the SQL DELETE statement
            ExecuteEditQuery(query, sqlParameters);
        }


        public void AddSupervisorToDatabase(int lecturerNumber, int activityNumber)
        {
            string query = "INSERT INTO supervisor ([Lecturer Number], [Activity Number]) VALUES (@LecturerNumber, @ActivityNumber)";
            SqlParameter[] sqlParameters ={
        new SqlParameter("@LecturerNumber", lecturerNumber),
        new SqlParameter("@ActivityNumber", activityNumber)
    };

            // Execute the SQL INSERT statement
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}


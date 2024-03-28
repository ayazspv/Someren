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
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT [Activity Number], [Name], [Start Time], [End Time] FROM activity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityNumber = (int)dr["Activity Number"],
                    ActivityName = dr["Name"].ToString(),
                    StartTime = (DateTime)dr["Start Time"],
                    EndTime = (DateTime)dr["End Time"]
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}

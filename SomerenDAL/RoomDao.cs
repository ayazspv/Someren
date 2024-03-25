using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT [Room Number], [Room Type], [Floor], [Number of beds] FROM room";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    RoomNumber = (int)dr["Room Number"],
                    RoomType = dr["Room Type"].ToString(),
                    Floor = (int)dr["Floor"],
                    NumberOfBeds = (int)dr["Number of beds"]
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
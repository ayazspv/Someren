using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class SupervisorService
    {
        private SupervisorDao supervisordb;

        public SupervisorService()
        {
            supervisordb = new SupervisorDao();
        }

        public void RemoveSupervisorFromDatabase(int lecturerNumber, int activityNumber)
        {
            supervisordb.RemoveSupervisorFromDatabase(lecturerNumber, activityNumber);
        }

        public void AddSupervisorToDatabase(int lecturerNumber, int activityNumber)
        {
            supervisordb.AddSupervisorToDatabase(lecturerNumber, activityNumber);
        } 
    }
}

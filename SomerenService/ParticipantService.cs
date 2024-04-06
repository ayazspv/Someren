using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ParticipantService
    {
        private ParticipantsDao participantsdb;

        public ParticipantService()
        {
            participantsdb = new ParticipantsDao();
        }

        public void DeleteParticipants(int studentNumber, int activityNumber)
        {
            participantsdb.RemoveStudentFromDatabase(studentNumber, activityNumber);
        }

        public void AddParticipants(int studentNumber, int activityNumber)
        {
            participantsdb.AddStudentToDatabase(studentNumber, activityNumber);
        }
    }
}
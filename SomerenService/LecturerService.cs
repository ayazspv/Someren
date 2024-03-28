using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class LecturerService
    {
        public LecturerDao lecturerdb;

        public LecturerService()
        {
            lecturerdb = new LecturerDao();
        }

        public List<Lecturer> GetLecturers()
        {
            List<Lecturer> lecturer = lecturerdb.GetAllLecturers();
            return lecturer;
        }

        public List<Lecturer> GetSupervisors(int activityNumber)
        {
            List<Lecturer> supervisor = lecturerdb.GetByActivityNumber(activityNumber);
            return supervisor;
        }
    }
}

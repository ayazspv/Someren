using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentDao;

        public StudentService()
        {
            studentDao = new StudentDao();
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = studentDao.GetAllStudents();
            return students;
        }

        public List<Student> GetStudentById(int activityNumber)
        {
            List<Student> students = studentDao.GetByParticipantsNumber(activityNumber);
            return students;
        }

        public void AddStudent(Student student)
        {
            studentDao.AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            studentDao.UpdateStudent(student);
        }

        public void DeleteStudent(int studentNumber)
        {
            studentDao.DeleteStudent(studentNumber);
        }
    }
}

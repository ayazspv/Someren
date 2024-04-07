using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class UpdateStudentForm : Form
    {

        private readonly StudentService studentService = new StudentService();
        private Student studentToUpdate;

        public UpdateStudentForm(Student student)
        {
            InitializeComponent();

            if (student != null)
            {
                studentToUpdate = student;
                txtStudentNumber.Text = student.StudentNumber.ToString();
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtTelephoneNumber.Text = student.TelephoneNumber;
                txtClass.Text = student.Class;
                txtRoomNumber.Text = student.RoomNumber.ToString();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int studentNumber = int.Parse(txtStudentNumber.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string telephoneNumber = txtTelephoneNumber.Text;
            string classValue = txtClass.Text;
            int roomNumber = int.Parse(txtRoomNumber.Text);

            Student newOrUpdateStudent = new Student
            {
                StudentNumber = studentNumber,
                FirstName = firstName,
                LastName = lastName,
                TelephoneNumber = telephoneNumber,
                Class = classValue,
                RoomNumber = roomNumber
            };

            if (studentToUpdate == null)
            {
                studentService.AddStudent(newOrUpdateStudent);
            }
            else
            {
                studentService.UpdateStudent(newOrUpdateStudent);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

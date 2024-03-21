using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }
        private void DisplayStudents(List<Student> students)
        {
            // Clear the listview before filling it
            listViewStudents.Items.Clear();

            // Configure the ListView to display items vertically
            listViewStudents.View = View.Details;

            // Add columns for each property
            listViewStudents.Columns.Clear();
            listViewStudents.Columns.Add("Student Number", 100);
            listViewStudents.Columns.Add("First Name", 100);
            listViewStudents.Columns.Add("Last Name", 100);
            listViewStudents.Columns.Add("Telephone Number", 100);
            listViewStudents.Columns.Add("Class", 100);
            listViewStudents.Columns.Add("Room Number", 100);

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(new string[]
                {
            student.StudentNumber.ToString(),
            student.FirstName,
            student.LastName,
            student.TelephoneNumber,
            student.Class,
            student.RoomNumber.ToString()
                });

                listViewStudents.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void pnlStudents_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
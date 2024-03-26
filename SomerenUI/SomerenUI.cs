using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using static System.Windows.Forms.LinkLabel;

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
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlDashboard.Show();
        }


        private void ShowStudentsPanel()
        {
            pnlDashboard.Hide();
            pnlLecturers.Hide();

            try
            {

                List<Student> students = GetStudents();

                DisplayStudents(students);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error loading students: " + ex.Message);
            }

            pnlStudents.Show();
        }


        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            return studentService.GetStudents();
        }


        private void DisplayStudents(List<Student> students)
        {
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.LastName);
                li.Tag = student;
                listViewStudents.Items.Add(li);
            }
        }

        // Method to show the lecturers panel
        private void ShowLecturerPanel()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            DrinkSuppliesPnl.Hide();
            pnlLecturers.Show();

            try
            {
                // Get the list of lecturers
                List<Lecturer> lecturers = GetLecturers();
                // Display the list of lecturers
                DisplayLecturers(lecturers);
            }
            catch (Exception ex)
            {
                // Display error message if there's an exception
                MessageBox.Show("Error loading lecturers: " + ex.Message);
            }

            pnlLecturers.Show();
        }

        // Method to get the list of lecturers from the service
        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            return lecturerService.GetLecturers();
        }

        // Method to display the list of lecturers in the ListView
        private void DisplayLecturers(List<Lecturer> lecturers)
        {
            listViewLecturers.Items.Clear();

            // Set ListView to display in details view
            listViewLecturers.View = View.Details;

            // Add columns to the ListView
            listViewLecturers.Columns.Clear();
            listViewLecturers.Columns.Add("Lecturer Number", 100);
            listViewLecturers.Columns.Add("First Name", 100);
            listViewLecturers.Columns.Add("Last Name", 100);
            listViewLecturers.Columns.Add("Telephone", 100);
            listViewLecturers.Columns.Add("Age", 100);
            listViewLecturers.Columns.Add("Room Number", 100);

            // Populate the ListView with lecturers
            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem li = new ListViewItem(new string[] {
                    lecturer.LecturerNumber.ToString(),
                    lecturer.FirstName,
                    lecturer.LastName,
                    lecturer.Telephone,
                    lecturer.Age.ToString(),
                    lecturer.RoomNumber.ToString()
                });
                li.Tag = lecturer;
                listViewLecturers.Items.Add(li);
            }
        }

        // Method to show the drinks panel
        private void ShowDrinksPanel()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlLecturers.Hide();

            DrinkSuppliesPnl.Show();

            try
            {
                // Get the list of drinks
                List<Drink> drinks = GetDrinks();
                // Display the list of drinks
                DisplayDrinks(drinks);
            }
            catch (Exception ex)
            {
                // Display error message if there's an exception
                MessageBox.Show("Error loading drinks: " + ex.Message);
            }
        }

        // Method to get the list of drinks from the service
        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            return drinkService.GetDrinks();
        }

        // Method to display the list of drinks in the ListView
        private void DisplayDrinks(List<Drink> drinks)
        {
            listViewDrinks.Items.Clear(); // Correct method name

            // Set ListView to display in details view
            listViewDrinks.View = View.Details;

            // Add columns to the ListView
            listViewDrinks.Columns.Clear();
            listViewDrinks.Columns.Add("Drink Number", 150);
            listViewDrinks.Columns.Add("Name", 100);
            listViewDrinks.Columns.Add("VAT", 100);
            listViewDrinks.Columns.Add("Is_Alcoholic", 100); // Correct column name
            listViewDrinks.Columns.Add("Price", 100);
            listViewDrinks.Columns.Add("Stock", 100);
            listViewDrinks.Columns.Add("Stock Status", 175);

            string drinkStatus;

            // Populate the ListView with drinks
            foreach (Drink drink in drinks)
            {
                // Look up the status of the stock

                ListViewItem li = new ListViewItem(new string[] {
                drink.DrinkNumber.ToString(),
                drink.DrinkName,
                drink.VAT.ToString(),
                drink.IsAlcoholic.ToString(),
                //drink.IsAlcoholic ? "Yes" : "No",
                drink.Price.ToString(),
                drink.Stock.ToString(),
    });
                li.Tag = drink;

                // Check if stock is low and add an indication if needed
                if (drink.Stock < 10)
                {
                    li.SubItems.Add("Stock nearly depleted");
                }
                else
                {
                    li.SubItems.Add("Stock sufficient");
                }

                listViewDrinks.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }


        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        // Event handler for clicking on the lecturers menu item
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturerPanel();
        }

        // Event handler for clicking on the drinks menu item
        private void drinksSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code to handle item selection in the drinks ListView, if needed
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pnlStudents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteForm deletedrink = new DeleteForm();
            deletedrink.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFrom addFrom = new AddFrom();
            addFrom.ShowDialog();
        }

        private void UpdateDrink_Click(object sender, EventArgs e)
        {
            UpDateForm upDateForm = new UpDateForm();
            upDateForm.ShowDialog();
        }

        private void DrinkSuppliesPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

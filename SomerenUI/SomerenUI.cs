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
            // hide all other panels
            pnlRooms.Hide();
            pnlStudents.Hide();
            pnlLecturers.Hide();
            DrinkSuppliesPnl.Hide();


            // show dashboard
            pnlDashboard.Show();
        }
        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlRooms.Hide();
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            DrinkSuppliesPnl.Hide();

            // show students
            pnlStudents.Show();

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
        private void ShowRoomsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturers.Hide();
            DrinkSuppliesPnl.Hide();


            // show Rooms
            pnlRooms.Show();

            try
            {
                // get and display all students
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }


        }
        private void ShowLecturerPanel()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlRooms.Hide();
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
        }
        private void ShowDrinksPanel()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlRooms.Hide();

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


        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            return studentService.GetStudents();
        }
        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }
        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            return lecturerService.GetLecturers();
        }
        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            return drinkService.GetDrinks();
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
        private void DisplayRooms(List<Room> rooms)
        {
            // Clear the listview before filling it
            listViewRooms.Items.Clear();

        // Method to show the drinks panel
        private void ShowDrinksPanel()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            DrinkSuppliesPnl.Show();
                // Configure the ListView to display items vertically
                listViewRooms.Columns.Clear();


                // Add columns for each property

                listViewRooms.View = View.Details;
                listViewRooms.Columns.Add("Room Number", 100);
            listViewRooms.Columns.Add("Room Type", 100);
            listViewRooms.Columns.Add("Floor", 100);
            listViewRooms.Columns.Add("Number of beds", 100);

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(new string[]
                {
            room.RoomNumber.ToString(),
            room.RoomType,
            room.Floor.ToString(),
            room.NumberOfBeds.ToString(),

                });

                listViewRooms.Items.Add(li);
            }
        }
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
                //li.Tag = lecturer;
                listViewLecturers.Items.Add(li);
            }
        }
        private void DisplayDrinks(List<Drink> drinks)
        {
            listViewDrinks.Items.Clear(); // Correct method name

            // Set ListView to display in details view
            listViewDrinks.View = View.Details;

            // Add columns to the ListView
            listViewDrinks.Columns.Clear();
            listViewDrinks.Columns.Add("Drink Number", 100);
            listViewDrinks.Columns.Add("Name", 100);
            listViewDrinks.Columns.Add("VAT", 100);
            listViewDrinks.Columns.Add("Is_Alcoholic", 100); // Correct column name
            listViewDrinks.Columns.Add("Price", 100);
            listViewDrinks.Columns.Add("Stock", 100);

            // Populate the ListView with drinks
            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(new string[] {
                    drink.DrinkNumber.ToString(),
                    drink.DrinkName,
                    drink.VAT.ToString(),
                    drink.IsAlcoholic ? "Yes" : "No",
                    drink.Price.ToString(),
                    drink.Stock.ToString()
                });
                li.Tag = drink;
                listViewDrinks.Items.Add(li);
            }
        }


        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }
        private void drinksSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturerPanel();
        }
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }




        private void pnlStudents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}

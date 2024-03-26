using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Reflection.Emit;

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
            pnlOrderDrink.Hide();
            pnlDrinkSupplies.Hide();

            // show dashboard
            pnlDashboard.Show();
        }
        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlRooms.Hide();
            pnlDashboard.Hide();
            pnlOrderDrink.Hide();
            pnlLecturers.Hide();
            pnlDrinkSupplies.Hide();

            // show students
            pnlStudents.Show();

            // Enable row selection and full row select in the ListView
            listViewStudents.FullRowSelect = true;
            listViewStudents.MultiSelect = false;

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
        private void ShowRoomsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlOrderDrink.Hide();
            pnlDrinkSupplies.Hide();

            // show students
            pnlRooms.Show();

            // Enable row selection and full row select in the ListView
            listViewRooms.FullRowSelect = true;
            listViewRooms.MultiSelect = false;

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
        private void ShowDrinksPanel()
        {
            // Hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();

            // Show drinks panel
            pnlDrinkSupplies.Show();

            try
            {
                // Get and display all drinks
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);

                // Get and display all students for ordering drinks
                List<Student> students = GetStudents();
                DisplayStudentsForOrderPanel(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks or students: " + e.Message);
            }
        }
        private void ShowLecturerPanel()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlOrderDrink.Hide();
            pnlDrinkSupplies.Hide();

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
        private void ShowOrdersPanel()
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlRooms.Hide();
            pnlDrinkSupplies.Hide();

            pnlOrderDrink.Show();
        }


        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
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
            List<Lecturer> lecturers = lecturerService.GetLecturers();
            return lecturers;
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
            AddStudentColumns();

            // Populate the listview with student data
            PopulateStudents(students);
        }
        private void DisplayRooms(List<Room> rooms)
        {
            // Clear the listview before filling it
            listViewRooms.Items.Clear();

            // Configure the ListView to display items vertically
            listViewRooms.View = View.Details;

            // Add columns for each property
            listViewRooms.Columns.Clear();
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
                li.Tag = lecturer;
                listViewLecturers.Items.Add(li);
            }
        }
        //private void DisplayDrinks(List<Drink> drinks)
        //{
        //    // Clear the listview before filling it
        //    listViewSelectDrink.Items.Clear();

        //    // Configure the ListView to display items in a list format
        //    SetupDrinkListView();

        //    // Populate the listview with drink data
        //    PopulateDrinks(drinks);
        //}
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







        // Damisa's Assignment 3
        private void DisplayStudentsForOrderPanel(List<Student> students)
        {
            // Clear the listview before filling it
            listViewSelectStudent.Items.Clear();

            // Configure the ListView to display items in a list format
            listViewSelectStudent.View = View.Details;

            // Add columns for each property
            listViewSelectStudent.Columns.Clear();
            listViewSelectStudent.Columns.Add("Student Number", 100);
            listViewSelectStudent.Columns.Add("First Name", 100);
            listViewSelectStudent.Columns.Add("Last Name", 100);

            // Enable row selection and full row select in the ListView
            listViewSelectStudent.FullRowSelect = true;
            listViewSelectStudent.MultiSelect = false;

            foreach (Student student in students)
            {
                // Create a new ListViewItem
                ListViewItem item = new ListViewItem(student.StudentNumber.ToString());

                // Add subitems for the other properties
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);

                // Add the item to the ListView
                listViewSelectStudent.Items.Add(item);
            }
        }
        private void AddStudentColumns()
        {
            listViewStudents.Columns.Clear();
            listViewStudents.Columns.AddRange(new[]
            {
                new ColumnHeader { Text = "Student Number", Width = 100 },
                new ColumnHeader { Text = "First Name", Width = 100 },
                new ColumnHeader { Text = "Last Name", Width = 100 },
                new ColumnHeader { Text = "Telephone Number", Width = 100 },
                new ColumnHeader { Text = "Class", Width = 100 },
                new ColumnHeader { Text = "Room Number", Width = 100 }});
        }
        private void PopulateStudents(List<Student> students)
        {
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
        private void listViewSelectDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSelectDrink.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = listViewSelectDrink.SelectedItems[0];

                // Get the text of the second subitem (index 1) which contains the drink name
                string selectedDrinkName = selectedItem.SubItems[1].Text;
                lblSelectedDrink.Text = "Selected Drink: " + selectedDrinkName;
            }
        }
        private void listViewSelectStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSelectStudent.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = listViewSelectStudent.SelectedItems[0];

                // Get the text of the second subitem (index 1) which contains the student's first name
                string selectedStudentFirstName = selectedItem.SubItems[1].Text;

                // Display the selected student's first name in the lblSelectedStudent label
                lblSelectedStudent.Text = "Selected Student: " + selectedStudentFirstName;
            }
        }
        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if (listViewSelectStudent.SelectedItems.Count == 0 || listViewSelectDrink.SelectedItems.Count == 0 ||
                !int.TryParse(textBoxSelectDrinkQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please make sure to select a student, a drink, and enter a valid quantity.");
                return;
            }

            // Get the selected student
            ListViewItem selectedStudentItem = listViewSelectStudent.SelectedItems[0];
            int selectedStudentNumber = int.Parse(selectedStudentItem.SubItems[0].Text);

            // Get the selected drink
            ListViewItem selectedDrinkItem = listViewSelectDrink.SelectedItems[0];
            int selectedDrinkNumber = int.Parse(selectedDrinkItem.SubItems[0].Text);

            // Get the selected drink and calculate total price
            Drink selectedDrink = GetDrinks().Find(drink => drink.DrinkNumber == selectedDrinkNumber);
            double totalPrice = selectedDrink.Price * quantity;

            // Ensure there is enough stock for the order
            if (selectedDrink.Stock < quantity)
            {
                MessageBox.Show("Not enough stock available for this drink and quantity.");
                return;
            }

            // Store the sold drink in the database
            OrdersService ordersService = new OrdersService();
            ordersService.AddDrinkSale(new Orders
            {
                DrinkNumber = selectedDrinkNumber,
                StudentNumber = selectedStudentNumber,
                Quantity = quantity,
                TotalPrice = totalPrice,
                PurchaseDateTime = DateTime.Now
            });

            // Decrease the stock amount of the sold drink
            DrinkService drinkService = new DrinkService();
            int updatedStock = selectedDrink.Stock - quantity;
            if (updatedStock < 0)
            {
                updatedStock = 0; // Ensure stock does not go below 0
            }
            //drinkService.UpdateDrinkStock(selectedDrinkNumber, updatedStock);

            MessageBox.Show("Order placed successfully!");
            RefreshDrinkOrderPanel();
        }
        void RefreshDrinkOrderPanel()
        {
            listViewSelectDrink.SelectedItems.Clear();
            listViewSelectStudent.SelectedItems.Clear();
            textBoxSelectDrinkQuantity.Clear();
            lblSelectedDrink.Text = "Select a drink";
            lblSelectedStudent.Text = "Select a student";
            ShowDrinksPanel();
        }
        private void SetupDrinkListView()
        {
            listViewSelectDrink.View = View.Details;
            listViewSelectDrink.Columns.Clear();
            listViewSelectDrink.Columns.AddRange(new[]
            {
                new ColumnHeader { Text = "Drink Number", Width = 100 },
                new ColumnHeader { Text = "Name", Width = 100 },
                new ColumnHeader { Text = "Is Alcoholic", Width = 100 },
                new ColumnHeader { Text = "Price", Width = 100 },
                new ColumnHeader { Text = "Stock", Width = 100 }});

            listViewSelectDrink.FullRowSelect = true;
            listViewSelectDrink.MultiSelect = false;
        }
        private void PopulateDrinks(List<Drink> drinks)
        {
            foreach (Drink drink in drinks)
            {
                ListViewItem item = new ListViewItem(drink.DrinkNumber.ToString());
                //item.SubItems.Add(drink.Name);
                item.SubItems.Add(drink.IsAlcoholic.ToString());
                item.SubItems.Add(drink.Price.ToString("�0.00"));
                item.SubItems.Add(drink.Stock.ToString());
                listViewSelectDrink.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewSelectDrink.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a drink.");
                return;
            }
            if (!int.TryParse(textBoxSelectDrinkQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Get the selected drink
            ListViewItem selectedDrinkItem = listViewSelectDrink.SelectedItems[0];
            int selectedDrinkNumber = int.Parse(selectedDrinkItem.SubItems[0].Text);

            // Get the selected drink and calculate total price
            Drink selectedDrink = GetDrinks().Find(drink => drink.DrinkNumber == selectedDrinkNumber);
            double totalPrice = selectedDrink.Price * quantity;

            // Display total price in label6
            lblShowTotalPrice.Text = "Total Price: �" + totalPrice.ToString("0.00");
        }
        //End of Damisa's assignment 3


















        // Fuctionality of the program
        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }
        private void roomsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturerPanel();
        }
        private void orderADrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrdersPanel();
        }
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }



        //System backend files
        private void pnlStudents_Paint(object sender, PaintEventArgs e)
        {

        }
        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SomerenUI_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelShowTotalPrice_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
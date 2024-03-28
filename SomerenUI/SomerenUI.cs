using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Reflection.Emit;
using SomerenDAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Linq;

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
            pnlReport.Hide();
            pnlManageActivitySupervisors.Hide();

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
            pnlReport.Hide();
            pnlManageActivitySupervisors.Hide();

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
            pnlReport.Hide();
            pnlManageActivitySupervisors.Hide();

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
            pnlOrderDrink.Hide();
            pnlReport.Hide();
            pnlManageActivitySupervisors.Hide();


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
            pnlReport.Hide();
            pnlManageActivitySupervisors.Hide();

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
            pnlReport.Hide();
            pnlManageActivitySupervisors.Hide();

            pnlOrderDrink.Show();

            try
            {
                // Get and display all drinks
                List<Drink> drinks = GetDrinks();
                DisplayDrinksForOrder(drinks);

                // Get and display all students for ordering drinks
                List<Student> students = GetStudents();
                DisplayStudentsForOrderPanel(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks or students: " + e.Message);
            }
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
            listViewDrinks.Columns.Add("Drink Number", 150);
            listViewDrinks.Columns.Add("Name", 100);
            listViewDrinks.Columns.Add("VAT", 100);
            listViewDrinks.Columns.Add("Is_Alcoholic", 100); // Correct column name
            listViewDrinks.Columns.Add("Price", 100);
            listViewDrinks.Columns.Add("Stock", 100);
            listViewDrinks.Columns.Add("Stock Status", 175);

            listViewDrinks.FullRowSelect = true;
            listViewDrinks.MultiSelect = false;

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








        // Damisa's Assignment 3
        private void DisplayDrinksForOrder(List<Drink> drinks)
        {
            // Clear the listview before filling it
            listViewSelectDrink.Items.Clear();

            // Configure the ListView to display items in a list format
            SetupDrinkListView();

            // Populate the listview with drink data
            PopulateDrinks(drinks);
        }
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

        void RefreshDrinkOrderPanel()
        {
            listViewSelectDrink.SelectedItems.Clear();
            listViewSelectStudent.SelectedItems.Clear();
            textBoxSelectDrinkQuantity.Clear();
            lblSelectedDrink.Text = "Select a drink";
            lblSelectedStudent.Text = "Select a student";
            lblShowTotalPrice.Text = "Total Price:";
            ShowOrdersPanel();
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
                item.SubItems.Add(drink.DrinkName.ToString());
                item.SubItems.Add(drink.IsAlcoholic.ToString());
                item.SubItems.Add(drink.Price.ToString("€0.00"));
                item.SubItems.Add(drink.Stock.ToString());
                listViewSelectDrink.Items.Add(item);
            }
        }

        private void buttonCalcCost_Click_1(object sender, EventArgs e)
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
            lblShowTotalPrice.Text = "Total Price: €" + totalPrice.ToString("0.00");
        }

        private void placeOrderButton_Click_2(object sender, EventArgs e)
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
        //End of Damisa's assignment 3



        //Ayaz's assignment 3


        void ShowRevenue()
        {
            DateTime startDate = StartDate.Value;
            DateTime endDate = EndDate.Value;

            ReportService reportService = new ReportService();
            List<Report> filteredReports = reportService.GetReportBetweenDates(startDate, endDate);

            var (numberOfCustomers, totalDrinksSold, turnover) = reportService.GetTurnover(filteredReports);

            if (startDate >= endDate)
            {
                MessageBox.Show("Please select a valid date period. The start date should be before the end date.", "Invalid Date Period", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate dates in the future
            if (endDate > DateTime.Today.AddDays(1))
            {
                MessageBox.Show("Please select a valid date period. You cannot select dates in the future.", "Invalid Date Period", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CustomersData.Text = $"{numberOfCustomers}";
            SalesData.Text = $"{totalDrinksSold}";
            TurnoverData.Text = $"{turnover:€0.00}";
        }
        private void GeneraeRevenue_Click(object sender, EventArgs e)
        {


            ShowRevenue();
        }


        //End of Ayaz's assignment 3














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
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlRooms.Hide();
            pnlDrinkSupplies.Hide();
            pnlOrderDrink.Hide();
            pnlManageActivitySupervisors.Hide();

            pnlReport.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void buttonCalcCost_Click(object sender, EventArgs e)
        {

        }
        private void placeOrderButton_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddDrinksFrom addDrinksFrom = new AddDrinksFrom();
            addDrinksFrom.ShowDialog();
        }

        private void listViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;

            if (listViewSelectDrink.SelectedItems.Count > 0)
            {
                result = MessageBox.Show("Are you sure you want to delete this drink?", "Confirmation", MessageBoxButtons.YesNo);
            }
            else
            {
                MessageBox.Show("Please select a drink to delete.");
            }

            if (result == DialogResult.Yes)
            {
                // Assuming listViewSelectDrink is the name of your ListView
                ListViewItem selectedItem = listViewSelectDrink.SelectedItems[0];
                Drink drinkSelected = (Drink)selectedItem.Tag;

                // Assuming DrinkDao is the implementation of DrinksDao interface
                DrinkDao drinkDao = new DrinkDao();
                drinkDao.DeleteDataFromDatabase(drinkSelected.DrinkNumber);

                // Remove the selected item from the ListView
                listViewSelectDrink.Items.Remove(selectedItem);

                // Inform the user that the drink was deleted successfully
                MessageBox.Show("Drink deleted successfully.");
            }
            else if (result == DialogResult.Cancel) // Handle the case where the user cancels the deletion operation
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }


        private void HideAllPanelsOfApplication()
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();
            pnlOrderDrink.Hide();
            pnlReport.Hide();
            pnlManageActivitySupervisors.Hide();
        }

        //        Start assignment 4 damisa
        //        .........................

        private void ShowActivitySupervisorsPanel()
        {
            HideAllPanelsOfApplication();

            pnlManageActivitySupervisors.Show();
            EnableSupervisorListViewSelect();

            try
            {
                // get and display all activities
                List<Activity> activities = GetActivities();
                DisplayActivitiesSupervisors(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }
        private void EnableSupervisorListViewSelect()
        {
            //enable row selection and only be able to select 1 at a time
            listViewActivitiesSupervisors.FullRowSelect = true;
            listViewActivitiesSupervisors.MultiSelect = false;
            listViewAreSupervisors.FullRowSelect = true;
            listViewAreSupervisors.MultiSelect = false;
            listViewAreNotSupervisors.FullRowSelect = true;
            listViewAreNotSupervisors.MultiSelect = false;
        }
        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }
        private void DisplayActivitiesSupervisors(List<Activity> activities)
        {
            listViewActivitiesSupervisors.Items.Clear();
            SetupActivitiesSupervisorListView(activities);
            PopulateActivitiesSupervisor(activities);
        }
        private void SetupActivitiesSupervisorListView(List<Activity> activity)
        {
            listViewActivitiesSupervisors.View = View.Details;
            listViewActivitiesSupervisors.Columns.Clear();
            listViewActivitiesSupervisors.Columns.AddRange(new[]
            {
                    new ColumnHeader { Text = "Activity Number", Width = 150 },
                    new ColumnHeader { Text = "Name", Width = 200 },
                    new ColumnHeader { Text = "Start Time", Width = 200 },
                    new ColumnHeader { Text = "End Time", Width = 200 }});
        }

        private void PopulateActivitiesSupervisor(List<Activity> activities)
        {
            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(new string[]
                {
                        activity.ActivityNumber.ToString(),
                        activity.ActivityName,
                        activity.StartTime.ToString(),
                        activity.EndTime.ToString()
                });
                li.Tag = activity;
                listViewActivitiesSupervisors.Items.Add(li);
            }
        }
        private void manageActivitySupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitySupervisorsPanel();
        }

        private void btnRemoveSupervisor_Click(object sender, EventArgs e)
        {
            if (listViewAreSupervisors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a supervisor to remove.");
                return;
            }

            DialogResult result = MessageBox.Show("Do you really want to remove this lecturer " +
                "as supervisor?", "Confirm Removal of Supervisor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // Get the selected lecturer to remove from supervisors
            ListViewItem selectedItem = listViewAreSupervisors.SelectedItems[0];
            Lecturer lecturer = (Lecturer)selectedItem.Tag;

            ListViewItem selectedActivityItem = listViewActivitiesSupervisors.SelectedItems[0];
            Activity activity = (Activity)selectedActivityItem.Tag;

            // Remove the lecturer from the supervisors table in the database
            SupervisorService supervisorService = new SupervisorService();
            supervisorService.RemoveSupervisorFromDatabase(lecturer.LecturerNumber, activity.ActivityNumber);

            RefreshSupervisorListViews();
        }

        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {
            if (listViewAreNotSupervisors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a lecturer to add as supervisor.");
                return;
            }

            // Get the selected lecturer to remove from supervisors
            ListViewItem selectedItem = listViewAreNotSupervisors.SelectedItems[0];
            Lecturer lecturer = (Lecturer)selectedItem.Tag;

            // Get the selected activity
            ListViewItem selectedActivityItem = listViewActivitiesSupervisors.SelectedItems[0];
            Activity activity = (Activity)selectedActivityItem.Tag;

            // Add the lecturer to the supervisors table in the database
            SupervisorService supervisorService = new SupervisorService();
            supervisorService.AddSupervisorToDatabase(lecturer.LecturerNumber, activity.ActivityNumber);

            RefreshSupervisorListViews();
        }


        private void listViewActivitiesSupervisors_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSupervisorListViews();
        }

        private void RefreshSupervisorListViews()
        {
            if (listViewActivitiesSupervisors.SelectedItems.Count == 0)
                return;

            // Get the selected activity
            ListViewItem selectedItem = listViewActivitiesSupervisors.SelectedItems[0];
            int selectedActivityNumber = int.Parse(selectedItem.SubItems[0].Text);

            //get the supervisors from the database
            List<Lecturer> supervisor = GetSupervisors(selectedActivityNumber);

            //get the non-supervisors from database
            List<Lecturer> nonSupervisor = GetNonSupervisors(selectedActivityNumber);

            // Display supervisors and non-supervisors in the list views
            DisplayLecturersThatSupervise(supervisor);
            DisplayLecturersThatDontSupervise(nonSupervisor);
        }

        private List<Lecturer> GetSupervisors(int activityNumber)
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetSupervisors(activityNumber);
            return lecturers;
        }

        private List<Lecturer> GetNonSupervisors(int activityNumber)
        {
            List<Lecturer> nonSupervisors = new List<Lecturer>();

            // Get the lecturers
            List<Lecturer> allLecturers = GetLecturers();

            // Get the supervisors
            List<Lecturer> supervisors = GetSupervisors(activityNumber);

            // filter out the non supervisors
            foreach (Lecturer lecturer in allLecturers)
            {
                if (!supervisors.Any(s => s.LecturerNumber == lecturer.LecturerNumber))
                {
                    nonSupervisors.Add(lecturer);
                }
            }
            return nonSupervisors;
        }


        private void DisplayLecturersThatSupervise(List<Lecturer> supervisors)
        {
            // Clear the supervisors list view
            listViewAreSupervisors.Items.Clear();
            listViewAreSupervisors.View = View.Details;

            if (listViewAreSupervisors.Columns.Count == 0)
            {
                listViewAreSupervisors.Columns.AddRange(new[]{
            new ColumnHeader { Text = "Lecturer Number", Width = 130 },
            new ColumnHeader { Text = "First Name", Width = 100 },
            new ColumnHeader { Text = "Last Name", Width = 100 }});
            }

            // Populate the supervisors list view with the retrieved supervisors
            foreach (Lecturer supervisor in supervisors)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supervisor.LecturerNumber.ToString(),
                    supervisor.FirstName,
                    supervisor.LastName
                });
                item.Tag = supervisor;
                listViewAreSupervisors.Items.Add(item);
            }
        }


        void DisplayLecturersThatDontSupervise(List<Lecturer> nonSupervisors)
        {
            // Clear the non-supervisors list view
            listViewAreNotSupervisors.Items.Clear();
            listViewAreNotSupervisors.View = View.Details;


            // Define columns if not defined already
            if (listViewAreNotSupervisors.Columns.Count == 0)
            {
                listViewAreNotSupervisors.Columns.AddRange(new[]{
            new ColumnHeader { Text = "Lecturer Number", Width = 130 },
            new ColumnHeader { Text = "First Name", Width = 100 },
            new ColumnHeader { Text = "Last Name", Width = 100 }});
            }
            // Populate the non-supervisors list view with the retrieved non-supervisors
            foreach (Lecturer nonSupervisor in nonSupervisors)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    nonSupervisor.LecturerNumber.ToString(),
                    nonSupervisor.FirstName,
                    nonSupervisor.LastName
                });
                item.Tag = nonSupervisor;
                listViewAreNotSupervisors.Items.Add(item);
            }
        }
        private void pnlManageActivitySupervisors_Paint(object sender, PaintEventArgs e)
        {

        }
        //         .......................
        //         End assignment 4 damisa

    }
}


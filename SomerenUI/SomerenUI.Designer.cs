namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            orderADrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            pnlOrderDrink = new System.Windows.Forms.Panel();
            buttonCalcCost = new System.Windows.Forms.Button();
            lblSelectedDrink = new System.Windows.Forms.Label();
            lblSelectedStudent = new System.Windows.Forms.Label();
            labelShowTotalPrice = new System.Windows.Forms.Label();
            lblShowTotalPrice = new System.Windows.Forms.Label();
            placeOrderButton = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            textBoxSelectDrinkQuantity = new System.Windows.Forms.TextBox();
            listViewSelectDrink = new System.Windows.Forms.ListView();
            listViewSelectStudent = new System.Windows.Forms.ListView();
            pnlRooms = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            label2 = new System.Windows.Forms.Label();
            pnlLecturers = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            listViewLecturers = new System.Windows.Forms.ListView();
            label3 = new System.Windows.Forms.Label();
            pnlDrinkSupplies = new System.Windows.Forms.Panel();
            button3 = new System.Windows.Forms.Button();
            buttonUpDate = new System.Windows.Forms.Button();
            buttonAdd = new System.Windows.Forms.Button();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            listViewDrinks = new System.Windows.Forms.ListView();
            label4 = new System.Windows.Forms.Label();
            pnlReport = new System.Windows.Forms.Panel();
            CustomersData = new System.Windows.Forms.Label();
            TurnoverData = new System.Windows.Forms.Label();
            SalesData = new System.Windows.Forms.Label();
            NrOfCustomers = new System.Windows.Forms.Label();
            Turnover = new System.Windows.Forms.Label();
            Sales = new System.Windows.Forms.Label();
            GeneraeRevenue = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            EndDate = new System.Windows.Forms.DateTimePicker();
            StartDate = new System.Windows.Forms.DateTimePicker();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlOrderDrink.SuspendLayout();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlDrinkSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, toolStripMenuItem1, drinksToolStripMenuItem, reportToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1099, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click_1;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            toolStripMenuItem1.Text = "Drink supplies";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { orderADrinkToolStripMenuItem });
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            drinksToolStripMenuItem.Text = "Order";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // orderADrinkToolStripMenuItem
            // 
            orderADrinkToolStripMenuItem.Name = "orderADrinkToolStripMenuItem";
            orderADrinkToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            orderADrinkToolStripMenuItem.Text = "Order a drink";
            orderADrinkToolStripMenuItem.Click += orderADrinkToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            reportToolStripMenuItem.Text = "Report";
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            pnlDashboard.Paint += pnlDashboard_Paint;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 621);
            pnlStudents.TabIndex = 2;
            pnlStudents.Paint += pnlStudents_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(920, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(18, 56);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(875, 408);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.SelectedIndexChanged += listViewStudents_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlOrderDrink
            // 
            pnlOrderDrink.Controls.Add(buttonCalcCost);
            pnlOrderDrink.Controls.Add(lblSelectedDrink);
            pnlOrderDrink.Controls.Add(lblSelectedStudent);
            pnlOrderDrink.Controls.Add(labelShowTotalPrice);
            pnlOrderDrink.Controls.Add(lblShowTotalPrice);
            pnlOrderDrink.Controls.Add(placeOrderButton);
            pnlOrderDrink.Controls.Add(label5);
            pnlOrderDrink.Controls.Add(textBoxSelectDrinkQuantity);
            pnlOrderDrink.Controls.Add(listViewSelectDrink);
            pnlOrderDrink.Controls.Add(listViewSelectStudent);
            pnlOrderDrink.Location = new System.Drawing.Point(14, 36);
            pnlOrderDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlOrderDrink.Name = "pnlOrderDrink";
            pnlOrderDrink.Size = new System.Drawing.Size(1069, 621);
            pnlOrderDrink.TabIndex = 3;
            pnlOrderDrink.Paint += panel1_Paint;
            // 
            // buttonCalcCost
            // 
            buttonCalcCost.Location = new System.Drawing.Point(949, 413);
            buttonCalcCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonCalcCost.Name = "buttonCalcCost";
            buttonCalcCost.Size = new System.Drawing.Size(106, 31);
            buttonCalcCost.TabIndex = 13;
            buttonCalcCost.Text = "Calculate Cost";
            buttonCalcCost.UseVisualStyleBackColor = true;
            buttonCalcCost.Click += buttonCalcCost_Click_1;
            // 
            // lblSelectedDrink
            // 
            lblSelectedDrink.AutoSize = true;
            lblSelectedDrink.Location = new System.Drawing.Point(419, 76);
            lblSelectedDrink.Name = "lblSelectedDrink";
            lblSelectedDrink.Size = new System.Drawing.Size(98, 20);
            lblSelectedDrink.TabIndex = 12;
            lblSelectedDrink.Text = "Select a drink";
            // 
            // lblSelectedStudent
            // 
            lblSelectedStudent.AutoSize = true;
            lblSelectedStudent.Location = new System.Drawing.Point(18, 76);
            lblSelectedStudent.Name = "lblSelectedStudent";
            lblSelectedStudent.Size = new System.Drawing.Size(114, 20);
            lblSelectedStudent.TabIndex = 11;
            lblSelectedStudent.Text = "Select a student";
            // 
            // labelShowTotalPrice
            // 
            labelShowTotalPrice.AutoSize = true;
            labelShowTotalPrice.Location = new System.Drawing.Point(910, 488);
            labelShowTotalPrice.Name = "labelShowTotalPrice";
            labelShowTotalPrice.Size = new System.Drawing.Size(0, 20);
            labelShowTotalPrice.TabIndex = 10;
            labelShowTotalPrice.Click += labelShowTotalPrice_Click;
            // 
            // lblShowTotalPrice
            // 
            lblShowTotalPrice.AutoSize = true;
            lblShowTotalPrice.Location = new System.Drawing.Point(825, 488);
            lblShowTotalPrice.Name = "lblShowTotalPrice";
            lblShowTotalPrice.Size = new System.Drawing.Size(81, 20);
            lblShowTotalPrice.TabIndex = 9;
            lblShowTotalPrice.Text = "Total Price:";
            lblShowTotalPrice.Click += label6_Click;
            // 
            // placeOrderButton
            // 
            placeOrderButton.Location = new System.Drawing.Point(825, 529);
            placeOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new System.Drawing.Size(230, 45);
            placeOrderButton.TabIndex = 8;
            placeOrderButton.Text = "Place Order";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Click += placeOrderButton_Click_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(825, 377);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 20);
            label5.TabIndex = 7;
            label5.Text = "Select Quantity: ";
            label5.Click += label5_Click;
            // 
            // textBoxSelectDrinkQuantity
            // 
            textBoxSelectDrinkQuantity.Location = new System.Drawing.Point(825, 413);
            textBoxSelectDrinkQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxSelectDrinkQuantity.Name = "textBoxSelectDrinkQuantity";
            textBoxSelectDrinkQuantity.Size = new System.Drawing.Size(106, 27);
            textBoxSelectDrinkQuantity.TabIndex = 4;
            textBoxSelectDrinkQuantity.TextChanged += textBox1_TextChanged;
            // 
            // listViewSelectDrink
            // 
            listViewSelectDrink.Location = new System.Drawing.Point(419, 100);
            listViewSelectDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewSelectDrink.Name = "listViewSelectDrink";
            listViewSelectDrink.Size = new System.Drawing.Size(378, 473);
            listViewSelectDrink.TabIndex = 3;
            listViewSelectDrink.UseCompatibleStateImageBehavior = false;
            listViewSelectDrink.SelectedIndexChanged += listViewSelectDrink_SelectedIndexChanged;
            // 
            // listViewSelectStudent
            // 
            listViewSelectStudent.Location = new System.Drawing.Point(18, 100);
            listViewSelectStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewSelectStudent.Name = "listViewSelectStudent";
            listViewSelectStudent.Size = new System.Drawing.Size(394, 473);
            listViewSelectStudent.TabIndex = 1;
            listViewSelectStudent.UseCompatibleStateImageBehavior = false;
            listViewSelectStudent.SelectedIndexChanged += listViewSelectStudent_SelectedIndexChanged;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(pictureBox2);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(label2);
            pnlRooms.Location = new System.Drawing.Point(14, 36);
            pnlRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1072, 621);
            pnlRooms.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(920, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(149, 164);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(18, 56);
            listViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(875, 408);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 41);
            label2.TabIndex = 0;
            label2.Text = "Rooms";
            // 
            // pnlLecturers
            // 
            pnlLecturers.Controls.Add(pictureBox3);
            pnlLecturers.Controls.Add(listViewLecturers);
            pnlLecturers.Controls.Add(label3);
            pnlLecturers.Location = new System.Drawing.Point(14, 36);
            pnlLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new System.Drawing.Size(1072, 621);
            pnlLecturers.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(920, 0);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(149, 164);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Location = new System.Drawing.Point(18, 56);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(875, 408);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(15, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(138, 41);
            label3.TabIndex = 0;
            label3.Text = "Lecturers";
            // 
            // pnlDrinkSupplies
            // 
            pnlDrinkSupplies.Controls.Add(button3);
            pnlDrinkSupplies.Controls.Add(buttonUpDate);
            pnlDrinkSupplies.Controls.Add(buttonAdd);
            pnlDrinkSupplies.Controls.Add(pictureBox4);
            pnlDrinkSupplies.Controls.Add(listViewDrinks);
            pnlDrinkSupplies.Controls.Add(label4);
            pnlDrinkSupplies.Location = new System.Drawing.Point(14, 36);
            pnlDrinkSupplies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDrinkSupplies.Name = "pnlDrinkSupplies";
            pnlDrinkSupplies.Size = new System.Drawing.Size(1072, 621);
            pnlDrinkSupplies.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button3.Location = new System.Drawing.Point(753, 502);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(140, 37);
            button3.TabIndex = 5;
            button3.Text = "Delete Drink";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonUpDate
            // 
            buttonUpDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            buttonUpDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonUpDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonUpDate.Location = new System.Drawing.Point(377, 502);
            buttonUpDate.Name = "buttonUpDate";
            buttonUpDate.Size = new System.Drawing.Size(140, 37);
            buttonUpDate.TabIndex = 4;
            buttonUpDate.Text = "Up-date Drink";
            buttonUpDate.UseMnemonic = false;
            buttonUpDate.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonAdd.Location = new System.Drawing.Point(18, 502);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(140, 37);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add Drink";
            buttonAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(920, 0);
            pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(149, 164);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewDrinks
            // 
            listViewDrinks.Location = new System.Drawing.Point(18, 56);
            listViewDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(875, 408);
            listViewDrinks.TabIndex = 1;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.SelectedIndexChanged += listViewDrinks_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(15, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 41);
            label4.TabIndex = 0;
            label4.Text = "Drinks";
            // 
            // pnlReport
            // 
            pnlReport.Controls.Add(CustomersData);
            pnlReport.Controls.Add(TurnoverData);
            pnlReport.Controls.Add(SalesData);
            pnlReport.Controls.Add(NrOfCustomers);
            pnlReport.Controls.Add(Turnover);
            pnlReport.Controls.Add(Sales);
            pnlReport.Controls.Add(GeneraeRevenue);
            pnlReport.Controls.Add(label8);
            pnlReport.Controls.Add(label7);
            pnlReport.Controls.Add(EndDate);
            pnlReport.Controls.Add(StartDate);
            pnlReport.Controls.Add(pictureBox5);
            pnlReport.Controls.Add(label6);
            pnlReport.Location = new System.Drawing.Point(14, 36);
            pnlReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlReport.Name = "pnlReport";
            pnlReport.Size = new System.Drawing.Size(1072, 621);
            pnlReport.TabIndex = 3;
            // 
            // CustomersData
            // 
            CustomersData.AutoSize = true;
            CustomersData.Location = new System.Drawing.Point(438, 424);
            CustomersData.Name = "CustomersData";
            CustomersData.Size = new System.Drawing.Size(36, 20);
            CustomersData.TabIndex = 13;
            CustomersData.Text = "0.00";
            // 
            // TurnoverData
            // 
            TurnoverData.AutoSize = true;
            TurnoverData.Location = new System.Drawing.Point(438, 377);
            TurnoverData.Name = "TurnoverData";
            TurnoverData.Size = new System.Drawing.Size(36, 20);
            TurnoverData.TabIndex = 12;
            TurnoverData.Text = "0.00";
            // 
            // SalesData
            // 
            SalesData.AutoSize = true;
            SalesData.Location = new System.Drawing.Point(438, 325);
            SalesData.Name = "SalesData";
            SalesData.Size = new System.Drawing.Size(36, 20);
            SalesData.TabIndex = 11;
            SalesData.Text = "0.00";
            // 
            // NrOfCustomers
            // 
            NrOfCustomers.AutoSize = true;
            NrOfCustomers.Location = new System.Drawing.Point(240, 424);
            NrOfCustomers.Name = "NrOfCustomers";
            NrOfCustomers.Size = new System.Drawing.Size(155, 20);
            NrOfCustomers.TabIndex = 10;
            NrOfCustomers.Text = "Number of customers:";
            // 
            // Turnover
            // 
            Turnover.AutoSize = true;
            Turnover.Location = new System.Drawing.Point(319, 377);
            Turnover.Name = "Turnover";
            Turnover.Size = new System.Drawing.Size(70, 20);
            Turnover.TabIndex = 9;
            Turnover.Text = "Turnover:";
            // 
            // Sales
            // 
            Sales.AutoSize = true;
            Sales.Location = new System.Drawing.Point(343, 325);
            Sales.Name = "Sales";
            Sales.Size = new System.Drawing.Size(46, 20);
            Sales.TabIndex = 8;
            Sales.Text = "Sales:";
            // 
            // GeneraeRevenue
            // 
            GeneraeRevenue.Location = new System.Drawing.Point(257, 143);
            GeneraeRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GeneraeRevenue.Name = "GeneraeRevenue";
            GeneraeRevenue.Size = new System.Drawing.Size(288, 124);
            GeneraeRevenue.TabIndex = 7;
            GeneraeRevenue.Text = "Generate Revenue";
            GeneraeRevenue.UseVisualStyleBackColor = true;
            GeneraeRevenue.Click += GeneraeRevenue_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(464, 76);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 20);
            label8.TabIndex = 6;
            label8.Text = "End Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(18, 76);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 20);
            label7.TabIndex = 5;
            label7.Text = "Start Date:";
            // 
            // EndDate
            // 
            EndDate.Location = new System.Drawing.Point(553, 68);
            EndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EndDate.Name = "EndDate";
            EndDate.Size = new System.Drawing.Size(228, 27);
            EndDate.TabIndex = 4;
            // 
            // StartDate
            // 
            StartDate.Location = new System.Drawing.Point(99, 68);
            StartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            StartDate.Name = "StartDate";
            StartDate.Size = new System.Drawing.Size(228, 27);
            StartDate.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(920, 0);
            pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(149, 164);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(15, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(228, 41);
            label6.TabIndex = 0;
            label6.Text = "Revenue Report";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 673);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlDrinkSupplies);
            Controls.Add(pnlLecturers);
            Controls.Add(pnlRooms);
            Controls.Add(pnlOrderDrink);
            Controls.Add(pnlReport);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlOrderDrink.ResumeLayout(false);
            pnlOrderDrink.PerformLayout();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlLecturers.ResumeLayout(false);
            pnlLecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlDrinkSupplies.ResumeLayout(false);
            pnlDrinkSupplies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlReport.ResumeLayout(false);
            pnlReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderADrinkToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOrderDrink;
        private System.Windows.Forms.ListView listViewSelectStudent;
        private System.Windows.Forms.TextBox textBoxSelectDrinkQuantity;
        private System.Windows.Forms.ListView listViewSelectDrink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Label labelShowTotalPrice;
        private System.Windows.Forms.Label lblShowTotalPrice;
        private System.Windows.Forms.Label lblSelectedDrink;
        private System.Windows.Forms.Label lblSelectedStudent;
        private System.Windows.Forms.Button buttonCalcCost;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLecturers;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDrinkSupplies;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GeneraeRevenue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label CustomersData;
        private System.Windows.Forms.Label TurnoverData;
        private System.Windows.Forms.Label SalesData;
        private System.Windows.Forms.Label NrOfCustomers;
        private System.Windows.Forms.Label Turnover;
        private System.Windows.Forms.Label Sales;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonUpDate;
        private System.Windows.Forms.Button buttonAdd;
        //private System.Windows.Forms.Label label2;

    }
}
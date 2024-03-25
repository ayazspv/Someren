﻿namespace SomerenUI
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
            drinkSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            orderADrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listViewSelectStudent = new System.Windows.Forms.ListView();
            pnlRooms = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();

            label2 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            pnlOrderDrink.SuspendLayout();

            pnlRooms.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drinkSuppliesToolStripMenuItem, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(962, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click_1;
            // 
            // drinkSuppliesToolStripMenuItem
            // 
            drinkSuppliesToolStripMenuItem.Name = "drinkSuppliesToolStripMenuItem";
            drinkSuppliesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            drinkSuppliesToolStripMenuItem.Text = "Drink supplies";
            drinkSuppliesToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { orderADrinkToolStripMenuItem });
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            drinksToolStripMenuItem.Text = "Order";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // orderADrinkToolStripMenuItem
            // 
            orderADrinkToolStripMenuItem.Name = "orderADrinkToolStripMenuItem";
            orderADrinkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            orderADrinkToolStripMenuItem.Text = "Order a drink";
            orderADrinkToolStripMenuItem.Click += orderADrinkToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(12, 27);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(938, 466);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(13, 13);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(208, 15);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(12, 27);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(938, 466);
            pnlStudents.TabIndex = 2;
            pnlStudents.Paint += pnlStudents_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(805, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(130, 123);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(16, 42);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(766, 307);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.SelectedIndexChanged += listViewStudents_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 32);
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
            pnlOrderDrink.Controls.Add(pictureBox2);
            pnlOrderDrink.Controls.Add(listViewSelectStudent);
            pnlOrderDrink.Controls.Add(label2);
            pnlOrderDrink.Location = new System.Drawing.Point(12, 27);
            pnlOrderDrink.Name = "pnlOrderDrink";
            pnlOrderDrink.Size = new System.Drawing.Size(935, 466);
            pnlOrderDrink.TabIndex = 3;
            pnlOrderDrink.Paint += panel1_Paint;
            // 
            // buttonCalcCost
            // 
            buttonCalcCost.Location = new System.Drawing.Point(830, 310);
            buttonCalcCost.Name = "buttonCalcCost";
            buttonCalcCost.Size = new System.Drawing.Size(93, 23);
            buttonCalcCost.TabIndex = 13;
            buttonCalcCost.Text = "Calculate Cost";
            buttonCalcCost.UseVisualStyleBackColor = true;
            buttonCalcCost.Click += button1_Click;
            // 
            // lblSelectedDrink
            // 
            lblSelectedDrink.AutoSize = true;
            lblSelectedDrink.Location = new System.Drawing.Point(367, 57);
            lblSelectedDrink.Name = "lblSelectedDrink";
            lblSelectedDrink.Size = new System.Drawing.Size(77, 15);
            lblSelectedDrink.TabIndex = 12;
            lblSelectedDrink.Text = "Select a drink";
            // 
            // lblSelectedStudent
            // 
            lblSelectedStudent.AutoSize = true;
            lblSelectedStudent.Location = new System.Drawing.Point(16, 57);
            lblSelectedStudent.Name = "lblSelectedStudent";
            lblSelectedStudent.Size = new System.Drawing.Size(90, 15);
            lblSelectedStudent.TabIndex = 11;
            lblSelectedStudent.Text = "Select a student";
            // 
            // labelShowTotalPrice
            // 
            labelShowTotalPrice.AutoSize = true;
            labelShowTotalPrice.Location = new System.Drawing.Point(796, 366);
            labelShowTotalPrice.Name = "labelShowTotalPrice";
            labelShowTotalPrice.Size = new System.Drawing.Size(0, 15);
            labelShowTotalPrice.TabIndex = 10;
            labelShowTotalPrice.Click += labelShowTotalPrice_Click;
            // 
            // lblShowTotalPrice
            // 
            lblShowTotalPrice.AutoSize = true;
            lblShowTotalPrice.Location = new System.Drawing.Point(722, 366);
            lblShowTotalPrice.Name = "lblShowTotalPrice";
            lblShowTotalPrice.Size = new System.Drawing.Size(64, 15);
            lblShowTotalPrice.TabIndex = 9;
            lblShowTotalPrice.Text = "Total Price:";
            lblShowTotalPrice.Click += label6_Click;
            // 
            // placeOrderButton
            // 
            placeOrderButton.Location = new System.Drawing.Point(722, 397);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new System.Drawing.Size(201, 34);
            placeOrderButton.TabIndex = 8;
            placeOrderButton.Text = "Place Order";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Click += placeOrderButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(722, 283);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 15);
            label5.TabIndex = 7;
            label5.Text = "Select Quantity: ";
            label5.Click += label5_Click;
            // 
            // textBoxSelectDrinkQuantity
            // 
            textBoxSelectDrinkQuantity.Location = new System.Drawing.Point(722, 310);
            textBoxSelectDrinkQuantity.Name = "textBoxSelectDrinkQuantity";
            textBoxSelectDrinkQuantity.Size = new System.Drawing.Size(93, 23);
            textBoxSelectDrinkQuantity.TabIndex = 4;
            textBoxSelectDrinkQuantity.TextChanged += textBox1_TextChanged;
            // 
            // listViewSelectDrink
            // 
            listViewSelectDrink.Location = new System.Drawing.Point(367, 75);
            listViewSelectDrink.Name = "listViewSelectDrink";
            listViewSelectDrink.Size = new System.Drawing.Size(331, 356);
            listViewSelectDrink.TabIndex = 3;
            listViewSelectDrink.UseCompatibleStateImageBehavior = false;
            listViewSelectDrink.SelectedIndexChanged += listViewSelectDrink_SelectedIndexChanged;

            // pnlRooms
            // 
            pnlRooms.Controls.Add(pictureBox2);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(label2);
            pnlRooms.Location = new System.Drawing.Point(12, 27);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(938, 466);
            pnlRooms.TabIndex = 3;

            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(805, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(130, 123);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 

            // listViewSelectStudent
            // 
            listViewSelectStudent.Location = new System.Drawing.Point(16, 75);
            listViewSelectStudent.Name = "listViewSelectStudent";
            listViewSelectStudent.Size = new System.Drawing.Size(345, 356);
            listViewSelectStudent.TabIndex = 1;
            listViewSelectStudent.UseCompatibleStateImageBehavior = false;
            listViewSelectStudent.SelectedIndexChanged += listViewSelectStudent_SelectedIndexChanged;

            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(16, 42);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(766, 307);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;

            // 
            // label2
            // 
            //label2.AutoSize = true;
            //label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //label2.Location = new System.Drawing.Point(13, 7);
            //label2.Name = "label2";

            //label2.Size = new System.Drawing.Size(155, 32);
            //label2.TabIndex = 0;
            //label2.Text = "Order a drink";
            //label2.Click += label2_Click;

            //label2.Size = new System.Drawing.Size(107, 32);
            //label2.TabIndex = 0;
            //label2.Text = "Students";

            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(962, 505);

            Controls.Add(pnlOrderDrink);

            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlRooms);
            Controls.Add(pnlStudents);
            MainMenuStrip = menuStrip1;
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

            //((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewSelectStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSelectDrinkQuantity;
        private System.Windows.Forms.ListView listViewSelectDrink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Label labelShowTotalPrice;
        private System.Windows.Forms.Label lblShowTotalPrice;
        private System.Windows.Forms.Label lblSelectedDrink;
        private System.Windows.Forms.Label lblSelectedStudent;
        private System.Windows.Forms.Button buttonCalcCost;
        private System.Windows.Forms.ToolStripMenuItem drinkSuppliesToolStripMenuItem;

        private System.Windows.Forms.Panel pnlRooms;
        //private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewRooms;
        //private System.Windows.Forms.Label label2;

    }
}
namespace SomerenUI
{
    partial class UpdateStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            txtStudentNumber = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtRoomNumber = new System.Windows.Forms.TextBox();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtClass = new System.Windows.Forms.TextBox();
            txtTelephoneNumber = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Number";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new System.Drawing.Point(168, 26);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new System.Drawing.Size(100, 23);
            txtStudentNumber.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(68, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(55, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 15);
            label2.TabIndex = 0;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(55, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(55, 121);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(55, 150);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 15);
            label5.TabIndex = 0;
            label5.Text = "Class";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(55, 179);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(86, 15);
            label6.TabIndex = 0;
            label6.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new System.Drawing.Point(168, 171);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new System.Drawing.Size(100, 23);
            txtRoomNumber.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(168, 55);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(100, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtClass
            // 
            txtClass.Location = new System.Drawing.Point(168, 142);
            txtClass.Name = "txtClass";
            txtClass.Size = new System.Drawing.Size(100, 23);
            txtClass.TabIndex = 5;
            // 
            // txtTelephoneNumber
            // 
            txtTelephoneNumber.Location = new System.Drawing.Point(168, 113);
            txtTelephoneNumber.Name = "txtTelephoneNumber";
            txtTelephoneNumber.Size = new System.Drawing.Size(100, 23);
            txtTelephoneNumber.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(168, 84);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(100, 23);
            txtLastName.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(167, 238);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateStudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(328, 288);
            Controls.Add(txtRoomNumber);
            Controls.Add(txtClass);
            Controls.Add(txtTelephoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentNumber);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateStudentForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnCancel;
    }
}
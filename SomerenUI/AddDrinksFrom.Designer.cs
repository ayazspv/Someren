namespace SomerenUI
{
    partial class AddDrinksFrom
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textDrinkNumner = new System.Windows.Forms.TextBox();
            textDrinkName = new System.Windows.Forms.TextBox();
            textVAT = new System.Windows.Forms.TextBox();
            textIsAlcoholic = new System.Windows.Forms.TextBox();
            textPrice = new System.Windows.Forms.TextBox();
            textInStock = new System.Windows.Forms.TextBox();
            buttonAddDrink = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(236, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 46);
            label1.TabIndex = 0;
            label1.Text = "Add a Drink";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(160, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Drink Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(160, 387);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(160, 186);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Drink Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(160, 257);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "VAT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(160, 323);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(184, 20);
            label6.TabIndex = 5;
            label6.Text = "Is_Alcoholic (1=Yes/0=No)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(160, 447);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 20);
            label7.TabIndex = 6;
            label7.Text = "Stock";
            // 
            // textDrinkNumner
            // 
            textDrinkNumner.Location = new System.Drawing.Point(436, 125);
            textDrinkNumner.Name = "textDrinkNumner";
            textDrinkNumner.Size = new System.Drawing.Size(125, 27);
            textDrinkNumner.TabIndex = 7;
            // 
            // textDrinkName
            // 
            textDrinkName.Location = new System.Drawing.Point(436, 186);
            textDrinkName.Name = "textDrinkName";
            textDrinkName.Size = new System.Drawing.Size(125, 27);
            textDrinkName.TabIndex = 8;
            // 
            // textVAT
            // 
            textVAT.Location = new System.Drawing.Point(436, 250);
            textVAT.Name = "textVAT";
            textVAT.Size = new System.Drawing.Size(125, 27);
            textVAT.TabIndex = 9;
            // 
            // textIsAlcoholic
            // 
            textIsAlcoholic.Location = new System.Drawing.Point(436, 316);
            textIsAlcoholic.Name = "textIsAlcoholic";
            textIsAlcoholic.Size = new System.Drawing.Size(125, 27);
            textIsAlcoholic.TabIndex = 10;
            // 
            // textPrice
            // 
            textPrice.Location = new System.Drawing.Point(436, 368);
            textPrice.Name = "textPrice";
            textPrice.Size = new System.Drawing.Size(125, 27);
            textPrice.TabIndex = 11;
            // 
            // textInStock
            // 
            textInStock.Location = new System.Drawing.Point(436, 440);
            textInStock.Name = "textInStock";
            textInStock.Size = new System.Drawing.Size(125, 27);
            textInStock.TabIndex = 12;
            // 
            // buttonAddDrink
            // 
            buttonAddDrink.BackColor = System.Drawing.SystemColors.ActiveCaption;
            buttonAddDrink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAddDrink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonAddDrink.Location = new System.Drawing.Point(160, 504);
            buttonAddDrink.Name = "buttonAddDrink";
            buttonAddDrink.Size = new System.Drawing.Size(401, 47);
            buttonAddDrink.TabIndex = 13;
            buttonAddDrink.Text = "Proceed";
            buttonAddDrink.UseVisualStyleBackColor = false;
            buttonAddDrink.Click += buttonAddDrink_Click;
            // 
            // AddDrinksFrom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 563);
            Controls.Add(buttonAddDrink);
            Controls.Add(textInStock);
            Controls.Add(textPrice);
            Controls.Add(textIsAlcoholic);
            Controls.Add(textVAT);
            Controls.Add(textDrinkName);
            Controls.Add(textDrinkNumner);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddDrinksFrom";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDrinkNumner;
        private System.Windows.Forms.TextBox textDrinkName;
        private System.Windows.Forms.TextBox textVAT;
        private System.Windows.Forms.TextBox textIsAlcoholic;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textInStock;
        private System.Windows.Forms.Button buttonAddDrink;
    }
}
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class AddFrom : Form
    {
        public AddFrom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int drinkNumber = int.Parse(textDrinkNumner.Text);
            string drinkName = textDrinkName.Text;
            double VAT = double.Parse(textVAT.Text);
            string IsAlcoholic = textIsAlcoholic.Text;
            double price = double.Parse(textPrice.Text);    
            int stock = int.Parse(textInStock.Text);
            DrinkService drinkService = new DrinkService();

            drinkService.AddDrink(drinkNumber,drinkName,VAT,IsAlcoholic,price,stock);
        }
    }
}

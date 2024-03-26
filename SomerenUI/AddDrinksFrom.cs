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
    public partial class AddDrinksFrom : Form
    {
        public AddDrinksFrom()
        {
            InitializeComponent();
        }

        private void buttonAddDrink_Click(object sender, EventArgs e)
        {
            int drinkNumber = int.Parse(textDrinkNumner.Text);
            string drinkName = textDrinkName.Text;
            double VAT = double.Parse(textVAT.Text);
            bool IsAlcoholic = bool.Parse(textIsAlcoholic.Text);
            double price = double.Parse(textPrice.Text);
            int stock = int.Parse(textInStock.Text);
            DrinkService drinkService = new DrinkService();

            drinkService.AddDrink(drinkNumber, drinkName, VAT, IsAlcoholic, price, stock);
        }
    }
}

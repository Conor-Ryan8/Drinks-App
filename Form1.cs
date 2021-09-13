using System;
using System.Windows.Forms;

namespace DrinksApp
{
    public partial class FrmDrinks : Form
    {
        private Drink _thisDrink;

        private void DrinkSelected()
        {
            btnMilk.Enabled = true;
            btnSugar.Enabled = true;
            btnOrder.Enabled = true;
        }

        public FrmDrinks()
        {
            InitializeComponent();
            btnMilk.Enabled = false;
            btnSugar.Enabled = false;
            btnOrder.Enabled = false;
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            _thisDrink = DrinkFactory.GetDrink("Tea");
            txtType.Text = Convert.ToString(_thisDrink.GetType());
            DrinkSelected();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            _thisDrink = DrinkFactory.GetDrink("Coffee");
            txtType.Text = Convert.ToString(_thisDrink.GetType());
            DrinkSelected();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtType.Text = "";
            txtSummary.Text = "";
            btnMilk.Enabled = false;
            btnSugar.Enabled = false;         
            btnOrder.Enabled = true;
            btnTea.Enabled = true;
            btnCoffee.Enabled = true;
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            _thisDrink = new AddMilk(_thisDrink);
            btnMilk.Enabled = false;
        }

        private void btnSugar_Click(object sender, EventArgs e)
        {
            _thisDrink = new AddSugar(_thisDrink);
            btnSugar.Enabled = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            txtSummary.AppendText("Summary: \r\n");
            txtSummary.AppendText(_thisDrink.GetDescription() + "\r\n");
            txtSummary.AppendText("\r\n");
            txtSummary.AppendText("Price: \r\n€");
            txtSummary.AppendText(_thisDrink.GetPrice() + "\r\n");
            btnOrder.Enabled = false;
            btnMilk.Enabled = false;
            btnSugar.Enabled = false;
            btnTea.Enabled = false;
            btnCoffee.Enabled = false;
        }
    }
}
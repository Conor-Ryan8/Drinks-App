using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrinksApp
{
    public partial class FrmDrinks : Form
    {
        private string _type = null;
        private char _size = 'x';

        List<Drink> _currentOrder = new List<Drink>();

        public FrmDrinks()
        {
            InitializeComponent();
        }

        private void ResetDrink()
        {
            btnTea.Enabled = true;
            btnCoffee.Enabled = true;
            btnChocolate.Enabled = true;
            btnSmall.Enabled = true;
            btnMedium.Enabled = true;
            btnLarge.Enabled = true;
        }

        private void UpdateOrder()
        {
            txtOrder.Text = "";
            if (_currentOrder.Count > 0)
            {
                txtOrder.Text = "";
                foreach (var order in _currentOrder)
                {
                    txtOrder.AppendText(order.GetSummary() + "\r\n");
                }
            }
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            btnCoffee.Enabled = false;
            btnChocolate.Enabled = false;
            _type = "Tea";
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            btnCoffee.Enabled = false;
            btnTea.Enabled = false;
            _type = "Chocolate";
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            btnTea.Enabled = false;
            btnChocolate.Enabled = false;
            _type = "Coffee";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _currentOrder = new List<Drink>();
            ResetDrink();
            UpdateOrder();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            btnMedium.Enabled = false;
            btnLarge.Enabled = false;
            _size = 'S';
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            btnSmall.Enabled = false;
            btnLarge.Enabled = false;
            _size = 'M';
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            btnMedium.Enabled = false;
            btnSmall.Enabled = false;
            _size = 'L';
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_type == null || _size == 'x')
            {
                MessageBox.Show("Please Select Type & Size");
            }
            else
            {
                Drink newDrink= DrinkFactory.GetDrink(_type,_size);
                _currentOrder.Add(newDrink);
                _type = null;
                _size = 'x';
                UpdateOrder();
                ResetDrink();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            //visitor pattern stuff goes here, need to visit each element in the list and calculate the price!
        }
    }
}
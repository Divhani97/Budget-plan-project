using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustonClassLibrary;

namespace BugetPlan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating obj to refference my income class
            Income money = new Income();
           //assigning my textbox to get user input
            money.GrossIncome = Convert.ToDouble(TxtBx_gross.Text);
            money.Tax = Convert.ToDouble(TxtBx_tax.Text);
            money.Groceries = Convert.ToDouble(TXtBx_groceries.Text);
            money.Water = Convert.ToDouble(TxtBx_water.Text);
            money.Travel = Convert.ToDouble(TxtBox_travel.Text);
            money.CellPhone = Convert.ToDouble(TxtBox_phone.Text);
            money.OtherExpenses = Convert.ToDouble(TxtBox_other.Text);


           
            //display my monthly income after deduction in the text box
            textBoxIADeduc.Text = money.getMonthlycostTotal().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void TxtBx_gross_TextChanged(object sender, EventArgs e)
        {

        }
        //validating user input
        private void TxtBx_gross_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        private void button2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtBx_tax_TextChanged(object sender, EventArgs e)
        {

        }
        //validating user input
        private void TxtBx_tax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        //validating user input
        private void TXtBx_groceries_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        //validating user input
        private void TxtBx_water_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }
        //validating user input
        private void TxtBox_travel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }
        //validating user input
        private void TxtBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        //validating user input
        private void TxtBox_other_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        private void TxtBox_other_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void propertyCalcBttn_Click(object sender, EventArgs e)
        {
            //instatiating my onbject to acces the class
            BuyPropertyModel buy = new BuyPropertyModel();

            buy.propertyPrice = Convert.ToInt32(propertyTxtBox.Text);
            buy.depositValue = Convert.ToInt32(depositTxtBx.Text);
            buy.interestBuy = Convert.ToDouble(interestBuyTxtBox.Text);
            buy.monthsBuy = Convert.ToInt32(monthBuyTxtBx.Text);



            MessageBox.Show("the property price is :" + buy.PresentValue() +
            "\n" + "the total deposit is :" + buy.DepositValue() +
                 "\n" + "the number of months is :" + buy.nmberOfMonths() +
                    "\n" + "the interest rate is : " + buy.interestRate() +
                                  "\n" + "the cash price is : " + buy.HomeLoan() +
   "\n" + "the monthy home loan repayment is : " + buy.monthlyLoanPaymnt());

            //using textbox to display the monthly loan payment
            MonthlyPAymenttextBox1.Text =buy.monthlyLoanPaymnt().ToString();
            
        }
        
    private void label2_Click(object sender, EventArgs e)
        {
           
           
        }
        //validating input
        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //int x = 0;
            //int y = 0;
            //f1.TxtBx_gross.Text = x.ToString();
            //MonthlyPAymenttextBox1.Text = y.ToString();

            //if (y > 0.3 * x)
            //{
                MessageBox.Show("Approval of the homeLoan is UNLIKELY");

            //}
        }

        private void propertyTxtBox_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void propertyTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        //validating user input
        private void propertyTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        private void depositTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        private void interestBuyTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validating user input
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar !=',')
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value which is double with a , not .");
            }
        }
        //validating user input
        private void monthBuyTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        private void monthBuyTxtBx_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void interestBuyTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

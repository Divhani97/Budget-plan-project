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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                     BuyVehicleModel veh = new BuyVehicleModel(5);
           
           
          
           
            double estInsurance = Convert.ToInt32(estInsuranceTxtBx.Text);

                    veh.modelMake = (modelMakeTxtBx.Text);
                    veh.purchasePrice = Convert.ToInt32(purchasePriceTxtBx.Text);
                    veh.totalDeposit = Convert.ToDouble(totalDepositTxtBx.Text);
                     veh.intrst = Convert.ToDouble(intrstTxtBx.Text);
                    veh.estInsurance = Convert.ToInt32(estInsuranceTxtBx.Text);



            MessageBox.Show("the model and make is :" + veh.getModelMake() +
            "\n" + "the total purchase price is :" + veh.getPresentVAlue() +
                 "\n" + "the total deposit is  :" + veh.getDeposit() +
                    "\n" + "the interest rate is : " + veh.getIntrsRate() +
    "\n" + "the estimated insurance premium is : " + veh.getEstimatedInsurance() +
    "\n" + "the Accumulated value is : " + veh.HomeLoan()+
   "\n" + "the monthy cost for vehicle : " + veh.getMnthlyCOst());


            textBox_MonthlyCost.Text = veh.getMnthlyCOst().ToString();
           
        }

        private void modelMakeTxtBx_TextChanged(object sender, EventArgs e)
        {

        }
        //validating user input
        private void purchasePriceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        //validating user input
        private void totalDepositTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        private void intrstTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        private void estInsuranceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        private void modelMakeTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !char.IsLetter(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a strig value");
            }
        }
    }
}

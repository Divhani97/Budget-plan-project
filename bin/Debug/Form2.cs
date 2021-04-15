using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugetPlan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButtonBuy_CheckedChanged(object sender, EventArgs e)
        {
           
            //i want a form in here
            //i wanna call a method to calculate
        }

        private void radioButtonVehicle_CheckedChanged(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void radioButtonRent_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonBuy.Checked)
            {
                Form4 f4 = new Form4();
                f4.Show();
            }

            if (radioButtonRent.Checked)
            {
                Form3 f3 = new Form3();
                f3.Show();

            }
            if (radioButtonVehicle.Checked)
            {
                Form5 f5 = new Form5();
                f5.Show();
            }
              
        }
    }
}

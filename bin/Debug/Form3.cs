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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int rentAmnt = Convert.ToInt32(rentAmntTxtBox.Text);
                OkRentTXtBox.Text = rentAmnt.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("error, try again");
            }
        }
        //validating user input
        private void rentAmntTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !char.IsDigit(ch) & ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("NOT VALID !!! please enter a numeric value");
            }
        }

        private void rentAmntTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

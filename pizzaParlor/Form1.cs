using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaParlor
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables
                double taxRate = 0.13;
                double taxAmount;
                double totalCost;
                double sliceCost = 3.25;
                int sliceCount = Convert.ToInt32(slicesInput.Text);
                double subtotal;

                //Calculations
                subtotal = sliceCost * sliceCount;
                taxAmount = subtotal * taxRate;
                totalCost = taxAmount + subtotal;

                //Outputs
                subtotalOutput.Text = subtotal.ToString("C");
                taxOutput.Text = taxAmount.ToString("C");
                totalCostOutput.Text = totalCost.ToString("C");
            }
            catch
            {
                subtotalOutput.Text = "Input Error";
                taxOutput.Text = "Input Error";
                totalCostOutput.Text = "Input Error";
            }
        }

        private void slicesInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

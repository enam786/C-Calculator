using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        double number1 = 0;
        double number2 = 0;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCalculator_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
     if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                lblSolution.Text = (number1 + number2).ToString();
                lblOperator.Text = "+";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (double. TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
                
            {
                lblSolution.Text = (number1 - number2).ToString();
                lblOperator.Text = "-";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            lblSolution.Text = "";
           
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))

            {
                lblSolution.Text = (number1 * number2).ToString();
                lblOperator.Text = "*";
            }
                
        }

        private void btnpercentage_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))

            {
                lblSolution.Text = (number1 % number2).ToString();
                lblOperator.Text = "%";
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))

            {
                lblSolution.Text = (number1 / number2).ToString();
                lblOperator.Text = "/";
            }
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))

            {
                lblSolution.Text = Math.Pow(number1, number2).ToString();
                lblOperator.Text = "^";
            }
        }
    }
}

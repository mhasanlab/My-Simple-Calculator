using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Simple_Calculator
{
    public partial class Header : Form
    {
        public Header()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValueOne.Clear();
            txtValueTwo.Clear();
            txtAnswer.Clear();
            txtValueOne.Focus();
        }

        private void btnSummation_Click(object sender, EventArgs e)
        {
            if ((txtValueOne.Text != "") && (txtValueTwo.Text != ""))
            {
                var num1 = (Convert.ToDouble(txtValueOne.Text));
                var num2 = (Convert.ToDouble(txtValueTwo.Text));

                var Result = (num1 + num2);

                txtAnswer.Text = Convert.ToString(Result);
            } 
            else
            {
                MessageBox.Show("Error: Please Fill All The Required Fields Before Calculation");
            }

        }

        private void btnSubsectio_Click(object sender, EventArgs e)
        {
            if ((txtValueOne.Text != "") && (txtValueTwo.Text != ""))
            {
                var num1 = (Convert.ToDouble(txtValueOne.Text));
                var num2 = (Convert.ToDouble(txtValueTwo.Text));

                var Result = (num1 - num2);

                txtAnswer.Text = Convert.ToString(Result);
            }
            else
            {
                MessageBox.Show("Error: Please Fill All The Required Fields Before Calculation");
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if ((txtValueOne.Text != "") && (txtValueTwo.Text != ""))
            {
                var num1 = (Convert.ToDouble(txtValueOne.Text));
                var num2 = (Convert.ToDouble(txtValueTwo.Text));

                var Result = (num1 * num2);

                txtAnswer.Text = Convert.ToString(Result);
            }
            else
            {
                MessageBox.Show("Error: Please Fill All The Required Fields Before Calculation");
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if ((txtValueOne.Text != "") && (txtValueTwo.Text != ""))
            {
                var num1 = (Convert.ToDouble(txtValueOne.Text));
                var num2 = (Convert.ToDouble(txtValueTwo.Text));

                var Result = (num1 / num2);

                txtAnswer.Text = Convert.ToString(Result);
            }
            else
            {
                MessageBox.Show("Error: Please Fill All The Required Fields Before Calculation");
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if ((txtValueOne.Text != "") && (txtValueTwo.Text != ""))
            {
                var num1 = (Convert.ToDouble(txtValueOne.Text));
                var num2 = (Convert.ToDouble(txtValueTwo.Text));

                var Result = (num1 * num2 /100);

                txtAnswer.Text = Convert.ToString(Result);
            }
            else
            {
                MessageBox.Show("Error: Please Fill All The Required Fields Before Calculation");
            }
        }
    }
}

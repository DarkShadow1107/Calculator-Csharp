using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        String operation = "";
        Double number1, number2, contor, Clean_ChangeOperation = 0;
        public Calculator()
        {
            InitializeComponent();
        }
        private void NumericValue(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (txtDisplay.Text == "0" && button.Text != ".")
            {
                txtDisplay.Text = "";
                txtDisplay.Text = txtDisplay.Text + button.Text;
            }
            else if (txtDisplay.Text != "0" && button.Text != ".")
                txtDisplay.Text = txtDisplay.Text + button.Text;

            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + button.Text;
            }
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            Clean_ChangeOperation = 1;
        }
        private void Operational_Functions(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            number1 = Double.Parse(txtDisplay.Text);
            operation = button.Text;
            txtDisplay.Text = "";
            Clean_ChangeOperation = 1;
        }
        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                if (txtDisplay.Text.Length == 0)
                    txtDisplay.Text = "0";
            }
        }
        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            else
                txtDisplay.Text = "-" + txtDisplay.Text;
        }
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (Clean_ChangeOperation == 1)
            {
                contor = 0;
                Clean_ChangeOperation = 0;
            }
            contor ++;
            if (contor == 1)
                number2 = Double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(number1 + number2);
                    number1 += number2;
                    break;
                case "━":
                    txtDisplay.Text = Convert.ToString(number1 - number2);
                    number1 -= number2;
                    break;
                case "×":
                    txtDisplay.Text = Convert.ToString(number1 * number2);
                    number1 *= number2;
                    break;
                case "÷":
                    txtDisplay.Text = Convert.ToString(number1 / number2);
                    number1 /= number2;
                    break;
                case "x^y":
                    txtDisplay.Text = Convert.ToString(Math.Pow(number1, number2));
                    number1 = Math.Pow(number1, number2);
                    break;
                case "%":
                    txtDisplay.Text = Convert.ToString((number1 / 100) * number2);
                    number1 = (number1 / 100) * number2;
                    break;
            }
        }
        private void Button_Inverse_Click(object sender, EventArgs e)
        {
            number1 = Double.Parse(txtDisplay.Text);
            if (number1 != 0)
                txtDisplay.Text = Convert.ToString(1 / number1);
            else
                txtDisplay.Text = "Zero can't be inverted";
        }
        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            number1 = Double.Parse(txtDisplay.Text);
            if (txtDisplay.Text.Contains("-") || txtDisplay.Text.Contains("."))
                txtDisplay.Text = "Invalid input";
            else
                if (number1 < 171)
                {
                    double factorial = 1;
                    for (double i = 2; i <= number1; i ++)
                        factorial = factorial * i;
                    txtDisplay.Text = Convert.ToString(factorial);
                }
                else
                    txtDisplay.Text = "Overflow";
        }
        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            number1 = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(Math.Sqrt(number1));
        }
    }
}

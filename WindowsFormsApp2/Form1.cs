using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string currentInput = string.Empty;
        private string operation = string.Empty;
        private double result = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateResult()
        {
            double secondNumber;
            if (double.TryParse(currentInput, out secondNumber))
            {
                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        break;
                }
                txtResult.Text = result.ToString();
                currentInput = string.Empty;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (operation != string.Empty)
                {
                    CalculateResult();
                }
                result = double.Parse(currentInput);
                operation = button.Text;
                currentInput = string.Empty;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (operation != string.Empty)
                {
                    CalculateResult();
                }
                result = double.Parse(currentInput);
                operation = button.Text;
                currentInput = string.Empty;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            currentInput = string.Empty;
            result = 0;
            operation = string.Empty;
            txtResult.Text = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CalculateResult();
            operation = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (operation != string.Empty)
                {
                    CalculateResult();
                }
                result = double.Parse(currentInput);
                operation = button.Text;
                currentInput = string.Empty;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (operation != string.Empty)
                {
                    CalculateResult();
                }
                result = double.Parse(currentInput);
                operation = button.Text;
                currentInput = string.Empty;
            }
        }
    }
}

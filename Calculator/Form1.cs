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
    public partial class Form1 : Form
    {
        string input = string.Empty;     //String storing user input
        string operand1 = string.Empty;  //String storing first operand
        string operand2 = string.Empty;  //String sotring second operand
        char operation;                  //char for operation
        double result = 0.0;             //calculated result

        public Form1()
        {
            InitializeComponent();
        }

        private void Zero_Button_Click(object sender, EventArgs e)
        {
            input += "0";
        }

        private void One_Button_Click(object sender, EventArgs e)
        {
            input += "1";
        }

        private void Two_Button_Click(object sender, EventArgs e)
        {
            input += "2";
        }

        private void Three_Button_Click(object sender, EventArgs e)
        {
            input += "3";
        }

        private void Four_Button_Click(object sender, EventArgs e)
        {
            input += "4";
        }

        private void Five_Button_Click(object sender, EventArgs e)
        {
            input += "5";
        }

        private void Six_Button_Click(object sender, EventArgs e)
        {
            input += "6";
        }

        private void Seven_Button_Click(object sender, EventArgs e)
        {
            input += "7";
        }

        private void Eight_Button_Click(object sender, EventArgs e)
        {
            input += "8";
        }

        private void Nine_Button_Click(object sender, EventArgs e)
        {
            input += "9";
        }

        private void Divide_Button_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Addition_Button_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Subtract_Button_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Decimal_Button_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {

        }

        private void Equals_Button_Click(object sender, EventArgs e)
        {
          
        }

        private void DisplayBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

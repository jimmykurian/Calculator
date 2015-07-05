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
            this.DisplayBox.Text = "";
            input += "0";
            this.DisplayBox.Text += input;
        }

        private void One_Button_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Text = "";
            input += "1";
            this.DisplayBox.Text += input;
        }

        private void Two_Button_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Text = "";
            input += "2";
            this.DisplayBox.Text += input;
        }

        private void Three_Button_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Text = "";
            input += "3";
            this.DisplayBox.Text += input;
        }

        private void Four_Button_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Text = "";
            input += "4";
            this.DisplayBox.Text += input;
        }

        private void Five_Button_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Text = "";
            input += "5";
            this.DisplayBox.Text += input;
        }

        private void Six_Button_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Text = "";
            input += "6";
            this.DisplayBox.Text += input;
        }

        private void Seven_Button_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Text = "";
            input += "7";
            this.DisplayBox.Text += input;
        }

        private void Eight_Button_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Text = "";
            input += "8";
            this.DisplayBox.Text += input;
        }

        private void Nine_Button_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Text = "";
            input += "9";
            this.DisplayBox.Text += input;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stackcalculator
{
    public partial class Form1 : Form
    {
        class Stack
        {
            public string[] floor;
            public int top;

            public Stack(int n)
            {
                floor = new string[n];
                top = 0;
            }
            public void Push(string x)
            {
                floor[top] = x;
                top += 1;
            }
            public string Pop()
            {
                top -= 1;
                return floor[top];
            }
        }
        Stack y = new Stack(256);
        public Form1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "0" : calculatorDisplay.Text + "0";
            
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "1" : calculatorDisplay.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "2" : calculatorDisplay.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "3" : calculatorDisplay.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "4" : calculatorDisplay.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "5" : calculatorDisplay.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "6" : calculatorDisplay.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "7" : calculatorDisplay.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "8" : calculatorDisplay.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = calculatorDisplay.Text == "0" ? "9" : calculatorDisplay.Text + "9";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "0";
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            if (y.top == 0)
                listDisplay.Text = "";

            y.Push(calculatorDisplay.Text);
            calculatorDisplay.Text = "0";
            for (int i = y.top - 1; i < y.top; i++)
                listDisplay.Text = y.floor[i] + "\r\n" + listDisplay.Text;

        }

        private void popButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = y.Pop();
            listDisplay.Text = "";
            for(int i = 0; i < y.top; i++)
                listDisplay.Text = y.floor[i] + "\r\n" + listDisplay.Text;
        }

        private void op(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(y.top < 2)
            {
                MessageBox.Show("Error");
                return;
            }
            if (button.Text == "+")
                calculatorDisplay.Text = Convert.ToString(Convert.ToInt32(y.floor[y.top - 2]) + Convert.ToInt32(y.floor[y.top - 1]));

            if (button.Text == "-")
                calculatorDisplay.Text = Convert.ToString(Convert.ToInt32(y.floor[y.top - 2]) - Convert.ToInt32(y.floor[y.top - 1]));

            if (button.Text == "x")
                calculatorDisplay.Text = Convert.ToString(Convert.ToInt32(y.floor[y.top - 2]) * Convert.ToInt32(y.floor[y.top - 1]));

            if (button.Text == "/")
                if (Convert.ToInt32(y.floor[y.top - 1]) != 0)
                    calculatorDisplay.Text = Convert.ToString(Convert.ToInt32(y.floor[y.top - 2]) / Convert.ToInt32(y.floor[y.top - 1]));
                else
                    calculatorDisplay.Text = "Error!";
            y.floor = y.floor.Where((source, index) => index != y.top - 2).ToArray();
            y.floor = y.floor.Where((source, index) => index != y.top - 1).ToArray();
            y.top -= 2;
            y.Push(calculatorDisplay.Text);
            listDisplay.Text = "";
            for (int i = 0; i < y.top; i++)
                listDisplay.Text = y.floor[i] + "\r\n" + listDisplay.Text;
        }
    }
}

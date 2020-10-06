using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetAnswer delegateSum = new GetAnswer(Formula.GetSum);
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            result.Text = String.Empty;
            label2.Text = "Sum";
            result.Text = result.Text + (delegateSum(num1, num2).ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAnswer delegateDifference = new GetAnswer(Formula.GetDifference);
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            result.Text = String.Empty;
            label2.Text = "Difference";
            result.Text = result.Text + (delegateDifference(num1, num2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetAnswer delegateProduct = new GetAnswer(Formula.GetProduct);
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            result.Text = String.Empty;
            label2.Text = "Product";
            result.Text = result.Text + (delegateProduct(num1, num2).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAnswer delegateQuotient = new GetAnswer(Formula.GetQuotient);
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            result.Text = String.Empty;
            label2.Text = "Quotient";
            result.Text = result.Text + (delegateQuotient(num1, num2).ToString());
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Input number here.");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { }

        private void textBox1_clicked(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Enter first number")|| (textBox1.Text == "0"))
            {
                textBox1.Clear();
            }

        }



        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox2_Clicked(object sender, EventArgs e)
        {
            if((textBox2.Text == "Enter second number") || (textBox2.Text == "0"))
            {
            textBox2.Clear();
            }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                textBox1.Text = "0";
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^-.,0-9]"))
            {
                errorProvider1.SetError(textBox1, "Invalid data!");
                String text = textBox1.Text + " is an invalid input.\nEnter numbers, comma, or point only.";
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "0";
                errorProvider1.Clear();
                textBox1.Focus();
            }

        }

        private void textBox2_Leaved(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "0";
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^-.,0-9]"))
            {

                errorProvider1.SetError(textBox2, "Invalid data!");
                String text = textBox2.Text + " is an invalid input.\nEnter numbers, comma, or point only.";
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "0";
                errorProvider1.Clear();
                textBox2.Focus();
            }
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Text = "0";
        }

        private void textBox1_Hover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Input first number here.");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "Input second number here.");
        }

        private void clear1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(clear, "It clears the first text box.");
        }

        private void clear2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(clear2, "It clears the first second box.");
        }

        private void plus_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(plus, "Addition");
        }

        private void minus_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(minus, "Subtraction");
        }

        private void times_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(times, "Multiplication");
        }

        private void divide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(divide, "Division");
        }

        private void result_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(result, "Answer will display here.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void allClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label2.Text = "Answer";
            result.Text = "0";
        }

        private void allClear_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(allClear, "It resets the calculator.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

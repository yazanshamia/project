using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        string num1_str="";
        string num2_str = "";
        string operaton = "";
        bool enter = false;
        void add_number(string num) {
            if (enter) {
                enter = false;
                
                text.Text = ""; }
            if (text.Text=="0")
                text.Text = num;
            else
                text.Text += num;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            add_number("0");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            add_number("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            add_number("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            add_number("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            add_number("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            add_number("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            add_number("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            add_number("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            add_number("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            add_number("9");
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            text.Clear(); add_number("0");
            label1.Text = "";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            new_operaton("+");
        }

        private void min_Click(object sender, EventArgs e)
        {
            new_operaton("-");
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            new_operaton("*");
        }

        private void Division_Click(object sender, EventArgs e)
        {
            new_operaton("/");
        }


        void new_operaton(string op) {
            operaton = op;
            num1_str = text.Text;
            enter = true;
        }

        private void equl_Click(object sender, EventArgs e)
        {
            num2_str = text.Text;
            num1 = double.Parse(num1_str);
            num2 = double.Parse(num2_str);
            switch (operaton)
            {
                case "+": result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*": result = num1 * num2;
                    break;
                case "/":result = num1 / num2;
                    break;
            }
            string result_str = result.ToString();
            text.Text = result_str;
            label1.Text = num1_str + operaton + num2_str+"=";
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            add_number(".");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public delegate int Operation(int a, int b);
        Operation operation;
        public int bufer;
        public int bufer2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                bufer = System.Convert.ToInt32(textBox1.Text);
                label1.Text = textBox1.Text + "+";
                textBox1.Text = null;
                operation = Calculator.Sum;
            }
            catch
            {
                MessageBox.Show("Некорретные данные");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (operation == null)
                    throw new Exception();
                else
                {
                    try
                    {
                        bufer2 = System.Convert.ToInt32(textBox1.Text);
                        textBox1.Text = System.Convert.ToString(operation(bufer, bufer2));
                        //operation = null;
                        label1.Text = null;
                    }
                    catch
                    {
                        MessageBox.Show("Некорретные данные");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Вы не ввели оператор. выражение некорректно");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                bufer = System.Convert.ToInt32(textBox1.Text);
                label1.Text = textBox1.Text + "-";
                textBox1.Text = null;
                operation = Calculator.Minus;
            }
            catch
            {
                MessageBox.Show("Некорретные данные");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                bufer = System.Convert.ToInt32(textBox1.Text);
                label1.Text = textBox1.Text + "*";
                textBox1.Text = null;
                operation = Calculator.Mult;
            }
            catch
            {
                MessageBox.Show("Некорретные данные");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                bufer = System.Convert.ToInt32(textBox1.Text);
                label1.Text = textBox1.Text + "/";
                textBox1.Text = null;
                operation = Calculator.MainDiv;
            }
            catch
            {
                MessageBox.Show("Некорретные данные");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                bufer = System.Convert.ToInt32(textBox1.Text);
                label1.Text = textBox1.Text + "%";
                textBox1.Text = null;
                operation = Calculator.Residual;
            }
            catch
            {
                MessageBox.Show("Некорретные данные");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bufer = 0;
            label1.Text = null;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                Calculator.memory.Push(System.Convert.ToInt32(textBox1.Text));
                textBox1.Text = null;
            }
            catch
            {
                MessageBox.Show("Некорретные данные");
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = System.Convert.ToString(Calculator.memory.Pop());
            }
            catch
            {
                MessageBox.Show("Память пуста");
            }
        }
    }
}

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
    public partial class basicCalculator : Form
    {
        public basicCalculator()
        {
            InitializeComponent();
        }

        double total = 0;
        double total2 = 0;
        string theOper;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
             
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0"))
                return;
            textBox1.Text += button1.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(button16.Text))
                return;
            else if (textBox1.Text == "")
            {
                textBox1.Text += "0" + button16.Text;
            }
            else
                textBox1.Text += button16.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
                textBox1.Text = textBox1.Text.Remove(0,1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
                textBox1.Clear();
            if (textBox1.Text == "")
                textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            total = total + double.Parse(textBox1.Text);
            textBox1.Clear();

            theOper = "+";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            total = total + double.Parse(textBox1.Text);
            textBox1.Clear();

            theOper = "-";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            total = total + double.Parse(textBox1.Text);
            textBox1.Clear();

            theOper = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            total = total + double.Parse(textBox1.Text);
            textBox1.Clear();

            theOper = "*";
        } 

        private void button17_Click(object sender, EventArgs e)
        {
            switch (theOper)
            {
                case "+" :
                    total2 = total + double.Parse(textBox1.Text);
                break;
                case "-" :
                    total2 = double.Parse(textBox1.Text) - total;
                break;
                case "*" :
                    total2 = total * double.Parse(textBox1.Text);
                break;
                case "/" :
                    total2 = total / double.Parse(textBox1.Text);
                break;
                default :
                    return;
            }
            if (total2 < 0)
            {
                textBox2.Text = "(" + total2.ToString().Remove(0, 1) + ")";
                textBox2.ForeColor = Color.Red;
            }
            else
                textBox2.Text = total2.ToString();
            total = 0;
            textBox1.Clear();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Title = "About Me";
            string Message = "My First Calculator / C# Application \r\nVersion 1.0 \r\nhttp://kylemassacre.com";
            MessageBox.Show(Message, Title);
        }                                                                                                                                         
    }
}

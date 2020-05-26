using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;

        public void disable()
        {
            textBox2.Enabled = false;
            button1.Show();
            button2.Hide();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
        }

        public void enable()
        {
            textBox2.Enabled = true;
            button1.Show();
            button2.Hide();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 7;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 8;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int largo = textBox2.TextLength - 1;
            string text = textBox2.Text;
            textBox2.Clear();
            for(int i; i < largo; i++)
            {
                textBox2.Text = textBox2.Text + text[i];
            }
        }

        public void compute()
        {
            switch(count)
            {
                case 1:
                    ans = num + float.Parse(textBox2.Text);
                    textBox2.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox2.Text);
                    textBox2.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox2.Text);
                    textBox2.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox2.Text);
                    textBox2.Text = ans.ToString();
                    break;
                default:
                    break;



            }

    }
    }
}

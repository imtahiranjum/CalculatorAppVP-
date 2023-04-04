using System;

using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        float _num1, _ans;
        int _count;
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void key1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void key8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void key9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void key4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void key5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void key6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void key2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void key3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void key0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        

        private void keyDot_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text += ".";
            }
        }

        private void keyPlus_Click(object sender, EventArgs e)
        {
            _num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            _count = 2;
        }

        private void keyEquals_Click(object sender, EventArgs e)
        {
            Compute(_count);
        }

        private void keyC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            _count = 0;
        }
        
        private void Compute(int count)
        {
            switch (count)
            {
                case 1:
                    _ans = _num1 - float.Parse(textBox1.Text);
                    textBox1.Text = _ans.ToString();
                    break;
                case 2:
                    _ans = _num1 + float.Parse(textBox1.Text);
                    textBox1.Text = _ans.ToString();
                    break;
                case 3:
                    _ans = _num1 * float.Parse(textBox1.Text);
                    textBox1.Text = _ans.ToString();
                    break;
                case 4:
                    _ans = _num1 / float.Parse(textBox1.Text);
                    textBox1.Text = _ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void keySlash_Click(object sender, EventArgs e)
        {
            _num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            _count = 4;
        }

        private void keyMultiply_Click(object sender, EventArgs e)
        {
            _num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            _count = 3;
        }

        private void keyMinus_Click(object sender, EventArgs e)
        {
            _num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            _count = 1;
        }

        private void key7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
    }
}
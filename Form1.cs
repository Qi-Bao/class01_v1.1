using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class01._1._1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double anwser = 0.00;
        private int time = 60;
        private int secor = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text 这玩意儿装输入的值

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text 给这玩意赋值(最好字符)就可以显示在框label1中，默认似乎是'0'，不显示则text=' '
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            game_01();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (anwser == Convert.ToDouble(textBox1.Text))
            {
                label5.Text = "正   确";
                label4.Text = Convert.ToString("分数：") + Convert.ToString(++secor);
            }
            else
            {
                label5.Text = "错   误";
                label4.Text = Convert.ToString("分数：") + Convert.ToString(--secor);
            }
            game_01();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secor = 0;
            time = 60;
            anwser = 0.00;
            label1.Text = "+";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "分数：0";
            label5.Text = " ";
            //label6.Text = "+";
            // label7.Text = "+";
            label8.Text = "时间：60s";
            textBox1.Text = " ";
            timer1.Enabled = false;
            button2.Enabled = true;
            button1.Enabled = true;
            //textBox1.Enabled = true;
            //panel1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                label8.Text = "时间：" + Convert.ToString(time--) + "s";
            }
            else
            {
                label8.Text = "时间到！";
                button2.Enabled = false;
                button1.Enabled = false;
                timer1.Enabled = false;
                //textBox1.Enabled = false;
               // panel1.Enabled = false;
            }
        }

        private void game_01()
        {
            Random ro = new Random();
            label2.Text = "";
            label3.Text = "";
            label2.Text = label2.Text + ro.Next(10);
            label3.Text = label3.Text + ro.Next(10);
            int s = ro.Next(4);
            switch (s)
            {
                case 0:
                    label1.Text = "+";
                    anwser = Convert.ToDouble(Convert.ToInt32(label2.Text) + (Convert.ToInt32(label3.Text)));
                    break;
                case 1:
                    label1.Text = "-";
                    int q, p, temp;
                    q = Convert.ToInt32(label2.Text);
                    p = Convert.ToInt32(label3.Text);
                    if (q<p)
                    {
                        temp = q;
                        q = p;
                        p = temp;
                    }
                    label2.Text = Convert.ToString(q);
                    label3.Text = Convert.ToString(p);
                    anwser = Convert.ToDouble(q - p);
                    break;
                case 2:
                    label1.Text = "*";
                    anwser = Convert.ToDouble(Convert.ToInt32(label2.Text) * (Convert.ToInt32(label3.Text)));
                    break;
                case 3:
                    label1.Text = "/";
                    if(Convert.ToInt32(label3.Text)==0)
                    {
                        game_01();
                    }
                    anwser = (Convert.ToDouble(label2.Text) / (Convert.ToDouble(label3.Text)));
                    break;
                default:
                    break;
            }
        }

 
    }
}

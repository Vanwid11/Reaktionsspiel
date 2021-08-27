using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reaktionsspiel
{
    public partial class Form1 : Form
    {
        public int countdown = 20;
        public int score;
        public int high;

        public Form1()
        {
            InitializeComponent();
            label2.Hide();
            textBox1.Hide();
            timer2.Start();
            label3.Hide();
            label4.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();

            textBox1.Show();
        }


        private static char GetLetter()
        {
            string chars = "QWERTZUiOPASDFGHJKLYXCVBNM";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Hide();

            textBox1.Show();
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            timer1.Start();

            label2.Text = Convert.ToString(GetLetter());
            label2.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            countdown--;
            label1.Text = Convert.ToString(countdown);

            if (countdown != 0)
            {
                label1.Text = Convert.ToString(countdown);

                if (countdown == 0)
                {
                    timer1.Stop();
                    
                }
            }

            else
            {
                timer1.Stop();
                timer2.Stop();
                label2.Hide();
                label1.Hide();
                textBox1.Hide();

            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == label2.Text.ToLower())
            {
                score++;

                label2.Text = Convert.ToString(GetLetter());
                textBox1.Text = "";
                label3.Text = "Score: " + Convert.ToString(score);
                high = score > high ? score : high;

                label4.Text = "Highscore: " + Convert.ToString(high);

            }

            else
            {
                if (textBox1.Text == "")
                {

                }

                else
                {
                    score--;
                    label3.Text = Convert.ToString(score);
                    label2.Text = Convert.ToString(GetLetter());
                    textBox1.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

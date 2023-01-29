using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aim_training
{
    public partial class Form2 : Form
    {
        Random r = new Random();
        int a, b, i, score, counter;

        private void timer1_Tick(object sender, EventArgs e)
        {

            i = i + 1;
            if (i == 2)
            {
                pictureBox1.Location = new System.Drawing.Point(a, b);
                a = r.Next(0,1820);
                b = r.Next(0,1000);
                i = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;
            timer2.Interval = 1000;
            if (counter >= 30)
            {
                this.Close();
                MessageBox.Show("Your time is up. Your Score: " + score,"İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 fr = new Form1();
                fr.Show();
            }
            else
            {
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult exit;
                exit = MessageBox.Show("Are you sure you want to return to the menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exit == DialogResult.Yes)
                {
                    Form1 fr= new Form1();
                    this.Close();
                    fr.Show();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            a = r.Next(0,1820);
            b = r.Next(0,1000);
            pictureBox1.Location = new System.Drawing.Point(a, b);
            score = score + 1;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
            if(label3.Text == "Dark")
            {
                this.BackColor = Color.Black;
            }

            if (label1.Text == "Crosshair")
            {
                this.Cursor = Cursors.Cross;
            }
            else if (label1.Text == "Default")
            {
                this.Cursor = Cursors.Default;
            }
            else if (label1.Text == "Hand")
            {
                this.Cursor = Cursors.Hand;
            }

            timer1.Enabled = true;
            timer2.Enabled = true;

            if (label2.Text == "Easy")
            {
                timer1.Interval= 700;
            }
            if (label2.Text == "Normal")
            {
                timer1.Interval = 500;
            }
            if (label2.Text == "Hard")
            {
                timer1.Interval = 300;
            }
        }

        private void v(object sender, EventArgs e)
        {

        }
    }
}

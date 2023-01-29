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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            if (rbCrosshair.Checked)
            {
                fr.label1.Text = "Crosshair";
            }
            else if(rbDefault.Checked)
            {
                fr.label1.Text= "Default";
            }
            else if(rbHand.Checked ) {
                fr.label1.Text="Hand";
            }

            if(rbEasy.Checked)
            {
                fr.label2.Text = "Easy";
            }
            else if (rbNormal.Checked)
            {
                fr.label2.Text= "Normal";
            }
            else if (rbHard.Checked)
            {
                fr.label2.Text = "Hard";
            }
            
            if(rbDark.Checked)
            {
                fr.label3.Text = "Dark";
            }
            fr.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 6;
            if (panel1.Width >= 550)
            {
                timer1.Stop();

                Form2 lForm = new Form2();
                lForm.Show();
                this.Hide();
            }      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

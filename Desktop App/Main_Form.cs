using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Desktop_App
{
    public partial class Main_Form : Form
    {
         private int userId;


        public Main_Form(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            addbooks1.SetUserId(userId);
            view_Books1.SetUserId(userId);
            messages1.SetUserId(userId);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form2 lForm = new Form2();
                lForm.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashbord1.Visible = false;
            addbooks1.Visible = false;
            view_Books1.Visible = true;
            messages1.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashbord1.Visible = false;
            addbooks1.Visible = true;
            
            view_Books1.Visible = false;
            messages1.Visible = false;

           // addbooks aForm = addbooks1 as addbooks;
           // if (aForm != null)
           // {
              //  aForm.refreshData();
           // }
        }

        private void dashbord1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashbord1.Visible = true;
            addbooks1.Visible = false;
            view_Books1.Visible = false;
            messages1.Visible = false;
            //  issueBooks1.Visible = false;

            // dashbord dForm = dashbord1 as dashbord;
            // if (dForm != null)
            // {
            //    dForm.refreshData();
            // }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashbord1.Visible = false;
            addbooks1.Visible = false;
            view_Books1.Visible = false;
            messages1.Visible = true;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void view_Books1_Load(object sender, EventArgs e)
        {

        }

        private void messages1_Load(object sender, EventArgs e)
        {

        }
    }
}

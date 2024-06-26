using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Desktop_App
{
    public partial class RequestForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ICT Project\DATA\DATA.mdf;Integrated Security=True;Connect Timeout=30");
        public RequestForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void ownerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(first_name.Text) ||
                string.IsNullOrWhiteSpace(last_Name.Text) ||
                string.IsNullOrWhiteSpace(Adres.Text) ||
                string.IsNullOrWhiteSpace(mobile.Text) ||
                string.IsNullOrWhiteSpace(ownerID.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ICT Project\DATA\DATA.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    connect.Open();
                    DateTime day = DateTime.Today;

                    string insertData = "INSERT INTO RequsetTable (FirstName, LastName, Location1, Mobile, RequestDate, OwnerID) " +
                                        "VALUES (@FirstName, @LastName, @Location1, @Mobile, @RequestDate, @OwnerID)";

                    using (SqlCommand insertCMD = new SqlCommand(insertData, connect))
                    {
                        insertCMD.Parameters.AddWithValue("@FirstName", first_name.Text.Trim());
                        insertCMD.Parameters.AddWithValue("@LastName", last_Name.Text.Trim());
                        insertCMD.Parameters.AddWithValue("@Location1", Adres.Text.Trim());
                        insertCMD.Parameters.AddWithValue("@Mobile", mobile.Text.Trim());
                        insertCMD.Parameters.AddWithValue("@RequestDate", day);
                        insertCMD.Parameters.AddWithValue("@OwnerID", ownerID.Text.Trim());

                        insertCMD.ExecuteNonQuery();

                        MessageBox.Show("Request sent successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        View_Books vForm = new View_Books();
                        vForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

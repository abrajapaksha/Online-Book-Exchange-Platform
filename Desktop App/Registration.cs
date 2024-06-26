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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Desktop_App
{
    public partial class Registration : Form
    {
        SqlConnection connect= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ICT Project\DATA\DATA.mdf;Integrated Security=True;Connect Timeout=30");
        public Registration()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Register_email.Text == "" || Register_Username.Text == "" || Register_Password.Text == "")
            {
                MessageBox.Show("Please fill all the data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String checkUsername = "SELECT COUNT(*) FROM users WHERE username = @username";

                        using (SqlCommand checkCMD = new SqlCommand(checkUsername, connect))
                        {
                            checkCMD.Parameters.AddWithValue("@username", Register_Username.Text.Trim());
                            int count = (int)checkCMD.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(Register_Username.Text.Trim()
                                    + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // TO GET THE DATE TODAY
                                DateTime day = DateTime.Today;

                                String insertData = "INSERT INTO users (email, username, password, date_register) " +
                                    "VALUES(@email, @username, @password, @date)";


                                using (SqlCommand insertCMD = new SqlCommand(insertData, connect))
                                {
                                    insertCMD.Parameters.AddWithValue("@email", Register_email.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@username", Register_Username.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@password", Register_Password.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@date", day.ToString());

                                    insertCMD.ExecuteNonQuery();

                                    MessageBox.Show("Register successfully!", "Information Message"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form2 lForm = new Form2();
                                    lForm.Show();
                                    this.Hide();
                                }
                                
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connect.Close(); }

                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 lform = new Form2();
            lform.Show();
            this.Hide();
        }

        private void Register_Pconfirm_CheckedChanged(object sender, EventArgs e)
        {
            Register_Password.PasswordChar = Register_Pconfirm.Checked ? '\0' : '*';
        }

        private void Register_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}

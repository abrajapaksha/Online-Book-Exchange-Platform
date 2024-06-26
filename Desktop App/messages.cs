using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App
{
    public partial class messages : UserControl
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ICT Project\\DATA\\DATA.mdf;Integrated Security=True;Connect Timeout=30;";
        private Timer refreshTimer;
        private int userId;


        public messages()
        {
            InitializeComponent();
            InitializeTimer();
           // LoadMessageData();
        }
        public void SetUserId(int userId)
        {
            this.userId = userId;
            LoadMessageData();

        }
        private void InitializeTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 60000; // Refresh interval in milliseconds (60 seconds)
            refreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadMessageData();
        }

        private void LoadMessageData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM RequsetTable WHERE OwnerID = @userId";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand(query, conn);
                        cmd1.Parameters.AddWithValue("@userId", userId);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                        DataTable tasksTable = new DataTable();

                        conn.Open();
                        adapter.Fill(tasksTable);
                        conn.Close();

                        dataGridView1.DataSource = tasksTable;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                // Placeholder for any cell content click event handling for Book_Data
                // Check that the click is on a valid cell (not header or empty row)
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Extract data from the selected row
                    //string title = row.Cells["book_title"].Value.ToString();
                    //string author = row.Cells["author"].Value.ToString();
                    //string publishedDate = row.Cells["published_date"].Value.ToString();


                   // int userId1 = Convert.ToInt32(row.Cells["userid1"].Value);
                   // int bookId = Convert.ToInt32(row.Cells["id"].Value);

                    // Populate the text boxes with the retrieved data
                   
                }
            
        }
    }
}

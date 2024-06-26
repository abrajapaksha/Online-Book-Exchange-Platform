using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;
using System.Collections;
namespace Desktop_App
{
    public partial class addbooks : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ICT Project\DATA\DATA.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private int userId;
        
        public addbooks()
        {
            
            InitializeComponent();
            string query = "SELECT id, book_title, author, published_date, status, date_insert, date_delete FROM books WHERE userid1 = @userId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@UserID", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable tasksTable = new DataTable();

                conn.Open();
                adapter.Fill(tasksTable);
                conn.Close();

                dataGridView1.DataSource = tasksTable;
            }




          //  DataTable data = displayBooks(query);
           // dataGridView1.DataSource = data;
            // Update the connection string to disable encryption
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ICT Project\DATA\DATA.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
           // displayBooks();
            InitializeDataGridView();
            refreshData();
            

        }
        public void SetUserId(int userId)
        {
            this.userId = userId;
            refreshData();
        }
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ICT Project\\DATA\\DATA.mdf;Integrated Security=True;Connect Timeout=30;";

        
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            // displayBooks();
            string query = "SELECT id, book_title, author, published_date, status, date_insert, date_delete FROM books WHERE userid1 = @userId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@UserID", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable tasksTable = new DataTable();

                conn.Open();
                adapter.Fill(tasksTable);
                conn.Close();

                dataGridView1.DataSource = tasksTable;
            }
        }
        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {




            if (ADD_Picture.Image == null
    || Title.Text == ""
    || Author.Text == ""
    || published.Value == null
    || status.Text == ""
    || ADD_Picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        connect.Open();
                        string insertData = "INSERT INTO books " +
                            "(book_title, author, published_date, status, image, date_insert,userid1) " +
                            "VALUES(@bookTitle, @author, @published_date, @status, @image, @dateInsert,@userId)";

                        string path = Path.Combine(@"D:\ICT Project\Desktop App\Desktop App\Books_Diractry\" +
                            Title.Text + Author.Text.Trim() + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        File.Copy(ADD_Picture.ImageLocation, path, true);

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookTitle", Title.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", Author.Text.Trim());
                            cmd.Parameters.AddWithValue("@published_date", published.Value);
                            cmd.Parameters.AddWithValue("@status", status.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@dateInsert", today);
                            cmd.Parameters.AddWithValue("@userId", userId);

                            cmd.ExecuteNonQuery();

                            


                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            string query = "SELECT id, book_title, author, published_date, status, date_insert, date_delete FROM books WHERE userid1 = @userId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tasksTable = new DataTable();

                conn.Open();
                adapter.Fill(tasksTable);
                conn.Close();

                dataGridView1.DataSource = tasksTable;
            }
        }
        private String imagePath;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    ADD_Picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearFields()
        {
            Title.Text = "";
            Author.Text = "";
            ADD_Picture.Image = null;
            status.SelectedIndex = -1;
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            
            
           clearFields();
            
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable displayBooks(string query)
        {
            // DataAddBooks dab = new DataAddBooks();
            // List<DataAddBooks> listData = dab.addBooksData();

            //dataGridView1.DataSource = listData;
            //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ICT Project\DATA\DATA.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
            using (SqlConnection conn = GetConnection()) {
                
                
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                
            }
            
        }
        private int bookID = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookID = (int)row.Cells[0].Value;
                Title.Text = row.Cells[1].Value.ToString();
                Author.Text = row.Cells[2].Value.ToString();
                published.Text = row.Cells[3].Value.ToString();

                object imagePathObj = row.Cells[4].Value;
                string imagePath = imagePathObj != DBNull.Value ? imagePathObj.ToString() : null;

                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        ADD_Picture.Image = Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ADD_Picture.Image = null; // Clear the picture box in case of error
                    }
                }
                else
                {
                    ADD_Picture.Image = null; // No image path provided
                }

                status.Text = row.Cells[5].Value.ToString();
            }
        }


        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (//ADD_Picture.Image == null
                 Title.Text == ""
                || Author.Text == ""
                || published.Value == null
                || status.Text == ""
                //|| ADD_Picture.Image == null
                )
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Book ID:"
                        + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET book_title = @bookTitle" +
                                ", author = @author, published_date = @published" +
                                ", status = @status WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@bookTitle", Title.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", Author.Text.Trim());
                                cmd.Parameters.AddWithValue("@published", published.Value);
                                cmd.Parameters.AddWithValue("@status", status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                // displayBooks();
                                string query = "SELECT id, book_title, author, published_date, status, date_insert, date_delete FROM books WHERE userid1 = @userId";
                                using (SqlConnection conn = new SqlConnection(connectionString))
                                {
                                    SqlCommand cmd1 = new SqlCommand(query, conn);
                                    cmd1.Parameters.AddWithValue("@UserID", userId);

                                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                                    DataTable tasksTable = new DataTable();

                                    conn.Open();
                                    adapter.Fill(tasksTable);
                                    conn.Close();

                                    dataGridView1.DataSource = tasksTable;
                                }

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }


        private void DELETE_Click(object sender, EventArgs e)
        {

            if (//ADD_Picture.Image == null
                 Title.Text == ""
                || Author.Text == ""
                || published.Value == null
                || status.Text == ""
               // || ADD_Picture.Image == null
                )
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Book ID:"
                        + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET date_delete = @dateDelete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                // displayBooks();
                                string query = "SELECT id, book_title, author, published_date, status, date_insert, date_delete FROM books WHERE userid1 = @userId";
                                using (SqlConnection conn = new SqlConnection(connectionString))
                                {
                                    SqlCommand cmd1 = new SqlCommand(query, conn);
                                    cmd1.Parameters.AddWithValue("@UserID", userId);

                                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                                    DataTable tasksTable = new DataTable();

                                    conn.Open();
                                    adapter.Fill(tasksTable);
                                    conn.Close();

                                    dataGridView1.DataSource = tasksTable;
                                }

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

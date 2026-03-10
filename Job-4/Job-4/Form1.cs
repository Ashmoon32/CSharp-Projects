using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient; // Required for SQL Server

namespace Job_4
{
    public partial class Form1 : Form
    {
        // Replace this string with your actual Connection String from Database Properties
        // Use this format for local .mdf files
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\C# projects collection\Job-4\Job-4\Database1.mdf"";Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Helper method to refresh the DataGridView
        private void DisplayData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Customers", con);
                adapt.Fill(dt);
                dgvCustomers.DataSource = dt; // Ensure your DataGridView ID is dataGridView1
            }
        }

        // VIEW Button - Fetches data and shows it in the grid
        private void btnView_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        // INSERT Button
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtFN.Text != "" && txtLN.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Customers(FirstName, LastName) VALUES(@fn, @ln)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@fn", txtFN.Text);
                    cmd.Parameters.AddWithValue("@ln", txtLN.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted Successfully");
                    DisplayData();
                }
            }
            else
            {
                MessageBox.Show("Please provide details!");
            }
        }

        // UPDATE Button - Updates record based on FirstName (or ID if you add a hidden field)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Customers SET LastName=@ln WHERE FirstName=@fn", con);
                con.Open();
                cmd.Parameters.AddWithValue("@fn", txtFN.Text);
                cmd.Parameters.AddWithValue("@ln", txtLN.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                DisplayData();
            }
        }

        // DELETE Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE FirstName=@fn", con);
                con.Open();
                cmd.Parameters.AddWithValue("@fn", txtFN.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                DisplayData();
            }
        }

        // SEARCH Button (button4)
        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Customers WHERE FirstName LIKE '" + txtSearch.Text + "%'", con);
                adapt.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Load data automatically when form opens
            // DisplayData();
        }

        // Leave these empty if you don't need logic while typing
        private void txtFN_TextChanged(object sender, EventArgs e) { }
        private void txtLN_TextChanged(object sender, EventArgs e) { }
        private void txtSearch_TextChanged(object sender, EventArgs e) { }
    }
}
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

namespace Ch_4
{
    public partial class Form1 : Form
    {
        // Using your specific Connection String and Database Path
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\C# projects collection\Ch-4\Ch-4\Database1.mdf"";Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Helper method to clear text boxes
        private void ClearTextBoxes()
        {
            txtFN.Text = "";
            txtLN.Text = "";
        }

        // 2. Load Data when Form starts
        private void Form1_Load(object sender, EventArgs e)
        {
            // Instead of the TableAdapter (which requires a Wizard), 
            // we call our manual View button logic to fill the grid.
            btnView_Click(null, null);
        }

        // 3. VIEW/REFRESH RECORD
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Customers", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // 4. INSERT RECORD
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtFN.Text == "" || txtLN.Text == "")
            {
                MessageBox.Show("Please enter both First Name and Last Name.");
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                cmd = new SqlCommand("INSERT INTO Customers (FirstName, LastName) VALUES (@fn, @ln)", con);
                cmd.Parameters.AddWithValue("@fn", txtFN.Text);
                cmd.Parameters.AddWithValue("@ln", txtLN.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record inserted successfully.");
                ClearTextBoxes();
                btnView_Click(null, null); // Refresh the list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        // 5. UPDATE RECORD
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Please select a record from the grid to update.");
                return;
            }

            int custID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);

            try
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Customers SET FirstName=@fn, LastName=@ln WHERE CustID=@id", con);
                cmd.Parameters.AddWithValue("@fn", txtFN.Text);
                cmd.Parameters.AddWithValue("@ln", txtLN.Text);
                cmd.Parameters.AddWithValue("@id", custID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record updated successfully.");
                ClearTextBoxes();
                btnView_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        // 6. SEARCH RECORD
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM Customers WHERE FirstName LIKE @search OR LastName LIKE @search", con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        // 7. DELETE RECORD
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            int custID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);

            try
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Customers WHERE CustID=@id", con);
                cmd.Parameters.AddWithValue("@id", custID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully.");
                ClearTextBoxes();
                btnView_Click(null, null);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
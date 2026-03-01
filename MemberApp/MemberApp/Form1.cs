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

namespace MemberApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=MemberDB;Integrated Security=True";

            string query = "INSERT INTO Members(FullName , Email) VALUES (@Name, @Email)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            MessageBox.Show("Save Successfully!");
            LoadData();

        }

        void LoadData()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=MemberDB;Integrated Security=True";
            string query = "SELECT * FROM Members";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvMembers.DataSource = dt;
            }
        }
    }
}

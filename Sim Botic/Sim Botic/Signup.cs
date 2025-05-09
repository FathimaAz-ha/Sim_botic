using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sim_Botic
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            this.Load += Signup_Load;
        }
        config o = new config();
        private void Signup_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Get input from textboxes
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate inputs
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
               else

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            using (SqlConnection con = new SqlConnection(o.con.ConnectionString))
            {
                con.Open();
                string qry = "INSERT INTO [Table] ([Username], [Password], [Confirm Password]) VALUES (@username, @password, @confirmPassword)";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@confirmPassword", txtConfirmPassword.Text);

                    cmd.ExecuteNonQuery();
                    // If validation succeeds, redirect to DashboardForm
                    MessageBox.Show("Sign-Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide(); // Optional: Hide the Sign-Up Form
                }
            }
        }

        private void Signup_Load_1(object sender, EventArgs e)
        {

        }
    }
        

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sim_Botic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        config o = new config();
        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection con = new SqlConnection(o.con.ConnectionString))
            {
                // con.Open();
                string qry = "SELECT COUNT(*) FROM [Table] WHERE [Username]=@username AND [Password]=@password";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    // Validation for Username and Password
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {


                        // Redirect to dashboard
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                    if (string.IsNullOrWhiteSpace(username))
                    {
                        MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(password))
                    {
                        MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Focus();
                        return;
                    }
                }
            }
        }
                    private void btnSignup_Click(object sender, EventArgs e)
        {
            // Redirect to Signup Form
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Font = new Font("Segoe UI", 12); // Change Font Size
            txtUsername.Height = 30;                    // Adjust the height
            txtUsername.Padding = new Padding(0, 5, 0, 5); // Apply padding (if using Guna2TextBox)
        }
    }
   }
        
        

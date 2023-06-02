using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusTicketingSystem
{
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Daniyal\SQLEXPRESS;Initial Catalog=BusSystem;Integrated Security=True");
            conn.Open();
            string name = txtName.Text;
            string cnic = txtCNIC.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
         
             
            // Regex pattern for email validation
            string pattern_email = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"; 
            // Check if the email matches the pattern
            bool isValidEmail = Regex.IsMatch(email, pattern_email);

            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Enter Name", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
            
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please Enter Email Address", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtCNIC.Text))
            {
                MessageBox.Show("Please Enter CNIC number", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Your Password", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isValidEmail)
            {
                MessageBox.Show("Invalid email address", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string query = "INSERT INTO UserDetails   VALUES ('" + name + "','" + email + "' ,'" + password + "', '" + cnic + "' )";
                SqlCommand cmd = new SqlCommand(query, conn);
                int res= cmd.ExecuteNonQuery();
                
                if (res > 0)
                {
                    MessageBox.Show("Account Created Successfully");
                    txtName.Clear();
                    txtPassword.Clear();
                    txtCNIC.Clear();
                     
                    txtEmail.Clear();
                    this.Hide();
                    UserLogin user=new UserLogin();
                    user.Show();
                   
                    conn.Close();
                }


            }








        }
    }
}

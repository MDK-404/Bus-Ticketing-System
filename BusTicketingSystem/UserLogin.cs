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

namespace BusTicketingSystem
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createaccount create = new createaccount();
            this.Hide();
            create.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Daniyal\SQLEXPRESS;Initial Catalog=BusSystem;Integrated Security=True");
            conn.Open();
            string qry ="Select * FROM UserDetails WHERE Name= '"+txtUser.Text+ "' and Password='" +txtPassword.Text +"'";
            SqlDataAdapter adp=new SqlDataAdapter(qry,conn);
            DataTable dt=new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                UserDashBoard user=new UserDashBoard();
                this.Hide();
                user.Show();

            }
            else if ((String.IsNullOrEmpty(txtUser.Text)))
            {
                MessageBox.Show("Please Enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((String.IsNullOrEmpty(txtPassword.Text)))
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main obj= new Main();
            this.Hide();
            obj.Show();

        }
    }
}

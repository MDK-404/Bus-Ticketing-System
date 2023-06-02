using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Hide(); 
            adminDashboard.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserLogin userlogin = new UserLogin();
            this.Hide();
            userlogin.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

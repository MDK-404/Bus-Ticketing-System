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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            AddBuses addbus = new AddBuses();
            this.Hide();
            addbus.Show();
        }

        private void btnViewBus_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Daniyal\SQLEXPRESS;Initial Catalog=BusSystem;Integrated Security=True");
            conn.Open();

            // Query to fetch all buses from the database
            string query = "SELECT * FROM bus";

             
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                         
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dgvViewBusses.Visible= true;
                        dgvViewBusses.DataSource = dataTable;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main objmain = new Main();
            this.Hide();
            objmain.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

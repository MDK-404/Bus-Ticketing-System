using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace BusTicketingSystem
{
    public partial class AddBuses : Form
    {
        public AddBuses()
        {
            InitializeComponent();
        }

        private void tx_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Daniyal\SQLEXPRESS;Initial Catalog=BusSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.addbus", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Bus_No", txtBusNo.Text));
            cmd.Parameters.Add(new SqlParameter("@Total_Seats", txtSeats.Text));
            cmd.Parameters.Add(new SqlParameter("@Departure_City", txtDepartureCity.Text));
            cmd.Parameters.Add(new SqlParameter("@Arrival_City", txtArrivalCity.Text));
            cmd.Parameters.Add(new SqlParameter("@Date", busdate.Value));


            int res= cmd.ExecuteNonQuery();
            
            if(String.IsNullOrEmpty(txtBusNo.Text))
                {
                    MessageBox.Show("Please ENter  Details");
                }
            else if (String.IsNullOrEmpty(txtSeats.Text))
            {
                MessageBox.Show("Please ENter  Complete Details");
            }
            else if (String.IsNullOrEmpty(txtDepartureCity.Text))
            {
                MessageBox.Show("Please ENter Complete Details");
            }
            else if (String.IsNullOrEmpty(txtArrivalCity.Text))
            {
                MessageBox.Show("Please ENter Complete Details");
            }
            else
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Bus_No", txtBusNo.Text));
                cmd.Parameters.Add(new SqlParameter("@Total_Seats", txtSeats.Text));
                cmd.Parameters.Add(new SqlParameter("@Departure_City", txtDepartureCity.Text));
                cmd.Parameters.Add(new SqlParameter("@Arrival_City", txtArrivalCity.Text));
                cmd.Parameters.Add(new SqlParameter("@Date", busdate.Value));
                if  (res > 0)
                    {
                        MessageBox.Show("Bus Added Successfully");
                        txtBusNo.Clear();
                        txtSeats.Clear();
                        txtDepartureCity.Clear();
                        txtArrivalCity.Clear();


                        conn.Close();
                    }

            }


        }

        private void busdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminobject= new AdminDashboard();
            this.Hide();
            adminobject.Show();
        }

        private void AddBuses_Load(object sender, EventArgs e)
        {

        }
    }
}

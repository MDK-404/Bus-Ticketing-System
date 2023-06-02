using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BusTicketingSystem
{
  

    public partial class UserDashBoard : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=Daniyal\SQLEXPRESS;Initial Catalog=BusSystem;Integrated Security=True");
         
        public UserDashBoard()
        {
            InitializeComponent();
        }
        void LoadDepartureCombobox()
        {
            
            string qry = "Select Distinct Departure_City FROM Bus";
            
            SqlDataAdapter adp = new SqlDataAdapter(qry,conn);
            DataTable dt=new DataTable();
            adp.Fill(dt);
            cmbDeparture.DataSource= dt;
            cmbDeparture.DisplayMember = "Departure_City";
            

        }
        void LoadArrivalCombobox()
        {
            
            string qry = "Select Distinct Arrival_City FROM Bus ";
             

            SqlDataAdapter adp = new SqlDataAdapter(qry, conn);
            DataTable dtarrival = new DataTable();
            adp.Fill(dtarrival);
            cmbArrival.DataSource = dtarrival;
            cmbArrival.DisplayMember = "Arrival_City";
            

        }
        
        private void UserDashBoard_Load(object sender, EventArgs e)
        {

            LoadDepartureCombobox();
            LoadArrivalCombobox();

        }
       
        private void removeSelectedItemFromArrivalComboBox(string selectedDepartureCity)
        {
            conn.Open();
            string query = $@"SELECT Distinct Arrival_City FROM Bus WHERE NOT Arrival_City = '{selectedDepartureCity}'";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataTable datatable = new DataTable();
            adp.Fill(datatable);
            cmbArrival.DataSource = null;
            cmbArrival.DataSource = datatable;
            cmbArrival.DisplayMember = "Arrival_City";
            conn.Close();

            
        }


        private void cmbDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
             string selectedDepartureCity = cmbDeparture.Text;
            
            removeSelectedItemFromArrivalComboBox(selectedDepartureCity);
            

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Main mainmenu = new Main();
            this.Hide();
            mainmenu.Show();
        }

        private void btnFindBus_Click(object sender, EventArgs e)
        {


            string selectedDepartureCity = cmbDeparture.Text;
            string selectedArrivalCity = cmbArrival.Text;
            DateTime selectedDate = dateTimePicker1.Value.Date;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            Console.WriteLine(formattedDate);
            // Find available buses based on selected departure city, arrival city, and date
            conn.Open();
            string qry = $@"SELECT Bus_No, Total_Seats FROM bus WHERE Departure_City = '{selectedDepartureCity}' AND Arrival_City = '{selectedArrivalCity}' AND CONVERT(date, DATE) = '{formattedDate}'";


            SqlDataAdapter adp = new SqlDataAdapter(qry, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmbAvailablebus.DataSource = dt;
            cmbAvailablebus.DisplayMember = "Bus_No";
            cmbAvailablebus.ValueMember= "Bus_No";
            conn.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            int busno = (int)cmbAvailablebus.SelectedValue;
            string numberOfSeats =  txtSeats.Text;
            string pattern_seats= @"^(?:[1-9]|1\d|20)$";
            bool isValidSeat= Regex.IsMatch(numberOfSeats, pattern_seats);
            
            if (!isValidSeat)
            {
                // Display the error message
                MessageBox.Show("Please enter a valid number of seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            else
            {
                // Display an confirmation message if the input is invalid
                MessageBox.Show($"Your {numberOfSeats} seat(s) have been booked in Bus No {busno}", "Seat Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSeats.Clear();
                cmbAvailablebus.SelectedIndex = -1;
                cmbDeparture.SelectedIndex = -1;
                cmbArrival.SelectedIndex = -1;
            }
        }
    }
}

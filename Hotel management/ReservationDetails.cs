using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Data provider*/
using System.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using System.Net;

namespace Hotel_management
{
    public partial class ReservationDetails : Form
    {
        public ReservationDetails()
        {
            InitializeComponent();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable maximize box
            this.MaximizeBox = false;

            // Disable minimize box
            this.MinimizeBox = false;

            // Set form border style to fixed single
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ReservationDetails_Load(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelM_db;Integrated Security=True;");
            SqlCommand insert = new SqlCommand("insert into Reservation values('" +
                RID.Text + "','" + name.Text + "','" +
                address.Text + "','" +
                room.Text + "')", con); con.Open();
            insert.CommandType = CommandType.Text;
            insert.ExecuteNonQuery();
            MessageBox.Show("Data Added Successfully");
            con.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelM_db;Integrated Security=True;");
            SqlCommand update = new SqlCommand("update Reservation set " +
                "name = '" + name.Text + "'," +
                "address = '" + address.Text + "', " +
                "room = '" + room.Text + "' " +
                "where id = '" + RID.Text + "'", con);
            con.Open();
            update.CommandType = CommandType.Text;
            update.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully");
            con.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelM_db;Integrated Security=True;");
            SqlCommand delete = new SqlCommand("delete from Reservation where id = '" + RID.Text + "'", con);
            con.Open();
            delete.CommandType = CommandType.Text;
            delete.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully");
            con.Close();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            RID.Clear();
            name.Clear();
            address.Clear();
            room.Clear();
        }
    }
}

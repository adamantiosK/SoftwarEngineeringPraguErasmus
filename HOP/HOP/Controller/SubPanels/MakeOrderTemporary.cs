using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOP.Model;
using MediaFoundation.OPM;

namespace HOP
{
    public partial class MakeReservationTemporary : UserControl
    {
        public MakeReservationTemporary()
        {
            InitializeComponent();
        }



        private List<String> GetDataFromDatabase()
        {
            List<String> rooms = new List<String>();

            string queryString1 = "SELECT RoomNumber  FROM Room WHERE RoomNumber IN (SELECT RoomNumber FROM ReservationOfRoomR WHERE ReservationID IN (SELECT ReservationID FROM Reservation  WHERE GETDATE() > StartOfReservation AND GETDATE() < EndOfReservation AND ReservationID IN(SELECT ReservationID FROM Residence)))";
          

            using (SqlConnection connection = new SqlConnection(
                Form1._connectionString))
            {
                SqlCommand command1 = new SqlCommand(
                    queryString1, connection);

                connection.Open();
                SqlDataReader reader1 = command1.ExecuteReader();

                try
                {
                    while (reader1.Read())
                    {
                        string RoomID = (Convert.ToString(reader1[0]));
                        rooms.Add(RoomID);
                    }
                }
                finally
                {
                    reader1.Close();
                }

                connection.Close();
            }

           

            return rooms;
        }


        private void SendOrderTomDatabase(int roomNumber , string comment )
        {
            try { 
            string queryString1 = "INSERT INTO FoodOrder(RoomNumber, ResidenceID, Time, Comment, OrderStatus) VALUES("+roomNumber+ ",3,'"+DateTime.Now+"', '"+comment+"', 'NotDone')";

            using (SqlConnection connection = new SqlConnection(
                Form1._connectionString))
            {
                SqlCommand command1 = new SqlCommand(
                    queryString1, connection);

                connection.Open();
                SqlDataReader reader1 = command1.ExecuteReader();

                try
                {
                    while (reader1.Read())
                    {
                    }
                }
                finally
                {
                    reader1.Close();
                }

                connection.Close();
            }
            }catch(Exception e){ }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Items.Count > 0)
                comboBox1.Items.Clear();

            List<String> rooms = GetDataFromDatabase();
            for (int i = 0; i < rooms.Count; i++)
            {
                comboBox1.Items.Add(rooms[i]);
            }
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Items.Count != 0)
            {
                SendOrderTomDatabase(Convert.ToInt32(comboBox1.SelectedItem), textBox1.Text);
                textBox1.Text = "";
                comboBox1.SelectedIndex = -1;
            }
        }
    }
}

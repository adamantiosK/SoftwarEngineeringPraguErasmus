using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HOP.Model;
using VisioForge.MediaFramework.deviceio;
using DateTime = System.DateTime;

namespace HOP
{
    public partial class CleaningPanel : UserControl
    {

        private CleaningStaff _cleaner ;
        private List<CleaningStaff> _cleaners = new List<CleaningStaff>();
        public CleaningPanel()
        {
            InitializeComponent();
        }

        private void PopulateItems()
        {
            List<Room> rooms = GetDataFromDatabase();

            List<Reservation> reservations = GetDataFromDatabase2();


            int amount = rooms.Count;
            if (flowLayoutPanel1.Controls.Count != 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            RoomControlPanel[] listItems = new RoomControlPanel[amount];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new RoomControlPanel
                {
                    RoomNumber = rooms[i].GetRoomID,
                    Services1 = GetService3(reservations[i].EndOfReservation),
                    Services2 = GetService2(reservations[i].StartOfReservation),
                    Services3 = GetService1(reservations[i].StartOfReservation),
                    Status = rooms[i].GetState,
                    NumberWorking = rooms[i].GetNumber,
                    Cleaners = _cleaner.ReturnIDList(_cleaners)
                };
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();

                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }

            }
        }

        private string GetService1(DateTime Start)
        {
            String record = "";
            DateTime NOW = DateTime.Now;
            TimeSpan difference = NOW - Start;

            if (difference.Days % 3 == 0 && difference.Days%4 == 0)
            {
                record = "Towel Change";
              
            }
            return record;
        }

        private string GetService2(DateTime Start)
        {
            String record = "";
            DateTime NOW = DateTime.Now;
            TimeSpan difference = NOW - Start;
            if (difference.Days % 4 == 0)
            {
                record = "Change Sheets";
            }else if (difference.Days % 3 == 0)
            {
                record = "Towel Change";
            }

            return record;
        }

        private string GetService3(DateTime Stop)
        {
            String record = "Clean Up";
            DateTime NOW = DateTime.Now;
            TimeSpan difference = NOW - Stop;
            if (difference.Days == 0)
            {
                record = "Check Out Clean Up";
            }
            return record;
        }


        private List<Room> GetDataFromDatabase()
        {
            List<Room> rooms = new List<Room>();

            string queryString1 =
                "SELECT RoomNumber , CleaningStatus , NumberOfCleaners FROM Room WHERE RoomNumber IN (SELECT RoomNumber FROM ReservationOfRoomR WHERE ReservationID IN (SELECT ReservationID FROM Reservation  WHERE GETDATE() > StartOfReservation AND GETDATE() < EndOfReservation AND ReservationID IN(SELECT ReservationID FROM Residence)))";
            string queryString2 = "SELECT TOP(1000) [CleaningStaffID] FROM[DB_A5088F_HOTELdb].[dbo].[CleaningStaff]";


            using (SqlConnection connection = new SqlConnection(
                Form1._connectionString))
            {
                SqlCommand command1 = new SqlCommand(
                    queryString1, connection);
                SqlCommand command2 = new SqlCommand(
                    queryString2, connection);
           
                connection.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                
                try
                {
                    while (reader1.Read())
                    {
                        string RoomID = (Convert.ToString(reader1[0]));
                        string RoomState = (Convert.ToString(reader1[1]));
                        string Number = (Convert.ToString(reader1[2]));

                        Room room1 = new Room(RoomID, RoomState, Number);
                        rooms.Add(room1);
                    }
                }
                finally
                {
                    reader1.Close();
                }

                SqlDataReader reader2 = command2.ExecuteReader();
                try
                {
                    while (reader2.Read())
                    {
                        _cleaner = new CleaningStaff(Convert.ToInt16(reader2[0]));
                        _cleaners.Add(_cleaner);

                    }
                }
                finally
                {
                    reader2.Close();
                }
                connection.Close();
            }
            return rooms;
        }

        private List<Reservation> GetDataFromDatabase2()
        {
            List<Reservation> reservations = new List<Reservation>();

           
            string queryString3 = "SELECT StartOfReservation , EndOfReservation FROM Reservation WHERE GETDATE() >= StartOfReservation AND GETDATE() <= EndOfReservation AND ReservationID IN(SELECT ReservationID	 FROM Residence)";

            using (SqlConnection connection = new SqlConnection(
                Form1._connectionString))
            {

                SqlCommand command3 = new SqlCommand(
                    queryString3, connection);

                connection.Open();
                SqlDataReader reader3 = command3.ExecuteReader();
                try
                {
                    while (reader3.Read())
                    {
                        DateTime CheckIn = Convert.ToDateTime((Convert.ToString(reader3[0])));
                        DateTime CheckOut = Convert.ToDateTime((Convert.ToString(reader3[1])));
                        Reservation reservation1 = new Reservation(CheckIn,CheckOut );
                        reservations.Add(reservation1);
                    }
                }
                finally
                {
                    reader3.Close();
                }

                connection.Close();
            }

            return reservations;
        }

        private void RefreshRooms_Click(object sender, EventArgs e)
        {
            PopulateItems();
        }
    }
}
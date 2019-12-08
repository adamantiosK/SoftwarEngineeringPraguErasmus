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
using HOP.Data.DAO;
using HOP.Model;
using VisioForge.MediaFramework.deviceio;
using DateTime = System.DateTime;

namespace HOP
{
    public partial class CleaningPanel : UserControl
    {

        private List<CleaningStaff> _cleaners = new List<CleaningStaff>();


        public CleaningPanel()
        {
            InitializeComponent();
        }


        // Mehod that is populating the RoomControl Panel user controls base on the amount of the available data
        private void PopulateItems()
        {
            _cleaners.Clear();
            List<Room> rooms = RoomsDAO.GetRoomsOfResidence();
            _cleaners = CleaningStaffDAO.GetCleaningStaffList();
            List<Reservation> reservations = ReservationDAO.GetReservationDetails();


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
                    Cleaners = _cleaners[0].ReturnIDList(_cleaners)
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


        // Get the first service for the room
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
        // Get the second service for the room
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
        // Get the third service for the room
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
        
        // Refresh mehod responsible for updating the list to the latest one.
        private void RefreshRooms_Click(object sender, EventArgs e)
        {
            PopulateItems();
        }
    }
}
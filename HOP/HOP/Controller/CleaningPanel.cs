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
                    Services1 = "Towel Change",
                    Services2 = "Sheets Change",
                    Services3 = "Clean Up",
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


        private List<Room> GetDataFromDatabase()
        {
            List<Room> rooms = new List<Room>();

            string queryString1 =
                "SELECT TOP(1000) RoomNumber , CleaningStatus , NumberOfCleaners FROM Room WHERE CleaningStatus = 'notdone' OR CleaningStatus = 'InProgress'";
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



        private void RefreshRooms_Click(object sender, EventArgs e)
        {
            PopulateItems();
        }
    }
}
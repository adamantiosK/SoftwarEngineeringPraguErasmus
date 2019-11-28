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

namespace HOP
{
    public partial class CleaningPanel : UserControl
    {

        private readonly string _connectionString = "";


        public CleaningPanel()
        {
            InitializeComponent();
        }

        private void PopulateItems(int amount)
        {
            if (flowLayoutPanel1.Controls.Count != 0)
            {
                flowLayoutPanel1.Controls.Clear();

            }

            RoomControlPanel[] listItems = new RoomControlPanel[amount];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new RoomControlPanel
                {
                    RoomNumber = (i + 1).ToString(),
                    Services1 = "Tower Change",
                    Services2 = "Sheets Change",
                    Services3 = "Clean Up"
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


        private void GetDataFromDatabase()
        {
            string queryString =
                "SELECT Rooms,Services, State FROM dbo.ROOMS;";
            using (SqlConnection connection = new SqlConnection(
                _connectionString))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        //Retrives only information for rooms either not done or in progress of the day;

                        //  String that holds Room Number(Convert.ToStrint(reader[0]));
                        //  String that holds services to be done(Convert.ToStrint(reader[1]));
                        //in case int is >0 than turn state ( color ) to in progress 
                        //  String that returns int of people working on the application(Convert.ToStrint(reader[2]));
                    }
                }
                finally
                {
                    reader.Close();
                }
                connection.Close();
            }
        }



        private void RefreshRooms_Click(object sender, EventArgs e)
        {

            PopulateItems(12);
        }
    }
}

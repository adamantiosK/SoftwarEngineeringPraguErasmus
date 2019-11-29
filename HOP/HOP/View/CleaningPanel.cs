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

        private readonly string _connectionString = "Server=localhost;Database=SoftwareEngineering;Trusted_Connection=True;";

        private List<String> Cleaners = new List<String>();
        public CleaningPanel()
        {
            InitializeComponent();
        }

        private void PopulateItems()
        {

            DataSet data = GetDataFromDatabase();

            int amount = data.Tables[0].Rows.Count;


            if (flowLayoutPanel1.Controls.Count != 0)
            {
                flowLayoutPanel1.Controls.Clear();
                
            }

            RoomControlPanel[] listItems = new RoomControlPanel[amount];
            
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new RoomControlPanel
                {
                    RoomNumber = data.Tables[0].Rows[i]["id"].ToString(),
                    Services1 = "Tower Change",
                    Services2 = "Sheets Change",
                    Services3 = "Clean Up",
                    Status = data.Tables[0].Rows[i]["State"].ToString(),
                    NumberWorking = data.Tables[0].Rows[i]["Number"].ToString(),
                    Cleaners = this.Cleaners
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


        private DataSet GetDataFromDatabase()
        {


            DataTable table = new DataTable
            {
                Columns = { "Id", "State","Number" },
            };


            // Instantiate the DataSet variable.
            DataSet dataSet = new DataSet();
            // Add the new DataTable to the DataSet.
            dataSet.Tables.Add(table);
            Cleaners.Clear();

            string queryString1 =
                "SELECT TOP (1000) [RoomID],[State],[Number] FROM[SoftwareEngineering].[dbo].[Room] WHERE[State] = 'notdone' OR[State] = 'InProgress'";
            string queryString2 =
                "SELECT TOP (1000) [CleaningStaffID]FROM[SoftwareEngineering].[dbo].[CleaningStaff]";

            using (SqlConnection connection = new SqlConnection(
                _connectionString))
            {
                SqlCommand command1 = new SqlCommand(
                    queryString1, connection);
                SqlCommand command2 = new SqlCommand(
                    queryString2, connection);
                connection.Open();
                SqlDataReader reader1= command1.ExecuteReader();
               

                try
                {
                    while (reader1.Read())
                    {
                        string RoomID = (Convert.ToString(reader1[0]));
                        string RoomState = (Convert.ToString(reader1[1]));
                        string Number = (Convert.ToString(reader1[2]));

                       table.Rows.Add( RoomID, RoomState, Number);

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
                        Console.WriteLine(Convert.ToString(reader2[0]));

                        Cleaners.Add(Convert.ToString(reader2[0]));
                    }
                }
                finally
                {
                    reader2.Close();

                }
                connection.Close();
            }
            return dataSet;
        }



        private void RefreshRooms_Click(object sender, EventArgs e)
        {
            PopulateItems();
        }
    }

}
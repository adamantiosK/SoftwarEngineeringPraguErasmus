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


        private DataSet GetDataFromDatabase()
        {

            System.Data.DataTable table = new DataTable("ParentTable");
            DataColumn column;
            DataRow row;
            column = new DataColumn();
            column.ColumnName = "id";
            column = new DataColumn();
            column.ColumnName = "State";


            // Instantiate the DataSet variable.
            DataSet dataSet = new DataSet();
            // Add the new DataTable to the DataSet.
            dataSet.Tables.Add(table);


            string queryString =
                "SELECT RoomID, State FROM dbo.Room;";
            using (SqlConnection connection = new SqlConnection(
                _connectionString))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                int y = 0;

                try
                {
                    while (reader.Read())
                    {
                        string RoomID = (Convert.ToString(reader[0]));
                        string RoomState = (Convert.ToString(reader[1]));
                   
                        row = table.NewRow();
                        row["id"] = RoomID;
                        row["State"] = RoomState;
                        y++;
                    }
                }
                finally
                {
                    reader.Close();
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
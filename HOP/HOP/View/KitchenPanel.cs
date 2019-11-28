using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HOP
{
    public partial class KitchenPanel : UserControl
    {

        private readonly string _connectionString = "";

        private Timer timer1;

        public KitchenPanel()
        {
            InitializeComponent();
        }


        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000; // in miliseconds
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            PopulateItems(12);
        }

        private void PopulateItems(int Amount)
        {
            if (flowLayoutPanel1.Controls.Count != 0)
            {
                flowLayoutPanel1.Controls.Clear();

            }

            KitchenOrder[] listitems = new KitchenOrder[Amount];

            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new KitchenOrder()
                {
                    OrderNumber = (i + 1).ToString(),
                    OrderDetails = "Eggs with Toast"
                };
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();

                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listitems[i]);
                }

            }
        }

        private void GetDataFromDatabase()
        {
            string queryString =
                "SELECT Orders , Discription , State FROM dbo.ROOMS;";
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
                        //Retrives only information for Orders either not done or in progress of the day;

                        //  String that holds Order Number(Convert.ToStrint(reader[0]));
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
            if (KitchenLive.BackColor == Color.Red)
            {
                KitchenLive.BackColor = Color.Green;
                InitTimer();
            }
            else if (KitchenLive.BackColor == Color.Green)
            {
                KitchenLive.BackColor = Color.Red;
                timer1.Stop();
            }
        }

    }
}

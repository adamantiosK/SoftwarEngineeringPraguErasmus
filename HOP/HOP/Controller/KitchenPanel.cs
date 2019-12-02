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
using HOP.Model;
using TagLib.Ape;

namespace HOP
{
    public partial class KitchenPanel : UserControl
    {
        private KitchenStaff _cook;
        private List<KitchenStaff> _cooks = new List<KitchenStaff>();

        private Timer timer1;

        public KitchenPanel()
        {
            InitializeComponent();
        }


        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 30000; // in miliseconds
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            PopulateItems();
        }

        private void PopulateItems()
        {
            List<FoodOrder> orders = GetDataFromDatabase();
            int amount = orders.Count;

            if (flowLayoutPanel1.Controls.Count != 0)
            {
                flowLayoutPanel1.Controls.Clear();

            }

            KitchenOrder[] listitems = new KitchenOrder[amount];

            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new KitchenOrder()
                {
                    OrderNumber = (orders[i].GetOrderID).ToString(),
                    OrderDetails = orders[i].GetMessage,
                    RoomNo = (orders[i].GetRoom).ToString(),
                    Status = orders[i].GetState,
                    Cooks = _cook.ReturnIDList(_cooks)
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

        private List<FoodOrder> GetDataFromDatabase()
        {
            List<FoodOrder> orders = new List<FoodOrder>();

            string queryString1 =
                "SELECT TOP(1000)[OrderStatus],[FoodOrderID],[RoomNumber],[Comment]FROM[DB_A5088F_HOTELdb].[dbo].[FoodOrder]WHERE NOT OrderStatus = 'Done'";
            string queryString2 = "SELECT TOP (1000) [KitchenStaffID] FROM [DB_A5088F_HOTELdb].[dbo].[KitchenStaff]";

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
                        string State = (Convert.ToString(reader1[0]));
                        int OrderID = (Convert.ToInt32(reader1[1]));
                        int RoomNumber = (Convert.ToInt32(reader1[2]));
                        string Discription = (Convert.ToString(reader1[3]));

                        FoodOrder order1 = new FoodOrder(State, OrderID,Discription,RoomNumber);
                        orders.Add(order1);
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
                        _cook = new KitchenStaff(Convert.ToInt16(reader2[0]));
                        _cooks.Add(_cook);
                    }
                }
                finally
                {
                    reader2.Close();
                }
                connection.Close();
            }
            return orders;
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

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
using HOP.Data.DAO;
using HOP.Model;
using TagLib.Ape;

namespace HOP
{
    public partial class KitchenPanel : UserControl
    {
        private List<KitchenStaff> _cooks = new List<KitchenStaff>();

        private Timer timer1;

        public KitchenPanel()
        {
            InitializeComponent();
        }

        // Timer for updating the orders every 20 seconds | Time frame can be changed in the 34th line 
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 20000; // in miliseconds
            timer1.Start();
        }

        // Method that tuns every set amount of time based on the method above
        private void timer1_Tick(object sender, EventArgs e)
        {
            PopulateItems();
        }

        // Mehod that is populating the Kitchen Order Panel user controls base on the amount of the available data
        private void PopulateItems()
        {
            _cooks.Clear();
            List<FoodOrder> orders = FoodOrderDAO.GetActiveFoodOrders();
            _cooks = KitchenStaffDAO.GetKitchenStaffList();
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
                    Cooks = _cooks[0].ReturnIDList(_cooks)
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

      
        private void RefreshRooms_Click(object sender, EventArgs e)
        {
            if (KitchenLive.BackColor == Color.Red)
            {
                KitchenLive.BackColor = Color.Green;
                PopulateItems();
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

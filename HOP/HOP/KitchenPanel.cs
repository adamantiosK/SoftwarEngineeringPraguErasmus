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

namespace HOP
{
    public partial class KitchenPanel : UserControl
    {

        private Timer timer1;

        public KitchenPanel()
        {
            InitializeComponent();
            PopulateItems();
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
            PopulateItems();
        }

        private void PopulateItems()
        {
            if (flowLayoutPanel1.Controls.Count != 0)
            {
                flowLayoutPanel1.Controls.Clear();

            }

            KitchenOrder[] listitems = new KitchenOrder[12];

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

        private void CleanGreenBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (flowLayoutPanel1.Controls.Count != 0)
                {
                    if (flowLayoutPanel1.Controls[i].BackColor == Color.Green)
                    {
                        flowLayoutPanel1.Controls.Remove(flowLayoutPanel1.Controls[i]);
                        i--;
                    }
                }

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

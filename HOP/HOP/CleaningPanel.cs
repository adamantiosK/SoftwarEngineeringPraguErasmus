using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOP
{
    public partial class CleaningPanel : UserControl
    {
        public CleaningPanel()
        {
            InitializeComponent();
            PopulateItems();
        }

        private void PopulateItems()
        {
            if (flowLayoutPanel1.Controls.Count != 0)
            {
                flowLayoutPanel1.Controls.Clear();

            }

            RoomControlPanel[] listitems = new RoomControlPanel[12];

            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new RoomControlPanel
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
            PopulateItems();
        }
    }
}

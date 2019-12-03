using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOP.Model;

namespace HOP.Controller.SubPanels
{
    public partial class ActiveResidenciesPanel : UserControl
    {
        public ActiveResidenciesPanel()
        {
            InitializeComponent();
        }

        //private void PopulateItems()
        //{
        //    List<Room> rooms = GetDataFromDatabase();
        //    int amount = rooms.Count;
        //    if (flowLayoutPanel1.Controls.Count != 0)
        //    {
        //        flowLayoutPanel1.Controls.Clear();
        //    }

        //    RoomControlPanel[] listItems = new RoomControlPanel[amount];

        //    for (int i = 0; i < listItems.Length; i++)
        //    {
        //        listItems[i] = new RoomControlPanel
        //        {
        //            RoomNumber = rooms[i].GetRoomID,
        //            Services1 = "Towel Change",
        //            Services2 = "Sheets Change",
        //            Services3 = "Clean Up",
        //            Status = rooms[i].GetState,
        //            NumberWorking = rooms[i].GetNumber,
        //            Cleaners = _cleaner.ReturnIDList(_cleaners)
        //        };
        //        if (flowLayoutPanel1.Controls.Count < 0)
        //        {
        //            flowLayoutPanel1.Controls.Clear();

        //        }
        //        else
        //        {
        //            flowLayoutPanel1.Controls.Add(listItems[i]);
        //        }

        //    }
        //}

    }
}

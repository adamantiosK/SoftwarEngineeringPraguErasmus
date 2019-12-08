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
using System.Data.SqlClient;
using HOP.Controller.FlowLayouts;

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
        //    List<Reservation> reservations = GetDataFromDatabase();
        //    int amount = reservations.Count;
        //    if (flowLayoutPanel1.Controls.Count != 0)
        //    {
        //        flowLayoutPanel1.Controls.Clear();
        //    }

        //    ResidencyPanel[] listItems = new ResidencyPanel[amount];

        //    for (int i = 0; i < listItems.Length; i++)
        //    {
        //        listItems[i] = new ResidencyPanel{
        //            RoomNumber = reservations[i].,
        //            Name = "Towel Change",
        //            Surname = "Sheets Change",
        //            CheckInDate = reservations[i].StartOfReservation,
        //            CheckOutDate = reservations[i].EndOfReservation
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


        //private List<Reservation> GetDataFromDatabase()
        //{
        //    List<Reservation> reservations = new List<Reservation>();


        //    string queryString3 = "SELECT StartOfReservation , EndOfReservation FROM Reservation WHERE GETDATE() >= StartOfReservation AND GETDATE() <= EndOfReservation AND ReservationID IN(SELECT ReservationID	 FROM Residence)";

        //    using (SqlConnection connection = new SqlConnection(
        //        Form1._connectionString))
        //    {

        //        SqlCommand command3 = new SqlCommand(
        //            queryString3, connection);

        //        connection.Open();
        //        SqlDataReader reader3 = command3.ExecuteReader();
        //        try
        //        {
        //            while (reader3.Read())
        //            {
        //                DateTime CheckIn = Convert.ToDateTime((Convert.ToString(reader3[0])));
        //                DateTime CheckOut = Convert.ToDateTime((Convert.ToString(reader3[1])));
        //                Reservation reservation1 = new Reservation(CheckIn, CheckOut);
        //                reservations.Add(reservation1);
        //            }
        //        }
        //        finally
        //        {
        //            reader3.Close();
        //        }

        //        connection.Close();
        //    }
        //    return reservations;
        //}




    }
}

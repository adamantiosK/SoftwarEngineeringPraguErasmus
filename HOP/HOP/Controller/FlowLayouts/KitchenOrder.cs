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
    public partial class KitchenOrder : UserControl
    {
        public KitchenOrder()
        {
            InitializeComponent();
        }

        #region Properties 

        private string _orderNumber;
        private string _OrderDetails;
        private string _roomNumber;
        private string _StatusFromDatabase;
        public List<String> Cooks = new List<String>();


        [Category("Custom Props")]
        public string OrderNumber
        {
            get { return _orderNumber; }
            set
            {
                _orderNumber = value;
                NoLbl.Text = value;
            }
        }


        [Category("Custom Props")]
        public string Status
        {
            get { return _StatusFromDatabase; }
            set
            {
                _StatusFromDatabase = value;
                if (value == "InProgress")
                {
                    this.BackColor = Color.Yellow;
                    DoneBtn.BackColor = Color.Gold;
                }

            }
        }

        [Category("Custom Props")]
        public string OrderDetails
        {
            get { return _OrderDetails; }
            set
            {
                _OrderDetails = value;
                OrderLbl.Text = value;
            }
        }


        [Category("Custom Props")]
        public string RoomNo
        {
            get { return _roomNumber; }
            set
            {
                _roomNumber = value;
                RoomNoLbl.Text = value;
            }
        }

        #endregion


        private bool IsWorker(String id)
        {
            for (int i = 0; i < Cooks.Count; i++)
            {
                if (Cooks[i] == id)
                {
                    return true;
                }

                //Check if id exists in database or string array that loads at the begining 
            }

            return false;
        }

        private void DoneBtn_Click_1(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Green)
            {
                messageLbl.Text = "Order Already in Completed State";
                WorkerIDtxt.Text = "";
            }
            else
            {
                if (DoneBtn.BackColor == Color.Gold)
                {
                    if (WorkerIDtxt.Text != "" && IsWorker(WorkerIDtxt.Text) == true && this.BackColor == Color.Yellow)
                    {
                        messageLbl.Text = "";
                        String workerId = WorkerIDtxt.Text;
                        WorkerIDtxt.Text = "";

                        this.BackColor = Color.Green;

                        ParseToDatabaseForDone(NoLbl.Text);

                        this.BackColor = Color.Green;
                        DoneBtn.BackColor = Color.MediumSpringGreen;
                    }
                    else
                    {
                        WorkerIDtxt.Text = "";
                        messageLbl.Text = "Error occurred";
                    }

                }


                if (DoneBtn.BackColor == Color.MediumSpringGreen && this.BackColor != Color.Green)
                {
                    if (WorkerIDtxt.Text != "" && IsWorker(WorkerIDtxt.Text) == true)
                    {
                        // messageLbl.Text = "";
                        String workerId = WorkerIDtxt.Text;
                        WorkerIDtxt.Text = "";


                        ParseToDatabaseForInProgress(NoLbl.Text);


                        this.BackColor = Color.Yellow;
                        DoneBtn.BackColor = Color.Gold;
                        DoneBtn.Text = "Complete Order";

                        this.BackColor = Color.Yellow;

                    }
                    else
                    {
                        messageLbl.Text = "";
                        messageLbl.Text = "Error occurred";
                        WorkerIDtxt.Text = "";
                    }
                }

            }
        }


        private void ParseToDatabaseForInProgress( string OrderNo)
        {
            string queryString1 =
                "UPDATE dbo.FoodOrder SET OrderStatus = 'InProgress' WHERE FoodOrderID =" + OrderNo;
            
            using (SqlConnection connection = new SqlConnection(
                Form1._connectionString))
            {
                SqlCommand command1 = new SqlCommand(
                    queryString1, connection);
            
                connection.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
               
                connection.Close();
            }
        }


        private void ParseToDatabaseForDone(string orderNO)
        {
            string queryString =
                "UPDATE dbo.FoodOrder SET OrderStatus = 'Done' WHERE FoodOrderID =" + orderNO;
            using (SqlConnection connection = new SqlConnection(
                Form1._connectionString))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
        }

    }
}

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
using System.Diagnostics.Eventing.Reader;

namespace HOP
{
    public partial class RoomControlPanel : UserControl
    {

        public RoomControlPanel()
        {
            InitializeComponent();
        }


        #region Properties 
        private string _roomNumber;
        private string _ServiceLineOne;
        private string _ServiceLineTwo;
        private string _ServiceLineThree;
        private string _StatusFromDatabase;
        private string _activeNumber;
        public List<String> Cleaners = new List<String>();



        [Category("Custom Props")]
        public string RoomNumber
        {
            get { return _roomNumber;}
            set { _roomNumber = value;
                NoLbl.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Services1
        {
            get { return _ServiceLineOne;}
            set { _ServiceLineOne = value;
                Service1Lbl.Text = value;
            }
        }


        [Category("Custom Props")]
        public string Services2
          {
              get { return _ServiceLineTwo; }
              set { _ServiceLineTwo = value;
                  Service2Lbl.Text = value;
              }
          }

          [Category("Custom Props")]
          public string Services3
          {
              get { return _ServiceLineThree; }
              set {
                  _ServiceLineThree = value;
                  Service3Lbl.Text = value;
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
                  }

              }
          }

          [Category("Custom Props")]
          public string NumberWorking
          {
              get { return _activeNumber; }
              set
              {
                  _activeNumber = value;
                  ActiveNumberLbl.Text = value;

              }
          }



        #endregion

        private void JoinRoomBtn_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Green)
            {
                messageLbl.Text = "Room Alredy in Cleaned State";
                WorkerIdTxtBox.Text = "";
            }
            else
            {
                for (int i = 0; i < Cleaners.Count; i++)
                {
                    Console.WriteLine(Cleaners[i]);
                }

                if (WorkerIdTxtBox.Text != "" && IsWorker(WorkerIdTxtBox.Text) == true)
                {
                    messageLbl.Text = "";
                    String workerId = WorkerIdTxtBox.Text;
                    WorkerIdTxtBox.Text = "";

                    // parse data that room is in progress into database at information of who made it in progress using the workerid string  
                    int no = int.Parse(ActiveNumberLbl.Text);
                    ActiveNumberLbl.Text = (no + 1).ToString();
                    ParseToDatabaseForInProgress(ActiveNumberLbl.Text, NoLbl.Text);
                    this.BackColor = Color.Yellow;
                   
                }
                else
                {
                    messageLbl.Text = "";
                    messageLbl.Text = "Error occurred";
                }
            }

        }


        private bool IsWorker(String id)
        {
            for (int i = 0; i < Cleaners.Count; i++)
            {
                if (Cleaners[i] == id)
                {
                    return true;
                }
                //Check if id exists in database or string array that loads at the begining 
            }
            

            return false;
        }



        private void DoneBtn_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Green)
            {
                messageLbl.Text = "Room Alredy in Cleaned State";
                WorkerIdTxtBox.Text = "";
            }
            else
            {

                if (WorkerIdTxtBox.Text != "" && IsWorker(WorkerIdTxtBox.Text) == true && this.BackColor == Color.Yellow)
                {
                    messageLbl.Text = "";
                    String workerId = WorkerIdTxtBox.Text;
                    WorkerIdTxtBox.Text = "";

                    // parse data that room is done into database and information of who made it in progress using the workerid string 
                    this.BackColor = Color.Green;

                    ParseToDatabaseForDone( NoLbl.Text);
                }
                else
                {
                    WorkerIdTxtBox.Text = "";
                    messageLbl.Text = "Error occurred";
                }
            }
        }

      
        private void ParseToDatabaseForDone(string roomNumber)
        {
            string _connectionString = "Server=localhost;Database=SoftwareEngineering;Trusted_Connection=True;";
            string queryString =
                "UPDATE dbo.Room SET[State] = 'Done' WHERE RoomID = " + roomNumber;
            using (SqlConnection connection = new SqlConnection(
                _connectionString))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
        }





        private void ParseToDatabaseForInProgress(string ActiveNumber, string roomNumber)
        {

            string _connectionString = "Server=localhost;Database=SoftwareEngineering;Trusted_Connection=True;";


            string queryString1 =
                "UPDATE dbo.Room SET[State] = 'InProgress' WHERE RoomID = " + roomNumber;

            string queryString2 =
                "UPDATE dbo.Room SET[Number] = '" + ActiveNumber + "' WHERE RoomID = " + roomNumber;
            using (SqlConnection connection = new SqlConnection(
                _connectionString))

            {
                SqlCommand command1 = new SqlCommand(
                    queryString1, connection);
                SqlCommand command2 = new SqlCommand(
                    queryString2, connection);
                connection.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                SqlDataReader reader2 = command2.ExecuteReader();
                reader2.Close();
                connection.Close();
            }
        }
    }
}


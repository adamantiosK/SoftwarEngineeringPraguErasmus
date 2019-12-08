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
using HOP.Data.DAO;

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

                if (WorkerIdTxtBox.Text != "" && IsWorker(WorkerIdTxtBox.Text) == true)
                {
                    messageLbl.Text = "";
                    String workerId = WorkerIdTxtBox.Text;
                    WorkerIdTxtBox.Text = "";

                    // parse data that room is in progress into database at information of who made it in progress using the workerid string  
                    int no = int.Parse(ActiveNumberLbl.Text);
                    ActiveNumberLbl.Text = (no + 1).ToString();
                    RoomsDAO.SetCleaningStatusToInProgress(ActiveNumberLbl.Text, NoLbl.Text);
                    this.BackColor = Color.Yellow;
                   
                }
                else
                {
                    messageLbl.Text = "";
                    messageLbl.Text = "Error occurred";
                    WorkerIdTxtBox.Text = "";
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
            }
            return false;
        }


        private void DoneBtn_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Green)
            {
                messageLbl.Text = "Room Already in Cleaned State";
                WorkerIdTxtBox.Text = "";
            }
            else
            {

                if (WorkerIdTxtBox.Text != "" && IsWorker(WorkerIdTxtBox.Text) == true && this.BackColor == Color.Yellow)
                {
                    messageLbl.Text = "";
                    String workerId = WorkerIdTxtBox.Text;
                    WorkerIdTxtBox.Text = "";

                    this.BackColor = Color.Green;

                    RoomsDAO.SetCleaningStatusToDone( NoLbl.Text);
                }
                else
                {
                    WorkerIdTxtBox.Text = "";
                    messageLbl.Text = "Error occurred";
                }
            }
        }
    }
}


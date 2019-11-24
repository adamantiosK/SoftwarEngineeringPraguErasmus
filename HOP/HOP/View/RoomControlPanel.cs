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
        private string _seriesOfEmployees;
        private Button _InProgressBtn;
        private Button _DoneButton;



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
                    this.BackColor = Color.Yellow;
                    int no = int.Parse(ActiveNumberLbl.Text);
                    ActiveNumberLbl.Text = (no + 1).ToString();
                }
                else
                {
                    messageLbl.Text = "Error occurred";
                }
            }

        }


        private bool IsWorker(String id)
        {
            //Check if id exists in database or string array that loads at the begining 
            return true;
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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.MediaFramework.deviceio;
using DateTime = System.DateTime;

namespace HOP.Controller.FlowLayouts
{
    public partial class ResidencyPanel : UserControl
    {
        public ResidencyPanel()
        {
            InitializeComponent();
        }


        #region Properties 
        private string _roomNumber;
        private DateTime _CheckInDate;
        private DateTime _CheckOutDate;
        private string _name;
        private string _surname;

        public List<String> Cleaners = new List<String>();



        [Category("Custom Props")]
        public string RoomNumber
        {
            get { return _roomNumber; }
            set
            {
                _roomNumber = value;
                NO.Text = value;
            }
        }

        [Category("Custom Props")]
        public DateTime CheckInDate
        {
            get { return _CheckInDate; }
            set
            {
                _CheckInDate = value;
                CheckInDateLbl.Text = value.ToString();
            }
        }


        [Category("Custom Props")]
        public DateTime CheckOutDate
        {
            get { return _CheckOutDate; }
            set
            {
                _CheckOutDate = value;
                CheckOutDATE.Text = value.ToString();
            }
        }

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NAME.Text = value;
            }
        }


        [Category("Custom Props")]
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                SURNAME.Text = value;

            }
        }

        #endregion

    }
}

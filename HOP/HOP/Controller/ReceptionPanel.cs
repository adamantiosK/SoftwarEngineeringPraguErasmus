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
    public partial class ReceptionPanel : UserControl
    {
        public ReceptionPanel()
        {
            InitializeComponent();
        }


        // 
        // All the methods are resposible for bring the apropriate panels in front of the VIEW
        //


        private void button1_Click(object sender, EventArgs e)
        {
            makeReservationTemporary1.BringToFront();
            makeAReservation1.SendToBack();
            viewReservations1.SendToBack();
            logInPage1.SendToBack();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewReservations1.BringToFront();
            makeAReservation1.SendToBack();
            logInPage1.SendToBack();

            makeReservationTemporary1.SendToBack();
        }

        private void Loginout_Click(object sender, EventArgs e)
        {
            logInPage1.BringToFront();
            makeAReservation1.SendToBack();
            viewReservations1.SendToBack();

            makeReservationTemporary1.SendToBack();

        }
    }
}

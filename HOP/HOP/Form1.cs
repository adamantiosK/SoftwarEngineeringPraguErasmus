using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOP
{
    public partial class Form1 : Form
    {
        public readonly string _connectionString = "Server=localhost;Database=SoftwareEngineering;Trusted_Connection=True;";


        public Form1()
        {
            InitializeComponent();
            
        }


        private void label1_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void MinimizeWindow_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void KitchenView_Click(object sender, EventArgs e)
        {
            kitchenPanel1.BringToFront();
            cleaningPanel1.SendToBack();
            receptionPanel1.SendToBack();
        }

        private void ReceptionView_Click(object sender, EventArgs e)
        {
            receptionPanel1.BringToFront();
            kitchenPanel1.SendToBack();
            cleaningPanel1.SendToBack();
        }

        private void CleaningView_Click(object sender, EventArgs e)
        {
            cleaningPanel1.BringToFront();
            kitchenPanel1.SendToBack();
            receptionPanel1.SendToBack();
        }
    }
}

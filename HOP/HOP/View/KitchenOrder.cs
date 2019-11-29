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
    public partial class KitchenOrder : UserControl
    {
        public KitchenOrder()
        {
            InitializeComponent();
        }

        #region Properties 
        private string _orderNumber;
        private string _OrderDetails;



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
        public string OrderDetails
        {
            get { return _OrderDetails; }
            set
            {
                _OrderDetails = value;
                OrderLbl.Text = value;
            }
        }



        #endregion



        private void DoneBtn_Click_1(object sender, EventArgs e)
        {
            if (DoneBtn.BackColor == Color.Gold)
            {
                this.BackColor = Color.Green;
                DoneBtn.BackColor = Color.MediumSpringGreen;
            }
            if (DoneBtn.BackColor == Color.MediumSpringGreen && this.BackColor != Color.Green)
            {
                this.BackColor = Color.Yellow;
                DoneBtn.BackColor = Color.Gold;
                DoneBtn.Text = "Complete Order";
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class Customer : Person
    {
        private int _customerID;
        private int _phoneNumber;

        private List<Reservation> reservations = new List<Reservation>();

        public Customer(int customerID, int phoneNumber)
        {
            {
                this._customerID = customerID;
                this._phoneNumber = phoneNumber;
            }

        }
    }
}

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
            
            this._customerID = customerID; 
            this._phoneNumber = phoneNumber;

        }



        public int CustomerID
        {
            get { return _customerID; }   // get method
            set { _customerID = value; }  // set method
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }   // get method
            set { _phoneNumber = value; }  // set method
        }



    }
}

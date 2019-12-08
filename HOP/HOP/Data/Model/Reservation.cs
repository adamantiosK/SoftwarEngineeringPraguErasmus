using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.MediaFramework.deviceio;
using DateTime = System.DateTime;

namespace HOP.Model
{
    class Reservation
    {

        private DateTime _endOfReservation;
        private DateTime _startOfReservation;
        private String _state;
        private int _capacity;
        private int _customerID;

        private List< Room > _roomReservations = new List<Room>();
        private List<Residence> _residence = new List<Residence>();
        private Customer _customer;



        public Reservation(DateTime StartOfReservation, DateTime EndOfReservation , int CustomerID )
        {
            this._endOfReservation = EndOfReservation;
            this._startOfReservation = StartOfReservation;
            this._customerID = CustomerID;
        }


        public DateTime EndOfReservation
        {
            get { return _endOfReservation; }   // get method
            set { _endOfReservation = value; }  // set method
        }


        public DateTime StartOfReservation
        {
            get { return _startOfReservation; }   // get method
            set { _startOfReservation = value; }  // set method
        }


        public String State
        {
            get { return _state; }   // get method
            set { _state = value; }  // set method
        }



        public int CustomerIDOfReservation
        {
            get { return _customerID; }   // get method
            set { _customerID = value; }  // set method
        }





    }
}

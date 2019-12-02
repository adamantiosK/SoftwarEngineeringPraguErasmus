using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.MediaFramework.deviceio;

namespace HOP.Model
{
    class Reservation
    {

        private Date _endOfReservation;
        private Date _startOfReservation;
        private String _state;
        private int _capacity;

        private List< Room > _roomReservations = new List<Room>();
        private List<Residence> _residence = new List<Residence>();
        private Customer _customer;



        public Reservation(Customer customer, Date EndOfReservation,Date StartOfReservation,String State,int capacity)
        {
            this._state = State;
            this._endOfReservation = EndOfReservation;
            this._startOfReservation = StartOfReservation;
            this._capacity = capacity;
            this._customer = customer;
        }


        public Date EndOfReservation
        {
            get { return _endOfReservation; }   // get method
            set { _endOfReservation = value; }  // set method
        }


        public Date StartOfReservation
        {
            get { return _startOfReservation; }   // get method
            set { _startOfReservation = value; }  // set method
        }


        public String State
        {
            get { return _state; }   // get method
            set { _state = value; }  // set method
        }





    }
}

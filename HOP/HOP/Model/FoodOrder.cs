using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.MediaFramework.deviceio;

namespace HOP.Model
{
    class FoodOrder
    {
        private String _message;
        private int _orderID;
        private String _State;
        private Date _time;
        private int _roomNo;

        private List<Food> _food = new List<Food>();
        private List<Employee> _executer = new List<Employee>();

        public FoodOrder(string state, int orderID, string message, int RoomNo)
        {
            this._State = state;
            this._orderID = orderID;
            this._message = message;
            this._roomNo = RoomNo;
        }


        public string GetState
        {
            get { return _State; }   // get method
            set { _State = value; }  // set method
        }


        public int GetOrderID
        {
            get { return _orderID; }   // get method
            set { _orderID = value; }  // set method
        }



        public string GetMessage
        {
            get { return _message; }   // get method
            set { _message = value; }  // set method
        }



        public int GetRoom
        {
            get { return _roomNo; }   // get method
            set { _roomNo = value; }  // set method
        }


    }
}

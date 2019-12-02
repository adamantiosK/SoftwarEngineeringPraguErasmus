using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class Room
    {
        private String RoomID;
        private String State;
        private String Number;

        private List<FoodOrder> _foodOrders = new List<FoodOrder>();

        public Room(String roomId, String state, String number)
        {
            RoomID = roomId;
            State = state;
            Number = number;
        }

        public string GetRoomID  
        {
            get { return RoomID; }   // get method
            set { RoomID= value; }  // set method
        }

        public string GetState   
        {
            get { return State; }   // get method
            set { State = value; }  // set method
        }

        public string   GetNumber 
        {
            get { return Number; }   // get method
            set { Number = value; }  // set method
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class Residence
    {
        private int _residenceID;

        private Contact _contract;
        private Bill _bill;
        private FoodOrder _foodOrder;
        private Reservation _reservation;

        public Residence(int residenceId)
        {
            this._residenceID = residenceId;
        }


    }
}

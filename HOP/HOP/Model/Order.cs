using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class Order
    {
        private String Discription;

        public Order(String discription)
        {
            this.Discription = discription;
        }


        public string GetDicription
        {
            get { return Discription; }   // get method
            set { Discription = value; }  // set method
        }



    }
}

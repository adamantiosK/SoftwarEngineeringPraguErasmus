using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class Person
    {
        private string _name;
        private string _surname;


        public string PersonName
        {
            get { return _name; }   // get method
            set { _name = value; }  // set method
        }

        public string PersonSurname
        {
            get { return _surname; }   // get method
            set { _surname = value; }  // set method
        }

    }
}

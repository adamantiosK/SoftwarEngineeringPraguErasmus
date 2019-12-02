using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class CleaningRecord
    {
        private int _state;
        
        private List<Employee> _employees = new List<Employee>();
        private Room room;

        public CleaningRecord(int state)
        {
            this._state = state;
        }
    }
}

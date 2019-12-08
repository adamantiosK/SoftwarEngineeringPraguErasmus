using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class Role
    {
        private Boolean _flag;
        private List<KitchenStaff> _kitchenStaff = new List<KitchenStaff>();
        private List<Receptionist> _receptionists = new List<Receptionist>();
        private List<CleaningStaff> _cleaningStaff = new List<CleaningStaff>();


        public Role(bool flag)
        {
            this._flag = flag;
        }

    }
}

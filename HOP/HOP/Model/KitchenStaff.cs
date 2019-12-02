using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class KitchenStaff
    {
        private int _kitchenstaffID;

        public KitchenStaff(int kitchenstaffId)
        {
            this._kitchenstaffID = kitchenstaffId;
        }


        public List<String> ReturnIDList(List<KitchenStaff> cooks)
        {
            List<String> IDS = new List<string>();
            for (int i = 0; i < cooks.Count; i++)
            {
                IDS.Add((cooks[i]._kitchenstaffID).ToString());
                Console.WriteLine(cooks[i]._kitchenstaffID);
            }
            return IDS;
        }

    }
}

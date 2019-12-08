using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class CleaningStaff
    {
        public int _cleaningStaffID;

        public CleaningStaff(int cleaningStaffId)
        {
            this._cleaningStaffID = cleaningStaffId;
        }

        public List<String> ReturnIDList(List<CleaningStaff> cleaners)
        {
            List<String> IDS = new List<string>();
            for (int i = 0; i < cleaners.Count; i++)
            {
                IDS.Add((cleaners[i]._cleaningStaffID).ToString());
                Console.WriteLine(cleaners[i]._cleaningStaffID);
            }
            return IDS;
        }


        public bool CleanerExists(CleaningStaff cleaner, List<CleaningStaff> cleaners)
        {
            for (int i = 0; i < cleaners.Count; i++)
            {
                if (cleaner._cleaningStaffID == cleaners[i]._cleaningStaffID)
                {
                    return true;
                }
            }
            return false;
        }


    }
}

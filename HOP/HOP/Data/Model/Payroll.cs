using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.MediaFramework.deviceio;

namespace HOP.Model
{
    class Payroll
    {
        private Double _ammount;
        private Date _endTime;
        private Double _hoursWorked;
        private Date _startTime;

        public Payroll(double hoursWorked, double ammount)
        {
            this._ammount = ammount;
            this._hoursWorked = hoursWorked;
        }

    }
}

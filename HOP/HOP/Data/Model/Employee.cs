using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOP.Model
{
    class Employee
    {
        private int _password;
        private double _wage;

        private List<Role> _roles = new List<Role>();
        private List<Payroll> _payrolls = new List<Payroll>();

        public Employee(double wage, int password)
        {
            this._password = password;
            this._wage = wage;
        }
    }
}

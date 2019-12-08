using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.MediaFramework.deviceio;

namespace HOP.Model
{
    class Bill
    {
        private String _content;
        private Date _dueDate;
        private Boolean _paid;
        private Double _totalAmount;

        public Bill(double totalAmount, bool paid)
        {
            this._totalAmount = totalAmount;
            this._paid = paid;
        }




    }
}

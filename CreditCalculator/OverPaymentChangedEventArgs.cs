using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculator
{

    public class OverPaymentChangedEventArgs : EventArgs
    {
        public int RowIndex { get; set;  }
        public decimal OverPayment { get; set; }

        public OverPaymentChangedEventArgs(int rowIndex, decimal overPayment)
        {
            this.RowIndex = rowIndex;
            this.OverPayment = overPayment;
        }
    }

}

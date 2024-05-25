using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculator
{
    public class Repayment
    {
     
            public int PaymentNumber { get; set; } 
            public decimal PaymentAmount { get; set; }
            public decimal PrincipalAmount { get; set; } 
            public decimal InterestAmount { get; set; } 
            public decimal RemainingBalance { get; set; } 
            public decimal OverPayment { get; set; }

            public Repayment(int paymentNumber, decimal paymentAmount, decimal principalAmount, decimal interestAmount, decimal remainingBalance, decimal overPayment)
            {
                PaymentNumber = paymentNumber;
                PaymentAmount = paymentAmount;
                PrincipalAmount = principalAmount;
                InterestAmount = interestAmount;
                RemainingBalance = remainingBalance;
                OverPayment = overPayment;
            }
        
    }
}

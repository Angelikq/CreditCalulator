using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace CreditCalculator
{
    internal class RepaymentSchedule
    {
        public int repaymentsCount;
        public Loan loan;

        public List<Repayment> CalculateRepaymentSchedule(Loan loan)
        {
            this.loan = loan;
            decimal monthlyPayment = loan.CalculateMonthlyPayment();

            List<Repayment> repaymentSchedule = new List<Repayment>();

            decimal monthlyInterestRate = loan.MonthlyInterestRate();
            int totalNumberOfPayments = loan.TotalNumberOfPayments();
            decimal remainingBalance = loan.LoanAmount;
            decimal cyclicOverPayment = loan.CyclicOverPayment;
            decimal oneTimeOverPayment = loan.OneTimeOverPayment;
            List<OverPaymentChangedEventArgs> personalizedOverPayment = loan.PersonalizedOverPayment;

            if (oneTimeOverPayment > 0)
            {
                if (personalizedOverPayment == null)
                {
                    personalizedOverPayment = new List<OverPaymentChangedEventArgs>();
                }

                var oneTimePayment = new OverPaymentChangedEventArgs(0, oneTimeOverPayment);
                UpdatePersonalizedOverPayment(personalizedOverPayment, oneTimePayment);
            }

            for (int paymentNumber = 1; paymentNumber <= totalNumberOfPayments; paymentNumber++)
            {
                if (remainingBalance <= 0) break;

                decimal interestAmount = remainingBalance * monthlyInterestRate;
                decimal principalAmount = monthlyPayment - interestAmount;
                if (remainingBalance < principalAmount) principalAmount = remainingBalance;

                decimal currentPrincipalAmount = principalAmount;
                decimal overPaymentToRow = 0;

                if (personalizedOverPayment != null)
                {
                    var personalizedPayment = personalizedOverPayment.FirstOrDefault(obj => obj.RowIndex + 1 == paymentNumber);
                    if (personalizedPayment != null)
                    {
                        currentPrincipalAmount += personalizedPayment.OverPayment;
                        overPaymentToRow = personalizedPayment.OverPayment;
                    }
                    else
                    {
                        overPaymentToRow = cyclicOverPayment;
                        currentPrincipalAmount += cyclicOverPayment;
                    }
                }
                else if (cyclicOverPayment != 0)
                {
                    currentPrincipalAmount += cyclicOverPayment;
                    overPaymentToRow = cyclicOverPayment;
                }

                remainingBalance -= currentPrincipalAmount;
                if (remainingBalance <= 0) remainingBalance = 0;

                repaymentSchedule.Add(new Repayment(paymentNumber, monthlyPayment, principalAmount, interestAmount, remainingBalance, overPaymentToRow));
            }

            repaymentsCount = repaymentSchedule.Count;
            return repaymentSchedule;
        }

        public decimal CalculateTotalCost(Loan loan)
        {
            List<Repayment> repaymentSchedule = CalculateRepaymentSchedule(loan);
            return repaymentSchedule.Sum(x => x.InterestAmount);
        }

        public void UpdatePersonalizedOverPayment(List<OverPaymentChangedEventArgs> personalizedOverPayment, OverPaymentChangedEventArgs newOverPayment)
        {
            var existingPayment = personalizedOverPayment.FirstOrDefault(obj => obj.RowIndex == newOverPayment.RowIndex);
            if (existingPayment != null)
            {
                existingPayment.OverPayment = newOverPayment.OverPayment;
            }
            else
            {
                personalizedOverPayment.Add(newOverPayment);
            }
        }




    }
};

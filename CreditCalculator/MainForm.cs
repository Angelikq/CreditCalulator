using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CreditCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Loan loan;
        Loan loanWithOverPayment;
        RepaymentSchedule repaymentSchedule = new RepaymentSchedule();
        RepaymentSchedule repaymentScheduleWithOverPayment = new RepaymentSchedule();
        public RepaymentScheduleForm repaymentScheduleForm;
        public RepaymentScheduleForm repaymentScheduleFormWithOverpayment;

        public void calculate_Click(object sender, EventArgs e)
        {

            if(!isValidationSuccess())return ;
            try
            {
                loan = new Loan(Convert.ToDecimal(txt_loanAmount.Text), Convert.ToDecimal(txt_interestRate.Text), Convert.ToInt32(txt_loanPeriod.Text));
                repaymentScheduleForm = new RepaymentScheduleForm(repaymentScheduleWithOverPayment.CalculateRepaymentSchedule(loan),false, true);
            }
            catch
            {
                MessageBox.Show("Wprowadzono niepoprawne dane");
                return;
            }
            clearOverPaymentData();
            displayLoanData();
        }
       
        public void clearOverPaymentData(object sender = null, EventArgs e= null)
        {
            loanWithOverPayment = null;
            repaymentScheduleFormWithOverpayment = null;
            txt_cyclicOverPayment.Text = "";
            txt_oneOverPayment.Text = "";
            lbl_loanAmountOverPayment.Text = "Wartość pożyczki: ";
            lbl_interestTotalOverPayment.Text = "Suma odsetek: ";
            lbl_totalCostOverPayment.Text = "Całkowity koszt kredytu: ";
            lbl_loanPeriod.Text = "Okres kredytowania: ";
            lbl_interestTotalChange.Text = "";
            lbl_loanPeriodChange.Text = "";
        }
        private void displayLoanData()
        {
            decimal totalCostCalc = repaymentScheduleForm.repaymentSchedule.Sum(x => x.InterestAmount);
            lbl_totalCost.Text = "Całkowity koszt kredytu: " + (totalCostCalc + loan.LoanAmount).ToString("N2") + " zł";
            lbl_loanAmount.Text = "Wartość pożyczki: " + loan.LoanAmount.ToString("N2") + " zł";
            lbl_interestTotal.Text = "Wartość odsetek: " + totalCostCalc.ToString("N2") + " zł";
            lbl_repaymentAmount.Text = "Miesięczna rata: " + loan.CalculateMonthlyPayment().ToString("N2") + " zł";
        }
        private void displayLoanWithOverPaymentData()
        {
            decimal totalCostCalc = repaymentScheduleFormWithOverpayment.repaymentSchedule.Sum(x => x.InterestAmount);
            lbl_totalCostOverPayment.Text = "Całkowity koszt kredytu: " + (totalCostCalc + loan.LoanAmount).ToString("N2") + " zł";
            lbl_loanAmountOverPayment.Text = "Wartość pożyczki: " + loan.LoanAmount.ToString("N2") + " zł";
            lbl_interestTotalOverPayment.Text = "Wartość odsetek: " + totalCostCalc.ToString("N2") + " zł";
            lbl_loanPeriod.Text = "Okres kredytowania: " + repaymentScheduleFormWithOverpayment.repaymentSchedule.Count / 12 + " lat";
            int periodDifference = (loan.LoanPeriod * 12) - (repaymentScheduleFormWithOverpayment.repaymentSchedule.Count);
            lbl_loanPeriodChange.Text = "skrócony o: " + (periodDifference / 12).ToString() + " lat/a i " + (periodDifference % 12) + "msc/y";
            lbl_interestTotalChange.Text = "mniej o: " + (repaymentSchedule.CalculateTotalCost(loan) - repaymentScheduleFormWithOverpayment.repaymentSchedule.Sum(x => x.InterestAmount)).ToString("N2") + " zł";
        }

        private void btn_cyclicOverPayment_Click(object sender, EventArgs e)
        {
            createOverPaymentLoanAndForm();
            try
            {
                loanWithOverPayment.CyclicOverPayment = Convert.ToDecimal(txt_cyclicOverPayment.Text);
            }
            catch
            {
                MessageBox.Show("Wprowadzono niepoprawne dane");
                return;
            }
            repaymentScheduleFormWithOverpayment.repaymentSchedule = new RepaymentSchedule().CalculateRepaymentSchedule(loanWithOverPayment);
            repaymentScheduleFormWithOverpayment.refreshGrid();
            displayLoanWithOverPaymentData();
        }
        private void btn_oneTimeOverPayment_Click(object sender, EventArgs e)
        {
            createOverPaymentLoanAndForm();
            try
            {
                loanWithOverPayment.OneTimeOverPayment = Convert.ToDecimal(txt_oneOverPayment.Text);
            }
            catch
            {
                MessageBox.Show("Wprowadzono niepoprawne dane");
                return;
            }
            repaymentScheduleFormWithOverpayment.repaymentSchedule = new RepaymentSchedule().CalculateRepaymentSchedule(loanWithOverPayment);
            repaymentScheduleFormWithOverpayment.refreshGrid();
            displayLoanWithOverPaymentData();
        }
        private void createOverPaymentLoanAndForm()
        {
            if (loanWithOverPayment == null && loan != null)
            {
                loanWithOverPayment = new Loan(Convert.ToDecimal(txt_loanAmount.Text), Convert.ToDecimal(txt_interestRate.Text), Convert.ToInt32(txt_loanPeriod.Text));
            }
            if (repaymentScheduleFormWithOverpayment == null)
            {
                repaymentScheduleFormWithOverpayment = new RepaymentScheduleForm(repaymentScheduleWithOverPayment.CalculateRepaymentSchedule(loan));
            }
        }

        private void btn_OpenScheduleLoan_Click(object sender, EventArgs e)
        {
            repaymentScheduleForm?.ShowDialog(); 
        }

        private void btn_openScheduleWithOverpayment_Click(object sender, EventArgs e)
        {
            createOverPaymentLoanAndForm();
            repaymentScheduleFormWithOverpayment.isEditMode = false;
            repaymentScheduleFormWithOverpayment.RepaymentScheduleForm_Load();
            repaymentScheduleFormWithOverpayment?.ShowDialog();
        }
        private void btn_editSchedule_Click(object sender, EventArgs e)
        {
            createOverPaymentLoanAndForm();
            repaymentScheduleFormWithOverpayment.isEditMode = true;
            repaymentScheduleFormWithOverpayment.RepaymentScheduleForm_Load();
            repaymentScheduleFormWithOverpayment.OverPaymentChanged += repaymentScheduleFormWithOverpayment_OverPaymentChanged;

            displayLoanWithOverPaymentData();
            repaymentScheduleFormWithOverpayment?.ShowDialog();
        }
        private void repaymentScheduleFormWithOverpayment_OverPaymentChanged(object sender, OverPaymentChangedEventArgs e)
        {
            if(loanWithOverPayment.PersonalizedOverPayment == null)
            {
                loanWithOverPayment.PersonalizedOverPayment = new List<OverPaymentChangedEventArgs>();
            }
            var existingOverPayment = loanWithOverPayment.PersonalizedOverPayment.FirstOrDefault(op => op.RowIndex == e.RowIndex);

            if (existingOverPayment != null) existingOverPayment.OverPayment = e.OverPayment;
            else loanWithOverPayment.PersonalizedOverPayment.Add(e);
            repaymentScheduleFormWithOverpayment.repaymentSchedule = null;
            repaymentScheduleFormWithOverpayment.repaymentSchedule = new RepaymentSchedule().CalculateRepaymentSchedule(loanWithOverPayment);
            displayLoanWithOverPaymentData();
            repaymentScheduleFormWithOverpayment.RepaymentScheduleForm_Load();
        }

        private void txt_loanPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private Boolean isValidationSuccess()
        {
            if (string.IsNullOrWhiteSpace(txt_loanPeriod.Text) || string.IsNullOrWhiteSpace(txt_loanAmount.Text) || string.IsNullOrWhiteSpace(txt_interestRate.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return false;
            }

            if (!int.TryParse(txt_loanPeriod.Text, out int loanPeriod) || loanPeriod <= 0 || loanPeriod > 60)
            {
                MessageBox.Show("Podaj prawidłowy okres kredytowania (1-60 lat).");
                return false;
            }

            if (!decimal.TryParse(txt_interestRate.Text, out decimal interestRate) || interestRate <= 0 || interestRate > 99)
            {
                MessageBox.Show("Podaj prawidłową stopę procentową (0-99).");
                return false;
            }

            if (!decimal.TryParse(txt_loanAmount.Text, out decimal loanAmount) || loanAmount <= 0)
            {
                MessageBox.Show("Podaj prawidłową kwotę kredytu (większą od 0).");
                return false;
            }
            return true;
        }
        private void allowOnlyDecimalNumbers(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }

    }

}

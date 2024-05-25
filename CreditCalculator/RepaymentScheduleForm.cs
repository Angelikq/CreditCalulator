using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalculator
{
    public partial class RepaymentScheduleForm : Form
    {
        public List<Repayment> repaymentSchedule;
        public bool isEditMode;
        public bool basicSchedule;


        public RepaymentScheduleForm(List<Repayment> repaymentSchedule, bool isEditMode = false, bool basicSchedule = false)
        {
            InitializeComponent();
            this.repaymentSchedule = repaymentSchedule;
            this.isEditMode = isEditMode;
            this.basicSchedule = basicSchedule; 
            RepaymentScheduleForm_Load();
        }

        public void RepaymentScheduleForm_Load()
        {
            try
            {
                dataGridView2.Columns.Clear();
            }
            catch
            {
                MessageBox.Show("Zakończ edycje komórki nacikając ENTER przed przejściem do kolejnej");
                return;
            }
            dataGridView2.ReadOnly = false;

            dataGridView2.Columns.Add("indexColumn", "Lp.");
            dataGridView2.Columns["indexColumn"].ReadOnly = true;

            dataGridView2.Columns.Add("paymentAmountColumn", "Rata");
            dataGridView2.Columns["paymentAmountColumn"].ReadOnly = true;

            dataGridView2.Columns.Add("principalAmountColumn", "Kapitał");
            dataGridView2.Columns["principalAmountColumn"].ReadOnly = true;

            if (!basicSchedule || isEditMode)
            {
                dataGridView2.Columns.Add("overPaymentColumn", "Nadpłata");
                dataGridView2.Columns["overPaymentColumn"].ReadOnly = true;
            }
            if(isEditMode)
            {
                dataGridView2.Columns["overPaymentColumn"].ReadOnly = false;
                dataGridView2.Columns["overPaymentColumn"].DefaultCellStyle.BackColor = SystemColors.Highlight;
            }
            dataGridView2.Columns.Add("interestAmountColumn", "Odsetki");
            dataGridView2.Columns["interestAmountColumn"].ReadOnly = true;

            dataGridView2.Columns.Add("remainingBalanceColumn", "Pozostały do spłaty kapitał");
            dataGridView2.Columns["remainingBalanceColumn"].ReadOnly = true;

            fillGridRows(repaymentSchedule);

        }
        public void  fillGridRows(List<Repayment> schedule)
        {
            foreach (Repayment r in schedule)
            {
                int rowIndex = dataGridView2.Rows.Add();

                dataGridView2.Rows[rowIndex].Cells["indexColumn"].Value = r.PaymentNumber;
                dataGridView2.Rows[rowIndex].Cells["principalAmountColumn"].Value = Math.Round(r.PrincipalAmount, 2);
                dataGridView2.Rows[rowIndex].Cells["paymentAmountColumn"].Value = Math.Round(r.PaymentAmount, 2);
                dataGridView2.Rows[rowIndex].Cells["interestAmountColumn"].Value = Math.Round(r.InterestAmount, 2);
                dataGridView2.Rows[rowIndex].Cells["remainingBalanceColumn"].Value = Math.Round(r.RemainingBalance, 2);

                if (!basicSchedule)
                {
                    dataGridView2.Rows[rowIndex].Cells["overPaymentColumn"].Value = r.OverPayment.ToString("N2");
                }
            }
        }
        public event EventHandler<OverPaymentChangedEventArgs> OverPaymentChanged;

        public void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["overPaymentColumn"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                decimal overPayment;
                try
                {
                    overPayment = Convert.ToDecimal(dataGridView2.Rows[rowIndex].Cells["overPaymentColumn"].Value);
                }
                catch
                {
                    MessageBox.Show("Wprowadzono niepoprawne dane");
                    return;
                }
                OverPaymentChanged?.Invoke(this, new OverPaymentChangedEventArgs(rowIndex, overPayment));
            }

        }

        public void refreshGrid()
        {
            dataGridView2.Rows.Clear();
            fillGridRows(repaymentSchedule);
        }
    }
}

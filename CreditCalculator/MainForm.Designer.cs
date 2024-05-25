namespace CreditCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_loanAmount = new System.Windows.Forms.TextBox();
            this.txt_loanPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_interestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.lbl_repaymentAmount = new System.Windows.Forms.Label();
            this.lbl_loanAmount = new System.Windows.Forms.Label();
            this.lbl_interestTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_OpenScheduleLoan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cyclicOverPayment = new System.Windows.Forms.TextBox();
            this.btn_overPayment = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_oneOverPayment = new System.Windows.Forms.Button();
            this.txt_oneOverPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_loanPeriodChange = new System.Windows.Forms.Label();
            this.lbl_interestTotalChange = new System.Windows.Forms.Label();
            this.lbl_totalCostChange = new System.Windows.Forms.Label();
            this.lbl_loanPeriod = new System.Windows.Forms.Label();
            this.lbl_totalCostOverPayment = new System.Windows.Forms.Label();
            this.lbl_loanAmountOverPayment = new System.Windows.Forms.Label();
            this.btn_openScheduleWithOverpayment = new System.Windows.Forms.Button();
            this.lbl_interestTotalOverPayment = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_editSchedule = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.White;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calculate.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_calculate.Location = new System.Drawing.Point(178, 170);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(132, 33);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Przelicz";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // txt_loanAmount
            // 
            this.txt_loanAmount.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_loanAmount.Location = new System.Drawing.Point(303, 25);
            this.txt_loanAmount.Name = "txt_loanAmount";
            this.txt_loanAmount.Size = new System.Drawing.Size(100, 27);
            this.txt_loanAmount.TabIndex = 1;
            this.txt_loanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowOnlyDecimalNumbers);
            // 
            // txt_loanPeriod
            // 
            this.txt_loanPeriod.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_loanPeriod.Location = new System.Drawing.Point(303, 69);
            this.txt_loanPeriod.Name = "txt_loanPeriod";
            this.txt_loanPeriod.Size = new System.Drawing.Size(100, 27);
            this.txt_loanPeriod.TabIndex = 2;
            this.txt_loanPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loanPeriod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kwota kredytu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Okres kredytowania (w latach)";
            // 
            // txt_interestRate
            // 
            this.txt_interestRate.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_interestRate.Location = new System.Drawing.Point(303, 120);
            this.txt_interestRate.Name = "txt_interestRate";
            this.txt_interestRate.Size = new System.Drawing.Size(100, 27);
            this.txt_interestRate.TabIndex = 5;
            this.txt_interestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowOnlyDecimalNumbers);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(204, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "RRSO";
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalCost.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_totalCost.ForeColor = System.Drawing.Color.Snow;
            this.lbl_totalCost.Location = new System.Drawing.Point(15, 25);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(206, 20);
            this.lbl_totalCost.TabIndex = 7;
            this.lbl_totalCost.Text = "Całkowity koszt kredytu: ";
            // 
            // lbl_repaymentAmount
            // 
            this.lbl_repaymentAmount.AutoSize = true;
            this.lbl_repaymentAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_repaymentAmount.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_repaymentAmount.ForeColor = System.Drawing.Color.Snow;
            this.lbl_repaymentAmount.Location = new System.Drawing.Point(15, 136);
            this.lbl_repaymentAmount.Name = "lbl_repaymentAmount";
            this.lbl_repaymentAmount.Size = new System.Drawing.Size(130, 20);
            this.lbl_repaymentAmount.TabIndex = 8;
            this.lbl_repaymentAmount.Text = "Wysokość raty: ";
            // 
            // lbl_loanAmount
            // 
            this.lbl_loanAmount.AutoSize = true;
            this.lbl_loanAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loanAmount.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_loanAmount.ForeColor = System.Drawing.Color.Snow;
            this.lbl_loanAmount.Location = new System.Drawing.Point(15, 62);
            this.lbl_loanAmount.Name = "lbl_loanAmount";
            this.lbl_loanAmount.Size = new System.Drawing.Size(156, 20);
            this.lbl_loanAmount.TabIndex = 9;
            this.lbl_loanAmount.Text = "Pożyczona kwota: ";
            // 
            // lbl_interestTotal
            // 
            this.lbl_interestTotal.AutoSize = true;
            this.lbl_interestTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interestTotal.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_interestTotal.ForeColor = System.Drawing.Color.Snow;
            this.lbl_interestTotal.Location = new System.Drawing.Point(15, 99);
            this.lbl_interestTotal.Name = "lbl_interestTotal";
            this.lbl_interestTotal.Size = new System.Drawing.Size(147, 20);
            this.lbl_interestTotal.TabIndex = 10;
            this.lbl_interestTotal.Text = "Wartość odsetek: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_loanAmount);
            this.panel1.Controls.Add(this.txt_loanPeriod);
            this.panel1.Controls.Add(this.txt_interestRate);
            this.panel1.Controls.Add(this.btn_calculate);
            this.panel1.Location = new System.Drawing.Point(57, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 218);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_totalCost);
            this.panel2.Controls.Add(this.lbl_loanAmount);
            this.panel2.Controls.Add(this.btn_OpenScheduleLoan);
            this.panel2.Controls.Add(this.lbl_interestTotal);
            this.panel2.Controls.Add(this.lbl_repaymentAmount);
            this.panel2.Location = new System.Drawing.Point(614, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 203);
            this.panel2.TabIndex = 13;
            // 
            // btn_OpenScheduleLoan
            // 
            this.btn_OpenScheduleLoan.BackColor = System.Drawing.Color.White;
            this.btn_OpenScheduleLoan.Font = new System.Drawing.Font("Rubik", 7F);
            this.btn_OpenScheduleLoan.Location = new System.Drawing.Point(454, 49);
            this.btn_OpenScheduleLoan.Name = "btn_OpenScheduleLoan";
            this.btn_OpenScheduleLoan.Size = new System.Drawing.Size(118, 63);
            this.btn_OpenScheduleLoan.TabIndex = 18;
            this.btn_OpenScheduleLoan.Text = "Wyświetl harmonogram";
            this.btn_OpenScheduleLoan.UseVisualStyleBackColor = false;
            this.btn_OpenScheduleLoan.Click += new System.EventHandler(this.btn_OpenScheduleLoan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dodaj cykliczną co miesięczną nadpłatę";
            // 
            // txt_cyclicOverPayment
            // 
            this.txt_cyclicOverPayment.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_cyclicOverPayment.Location = new System.Drawing.Point(15, 53);
            this.txt_cyclicOverPayment.Name = "txt_cyclicOverPayment";
            this.txt_cyclicOverPayment.Size = new System.Drawing.Size(112, 27);
            this.txt_cyclicOverPayment.TabIndex = 16;
            this.txt_cyclicOverPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowOnlyDecimalNumbers);
            // 
            // btn_overPayment
            // 
            this.btn_overPayment.BackColor = System.Drawing.Color.White;
            this.btn_overPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_overPayment.Font = new System.Drawing.Font("Rubik", 8F);
            this.btn_overPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_overPayment.Location = new System.Drawing.Point(190, 54);
            this.btn_overPayment.Name = "btn_overPayment";
            this.btn_overPayment.Size = new System.Drawing.Size(81, 27);
            this.btn_overPayment.TabIndex = 17;
            this.btn_overPayment.Text = "Dodaj";
            this.btn_overPayment.UseVisualStyleBackColor = false;
            this.btn_overPayment.Click += new System.EventHandler(this.btn_cyclicOverPayment_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_cyclicOverPayment);
            this.panel3.Controls.Add(this.btn_overPayment);
            this.panel3.Location = new System.Drawing.Point(57, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 97);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btn_oneOverPayment);
            this.panel4.Controls.Add(this.txt_oneOverPayment);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(57, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 87);
            this.panel4.TabIndex = 20;
            // 
            // btn_oneOverPayment
            // 
            this.btn_oneOverPayment.BackColor = System.Drawing.Color.White;
            this.btn_oneOverPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oneOverPayment.Font = new System.Drawing.Font("Rubik", 8F);
            this.btn_oneOverPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_oneOverPayment.Location = new System.Drawing.Point(190, 45);
            this.btn_oneOverPayment.Name = "btn_oneOverPayment";
            this.btn_oneOverPayment.Size = new System.Drawing.Size(81, 27);
            this.btn_oneOverPayment.TabIndex = 18;
            this.btn_oneOverPayment.Text = "Dodaj";
            this.btn_oneOverPayment.UseVisualStyleBackColor = false;
            this.btn_oneOverPayment.Click += new System.EventHandler(this.btn_oneTimeOverPayment_Click);
            // 
            // txt_oneOverPayment
            // 
            this.txt_oneOverPayment.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_oneOverPayment.Location = new System.Drawing.Point(16, 45);
            this.txt_oneOverPayment.Name = "txt_oneOverPayment";
            this.txt_oneOverPayment.Size = new System.Drawing.Size(111, 27);
            this.txt_oneOverPayment.TabIndex = 17;
            this.txt_oneOverPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowOnlyDecimalNumbers);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(11, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dodaj jednorazową nadpłatę";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lbl_loanPeriodChange);
            this.panel5.Controls.Add(this.lbl_interestTotalChange);
            this.panel5.Controls.Add(this.lbl_totalCostChange);
            this.panel5.Controls.Add(this.lbl_loanPeriod);
            this.panel5.Controls.Add(this.lbl_totalCostOverPayment);
            this.panel5.Controls.Add(this.lbl_loanAmountOverPayment);
            this.panel5.Controls.Add(this.btn_openScheduleWithOverpayment);
            this.panel5.Controls.Add(this.lbl_interestTotalOverPayment);
            this.panel5.Location = new System.Drawing.Point(614, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(655, 273);
            this.panel5.TabIndex = 19;
            // 
            // lbl_loanPeriodChange
            // 
            this.lbl_loanPeriodChange.AutoSize = true;
            this.lbl_loanPeriodChange.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loanPeriodChange.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_loanPeriodChange.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_loanPeriodChange.Location = new System.Drawing.Point(337, 137);
            this.lbl_loanPeriodChange.Name = "lbl_loanPeriodChange";
            this.lbl_loanPeriodChange.Size = new System.Drawing.Size(0, 20);
            this.lbl_loanPeriodChange.TabIndex = 23;
            // 
            // lbl_interestTotalChange
            // 
            this.lbl_interestTotalChange.AutoSize = true;
            this.lbl_interestTotalChange.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interestTotalChange.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_interestTotalChange.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_interestTotalChange.Location = new System.Drawing.Point(337, 99);
            this.lbl_interestTotalChange.Name = "lbl_interestTotalChange";
            this.lbl_interestTotalChange.Size = new System.Drawing.Size(0, 20);
            this.lbl_interestTotalChange.TabIndex = 22;
            // 
            // lbl_totalCostChange
            // 
            this.lbl_totalCostChange.AutoSize = true;
            this.lbl_totalCostChange.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalCostChange.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_totalCostChange.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_totalCostChange.Location = new System.Drawing.Point(337, 20);
            this.lbl_totalCostChange.Name = "lbl_totalCostChange";
            this.lbl_totalCostChange.Size = new System.Drawing.Size(0, 20);
            this.lbl_totalCostChange.TabIndex = 21;
            // 
            // lbl_loanPeriod
            // 
            this.lbl_loanPeriod.AutoSize = true;
            this.lbl_loanPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loanPeriod.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_loanPeriod.ForeColor = System.Drawing.Color.Snow;
            this.lbl_loanPeriod.Location = new System.Drawing.Point(15, 137);
            this.lbl_loanPeriod.Name = "lbl_loanPeriod";
            this.lbl_loanPeriod.Size = new System.Drawing.Size(171, 20);
            this.lbl_loanPeriod.TabIndex = 19;
            this.lbl_loanPeriod.Text = "Okres kredytowania: ";
            // 
            // lbl_totalCostOverPayment
            // 
            this.lbl_totalCostOverPayment.AutoSize = true;
            this.lbl_totalCostOverPayment.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalCostOverPayment.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_totalCostOverPayment.ForeColor = System.Drawing.Color.Snow;
            this.lbl_totalCostOverPayment.Location = new System.Drawing.Point(15, 25);
            this.lbl_totalCostOverPayment.Name = "lbl_totalCostOverPayment";
            this.lbl_totalCostOverPayment.Size = new System.Drawing.Size(206, 20);
            this.lbl_totalCostOverPayment.TabIndex = 7;
            this.lbl_totalCostOverPayment.Text = "Całkowity koszt kredytu: ";
            // 
            // lbl_loanAmountOverPayment
            // 
            this.lbl_loanAmountOverPayment.AutoSize = true;
            this.lbl_loanAmountOverPayment.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loanAmountOverPayment.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_loanAmountOverPayment.ForeColor = System.Drawing.Color.Snow;
            this.lbl_loanAmountOverPayment.Location = new System.Drawing.Point(15, 62);
            this.lbl_loanAmountOverPayment.Name = "lbl_loanAmountOverPayment";
            this.lbl_loanAmountOverPayment.Size = new System.Drawing.Size(156, 20);
            this.lbl_loanAmountOverPayment.TabIndex = 9;
            this.lbl_loanAmountOverPayment.Text = "Pożyczona kwota: ";
            // 
            // btn_openScheduleWithOverpayment
            // 
            this.btn_openScheduleWithOverpayment.BackColor = System.Drawing.Color.White;
            this.btn_openScheduleWithOverpayment.Font = new System.Drawing.Font("Rubik", 7F);
            this.btn_openScheduleWithOverpayment.Location = new System.Drawing.Point(230, 183);
            this.btn_openScheduleWithOverpayment.Name = "btn_openScheduleWithOverpayment";
            this.btn_openScheduleWithOverpayment.Size = new System.Drawing.Size(118, 63);
            this.btn_openScheduleWithOverpayment.TabIndex = 18;
            this.btn_openScheduleWithOverpayment.Text = "Wyświetl harmonogram";
            this.btn_openScheduleWithOverpayment.UseVisualStyleBackColor = false;
            this.btn_openScheduleWithOverpayment.Click += new System.EventHandler(this.btn_openScheduleWithOverpayment_Click);
            // 
            // lbl_interestTotalOverPayment
            // 
            this.lbl_interestTotalOverPayment.AutoSize = true;
            this.lbl_interestTotalOverPayment.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interestTotalOverPayment.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_interestTotalOverPayment.ForeColor = System.Drawing.Color.Snow;
            this.lbl_interestTotalOverPayment.Location = new System.Drawing.Point(15, 99);
            this.lbl_interestTotalOverPayment.Name = "lbl_interestTotalOverPayment";
            this.lbl_interestTotalOverPayment.Size = new System.Drawing.Size(147, 20);
            this.lbl_interestTotalOverPayment.TabIndex = 10;
            this.lbl_interestTotalOverPayment.Text = "Wartość odsetek: ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btn_editSchedule);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(57, 540);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(515, 102);
            this.panel6.TabIndex = 21;
            // 
            // btn_editSchedule
            // 
            this.btn_editSchedule.BackColor = System.Drawing.Color.White;
            this.btn_editSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editSchedule.Font = new System.Drawing.Font("Rubik", 8F);
            this.btn_editSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_editSchedule.Location = new System.Drawing.Point(15, 45);
            this.btn_editSchedule.Name = "btn_editSchedule";
            this.btn_editSchedule.Size = new System.Drawing.Size(112, 33);
            this.btn_editSchedule.TabIndex = 19;
            this.btn_editSchedule.Text = "Edytuj";
            this.btn_editSchedule.UseVisualStyleBackColor = false;
            this.btn_editSchedule.Click += new System.EventHandler(this.btn_editSchedule_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rubik", 8F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(190, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Wyczyść dane o nadpłatach";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.clearOverPaymentData);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(11, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(449, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Edytuj nadpłatę dla każdej raty osobno w hamonogramie";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rubik", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(422, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Podstawowe informacje o kredycie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rubik", 14F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(377, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(505, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dane uwzględniające zdefiniowane nadpłaty";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::CreditCalculator.Properties.Resources.black_1072366_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 666);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Kalkulator kredytu hipotecznego";
            this.Click += new System.EventHandler(this.btn_OpenScheduleLoan_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_loanAmount;
        private System.Windows.Forms.TextBox txt_loanPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_interestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.Label lbl_repaymentAmount;
        private System.Windows.Forms.Label lbl_loanAmount;
        private System.Windows.Forms.Label lbl_interestTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cyclicOverPayment;
        private System.Windows.Forms.Button btn_overPayment;
        private System.Windows.Forms.Button btn_OpenScheduleLoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_oneOverPayment;
        private System.Windows.Forms.TextBox txt_oneOverPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_totalCostOverPayment;
        private System.Windows.Forms.Label lbl_loanAmountOverPayment;
        private System.Windows.Forms.Button btn_openScheduleWithOverpayment;
        private System.Windows.Forms.Label lbl_interestTotalOverPayment;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_editSchedule;
        private System.Windows.Forms.Label lbl_loanPeriod;
        private System.Windows.Forms.Label lbl_loanPeriodChange;
        private System.Windows.Forms.Label lbl_interestTotalChange;
        private System.Windows.Forms.Label lbl_totalCostChange;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


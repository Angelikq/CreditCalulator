namespace CreditCalculator
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_closeWelcomeForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_closeWelcomeForm
            // 
            this.btn_closeWelcomeForm.BackColor = System.Drawing.Color.White;
            this.btn_closeWelcomeForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeWelcomeForm.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_closeWelcomeForm.Location = new System.Drawing.Point(200, 369);
            this.btn_closeWelcomeForm.Name = "btn_closeWelcomeForm";
            this.btn_closeWelcomeForm.Size = new System.Drawing.Size(350, 42);
            this.btn_closeWelcomeForm.TabIndex = 0;
            this.btn_closeWelcomeForm.Text = "Przejdz do klakulatora";
            this.btn_closeWelcomeForm.UseVisualStyleBackColor = false;
            this.btn_closeWelcomeForm.Click += new System.EventHandler(this.btn_closeWelcomeForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(320, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witaj!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 145);
            this.label2.MinimumSize = new System.Drawing.Size(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(643, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezentowana aplikacja umożliwia obliczanie kosztów kredytu hipotecznego";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 190);
            this.label3.MinimumSize = new System.Drawing.Size(0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(605, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = " i harmonogramu spłaty, pozwala na definiowanie pojedynczych wpłat ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 235);
            this.label4.MinimumSize = new System.Drawing.Size(0, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(736, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "dodatkowych oraz weryfikację ich wpływu na koszty całkowite oraz okres kredytowan" +
    "ia";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CreditCalculator.Properties.Resources.black_1072366_1280;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_closeWelcomeForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "Kalkulator kredytu hipotecznego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_closeWelcomeForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
namespace Program_3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtCreditScore = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCarPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblLoanOffered = new System.Windows.Forms.Label();
            this.lblTotalOwed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clunker Sale Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Down Payment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Car:";
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Items.AddRange(new object[] {
            "PreOwned",
            "Certified-PreOwned",
            "New"});
            this.carTypeComboBox.Location = new System.Drawing.Point(102, 86);
            this.carTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(96, 21);
            this.carTypeComboBox.TabIndex = 5;
            // 
            // carComboBox
            // 
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Items.AddRange(new object[] {
            "Chevy Volt",
            "Mclaren 720s",
            "Subaru Outback",
            "Toyota Camry",
            "Saturn Sky",
            "Ford Mustang GT",
            "Honda Civic"});
            this.carComboBox.Location = new System.Drawing.Point(102, 122);
            this.carComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(96, 21);
            this.carComboBox.TabIndex = 6;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(102, 155);
            this.txtDownPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(95, 20);
            this.txtDownPayment.TabIndex = 7;
            // 
            // txtCreditScore
            // 
            this.txtCreditScore.Location = new System.Drawing.Point(102, 189);
            this.txtCreditScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreditScore.Name = "txtCreditScore";
            this.txtCreditScore.Size = new System.Drawing.Size(95, 20);
            this.txtCreditScore.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Car Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Loan Offered:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 301);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Discount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 323);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Down Payment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 370);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total You Owe:";
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarPrice.Location = new System.Drawing.Point(128, 275);
            this.lblCarPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.Size = new System.Drawing.Size(49, 13);
            this.lblCarPrice.TabIndex = 15;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(128, 301);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 16;
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDownPayment.Location = new System.Drawing.Point(128, 323);
            this.lblDownPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(49, 13);
            this.lblDownPayment.TabIndex = 17;
            // 
            // lblLoanOffered
            // 
            this.lblLoanOffered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoanOffered.Location = new System.Drawing.Point(128, 346);
            this.lblLoanOffered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanOffered.Name = "lblLoanOffered";
            this.lblLoanOffered.Size = new System.Drawing.Size(49, 13);
            this.lblLoanOffered.TabIndex = 18;
            // 
            // lblTotalOwed
            // 
            this.lblTotalOwed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalOwed.Location = new System.Drawing.Point(128, 370);
            this.lblTotalOwed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalOwed.Name = "lblTotalOwed";
            this.lblTotalOwed.Size = new System.Drawing.Size(49, 13);
            this.lblTotalOwed.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 477);
            this.Controls.Add(this.lblTotalOwed);
            this.Controls.Add(this.lblLoanOffered);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblCarPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCreditScore);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.carComboBox);
            this.Controls.Add(this.carTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Car Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtCreditScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCarPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblLoanOffered;
        private System.Windows.Forms.Label lblTotalOwed;
    }
}


namespace assignment2
{
    partial class AddInvoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            customerCodeInput = new TextBox();
            customerNameInput = new TextBox();
            label2 = new Label();
            lastMonthNumberInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            customerTypeCombobox = new ComboBox();
            numberOfPeopleInput = new TextBox();
            label5 = new Label();
            thisMonthNumberInput = new TextBox();
            label6 = new Label();
            currentMonthCombobox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            calculateButton = new Button();
            consumptionLabel = new Label();
            priceLabel = new Label();
            subtotalLabel = new Label();
            envFeeLabel = new Label();
            VATLabel = new Label();
            totalLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 45);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Code";
            // 
            // customerCodeInput
            // 
            customerCodeInput.Location = new Point(54, 78);
            customerCodeInput.Name = "customerCodeInput";
            customerCodeInput.Size = new Size(222, 27);
            customerCodeInput.TabIndex = 1;
            customerCodeInput.TextChanged += customerCodeInput_TextChanged;
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(54, 157);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(222, 27);
            customerNameInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 124);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Customer Name";
            // 
            // lastMonthNumberInput
            // 
            lastMonthNumberInput.Location = new Point(54, 235);
            lastMonthNumberInput.Name = "lastMonthNumberInput";
            lastMonthNumberInput.Size = new Size(222, 27);
            lastMonthNumberInput.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 202);
            label3.Name = "label3";
            label3.Size = new Size(236, 20);
            label3.TabIndex = 4;
            label3.Text = "Last month's water meter readings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 41);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 6;
            label4.Text = "Customer Type";
            // 
            // customerTypeCombobox
            // 
            customerTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerTypeCombobox.DropDownWidth = 300;
            customerTypeCombobox.FormattingEnabled = true;
            customerTypeCombobox.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            customerTypeCombobox.Location = new Point(488, 74);
            customerTypeCombobox.Name = "customerTypeCombobox";
            customerTypeCombobox.Size = new Size(222, 28);
            customerTypeCombobox.TabIndex = 7;
            customerTypeCombobox.SelectedIndexChanged += customerTypeCombobox_SelectedIndexChanged;
            // 
            // numberOfPeopleInput
            // 
            numberOfPeopleInput.Location = new Point(488, 153);
            numberOfPeopleInput.Name = "numberOfPeopleInput";
            numberOfPeopleInput.Size = new Size(222, 27);
            numberOfPeopleInput.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 120);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 8;
            label5.Text = "Number of people";
            // 
            // thisMonthNumberInput
            // 
            thisMonthNumberInput.Location = new Point(488, 231);
            thisMonthNumberInput.Name = "thisMonthNumberInput";
            thisMonthNumberInput.Size = new Size(222, 27);
            thisMonthNumberInput.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 198);
            label6.Name = "label6";
            label6.Size = new Size(236, 20);
            label6.TabIndex = 10;
            label6.Text = "This month's water meter readings";
            // 
            // currentMonthCombobox
            // 
            currentMonthCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            currentMonthCombobox.FormattingEnabled = true;
            currentMonthCombobox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            currentMonthCombobox.Location = new Point(488, 315);
            currentMonthCombobox.Name = "currentMonthCombobox";
            currentMonthCombobox.Size = new Size(222, 28);
            currentMonthCombobox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(488, 282);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 12;
            label7.Text = "Current Month";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 299);
            label8.Name = "label8";
            label8.Size = new Size(173, 20);
            label8.TabIndex = 14;
            label8.Text = "Amount of consumption:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 341);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 15;
            label9.Text = "Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 383);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 16;
            label10.Text = "Subtotal:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(54, 424);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 17;
            label11.Text = "Evironment Fees";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 464);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 18;
            label12.Text = "VAT (10%):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(54, 506);
            label13.Name = "label13";
            label13.Size = new Size(89, 38);
            label13.TabIndex = 19;
            label13.Text = "Total:";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.SpringGreen;
            calculateButton.Location = new Point(525, 413);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(185, 80);
            calculateButton.TabIndex = 20;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // consumptionLabel
            // 
            consumptionLabel.Location = new Point(254, 299);
            consumptionLabel.Name = "consumptionLabel";
            consumptionLabel.Size = new Size(158, 20);
            consumptionLabel.TabIndex = 22;
            consumptionLabel.Text = "0";
            consumptionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(254, 341);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(158, 20);
            priceLabel.TabIndex = 23;
            priceLabel.Text = "0";
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            subtotalLabel.Location = new Point(254, 383);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(158, 20);
            subtotalLabel.TabIndex = 24;
            subtotalLabel.Text = "0";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // envFeeLabel
            // 
            envFeeLabel.Location = new Point(254, 424);
            envFeeLabel.Name = "envFeeLabel";
            envFeeLabel.Size = new Size(158, 20);
            envFeeLabel.TabIndex = 25;
            envFeeLabel.Text = "0";
            envFeeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VATLabel
            // 
            VATLabel.Location = new Point(254, 464);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(158, 20);
            VATLabel.TabIndex = 26;
            VATLabel.Text = "0";
            VATLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            totalLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(241, 506);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(179, 38);
            totalLabel.TabIndex = 27;
            totalLabel.Text = "0";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AddInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(totalLabel);
            Controls.Add(VATLabel);
            Controls.Add(envFeeLabel);
            Controls.Add(subtotalLabel);
            Controls.Add(priceLabel);
            Controls.Add(consumptionLabel);
            Controls.Add(calculateButton);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(currentMonthCombobox);
            Controls.Add(label7);
            Controls.Add(thisMonthNumberInput);
            Controls.Add(label6);
            Controls.Add(numberOfPeopleInput);
            Controls.Add(label5);
            Controls.Add(customerTypeCombobox);
            Controls.Add(label4);
            Controls.Add(lastMonthNumberInput);
            Controls.Add(label3);
            Controls.Add(customerNameInput);
            Controls.Add(label2);
            Controls.Add(customerCodeInput);
            Controls.Add(label1);
            Name = "AddInvoice";
            Size = new Size(785, 599);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox customerCodeInput;
        private TextBox customerNameInput;
        private Label label2;
        private TextBox lastMonthNumberInput;
        private Label label3;
        private Label label4;
        private ComboBox customerTypeCombobox;
        private TextBox numberOfPeopleInput;
        private Label label5;
        private TextBox thisMonthNumberInput;
        private Label label6;
        private ComboBox currentMonthCombobox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button calculateButton;
        private Label consumptionLabel;
        private Label priceLabel;
        private Label subtotalLabel;
        private Label envFeeLabel;
        private Label VATLabel;
        private Label totalLabel;
    }
}

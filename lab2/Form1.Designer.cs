namespace lab2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFactInput = new TextBox();
            label2 = new Label();
            btnFactorialCalculate = new Button();
            label3 = new Label();
            label4 = new Label();
            txtSumInput = new TextBox();
            label5 = new Label();
            btnSumCalculate = new Button();
            label6 = new Label();
            listbox_factResult = new ListBox();
            listbox_sumResult = new ListBox();
            btnFactClear = new Button();
            btnSumClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 22);
            label1.TabIndex = 0;
            label1.Text = "FACTORIAL";
            // 
            // txtFactInput
            // 
            txtFactInput.Location = new Point(34, 73);
            txtFactInput.Name = "txtFactInput";
            txtFactInput.Size = new Size(147, 23);
            txtFactInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 53);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter one integer: ";
            // 
            // btnFactorialCalculate
            // 
            btnFactorialCalculate.Location = new Point(34, 102);
            btnFactorialCalculate.Name = "btnFactorialCalculate";
            btnFactorialCalculate.Size = new Size(84, 23);
            btnFactorialCalculate.TabIndex = 3;
            btnFactorialCalculate.Text = "CALCULATE";
            btnFactorialCalculate.UseVisualStyleBackColor = true;
            btnFactorialCalculate.Click += btnFactorialCalculate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 133);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Result: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(340, 9);
            label4.Name = "label4";
            label4.Size = new Size(52, 22);
            label4.TabIndex = 6;
            label4.Text = "SUM";
            // 
            // txtSumInput
            // 
            txtSumInput.Location = new Point(279, 73);
            txtSumInput.Name = "txtSumInput";
            txtSumInput.Size = new Size(202, 23);
            txtSumInput.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 55);
            label5.Name = "label5";
            label5.Size = new Size(202, 15);
            label5.TabIndex = 8;
            label5.Text = "Enter one integer: Sample '3,5,2,5,6,7'";
            // 
            // btnSumCalculate
            // 
            btnSumCalculate.Location = new Point(279, 102);
            btnSumCalculate.Name = "btnSumCalculate";
            btnSumCalculate.Size = new Size(84, 23);
            btnSumCalculate.TabIndex = 9;
            btnSumCalculate.Text = "CALCULATE";
            btnSumCalculate.UseVisualStyleBackColor = true;
            btnSumCalculate.Click += btnSumCalculate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 133);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 11;
            label6.Text = "Result: ";
            // 
            // listbox_factResult
            // 
            listbox_factResult.FormattingEnabled = true;
            listbox_factResult.ItemHeight = 15;
            listbox_factResult.Location = new Point(34, 157);
            listbox_factResult.Name = "listbox_factResult";
            listbox_factResult.Size = new Size(147, 34);
            listbox_factResult.TabIndex = 12;
            // 
            // listbox_sumResult
            // 
            listbox_sumResult.FormattingEnabled = true;
            listbox_sumResult.ItemHeight = 15;
            listbox_sumResult.Location = new Point(279, 157);
            listbox_sumResult.Name = "listbox_sumResult";
            listbox_sumResult.Size = new Size(202, 34);
            listbox_sumResult.TabIndex = 13;
            // 
            // btnFactClear
            // 
            btnFactClear.Location = new Point(124, 102);
            btnFactClear.Name = "btnFactClear";
            btnFactClear.Size = new Size(57, 23);
            btnFactClear.TabIndex = 14;
            btnFactClear.Text = "CLEAR";
            btnFactClear.UseVisualStyleBackColor = true;
            btnFactClear.Click += btnFactClear_Click;
            // 
            // btnSumClear
            // 
            btnSumClear.Location = new Point(424, 102);
            btnSumClear.Name = "btnSumClear";
            btnSumClear.Size = new Size(57, 23);
            btnSumClear.TabIndex = 15;
            btnSumClear.Text = "CLEAR";
            btnSumClear.UseVisualStyleBackColor = true;
            btnSumClear.Click += btnSumClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 205);
            Controls.Add(btnSumClear);
            Controls.Add(btnFactClear);
            Controls.Add(listbox_sumResult);
            Controls.Add(listbox_factResult);
            Controls.Add(label6);
            Controls.Add(btnSumCalculate);
            Controls.Add(label5);
            Controls.Add(txtSumInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnFactorialCalculate);
            Controls.Add(label2);
            Controls.Add(txtFactInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFactInput;
        private Label label2;
        private Button btnFactorialCalculate;
        private Label label3;
        private Label label4;
        private TextBox txtSumInput;
        private Label label5;
        private Button btnSumCalculate;
        private Label label6;
        private ListBox listbox_factResult;
        private ListBox listbox_sumResult;
        private Button btnFactClear;
        private Button btnSumClear;
    }
}

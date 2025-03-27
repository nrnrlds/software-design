namespace lab2
{
    partial class Fibonacci_Calculator
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
            btnFiboCalculate = new Button();
            label1 = new Label();
            txtFiboInput = new TextBox();
            FiboResult = new ListBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnFiboCalculate
            // 
            btnFiboCalculate.Location = new Point(32, 87);
            btnFiboCalculate.Name = "btnFiboCalculate";
            btnFiboCalculate.Size = new Size(79, 23);
            btnFiboCalculate.TabIndex = 0;
            btnFiboCalculate.Text = "CALCULATE";
            btnFiboCalculate.UseVisualStyleBackColor = true;
            btnFiboCalculate.Click += btnFiboCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter a Number: ";
            // 
            // txtFiboInput
            // 
            txtFiboInput.Location = new Point(32, 46);
            txtFiboInput.Name = "txtFiboInput";
            txtFiboInput.Size = new Size(160, 23);
            txtFiboInput.TabIndex = 2;
            // 
            // FiboResult
            // 
            FiboResult.FormattingEnabled = true;
            FiboResult.ItemHeight = 15;
            FiboResult.Location = new Point(217, 28);
            FiboResult.Name = "FiboResult";
            FiboResult.Size = new Size(231, 94);
            FiboResult.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(117, 87);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Fibonacci_Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 140);
            Controls.Add(btnClear);
            Controls.Add(FiboResult);
            Controls.Add(txtFiboInput);
            Controls.Add(label1);
            Controls.Add(btnFiboCalculate);
            Name = "Fibonacci_Calculator";
            Text = "Fibonacci_Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiboCalculate;
        private Label label1;
        private TextBox txtFiboInput;
        private ListBox FiboResult;
        private Button btnClear;
    }
}
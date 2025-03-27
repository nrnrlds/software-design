namespace lab2
{
    partial class Power_Calculator
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
            btnCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBaseInput = new TextBox();
            txtExpoInput = new TextBox();
            PowerResult = new ListBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(21, 151);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(73, 28);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 45);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter a Base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 104);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter a Exponent: ";
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(21, 63);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(132, 23);
            txtBaseInput.TabIndex = 3;
            // 
            // txtExpoInput
            // 
            txtExpoInput.Location = new Point(21, 122);
            txtExpoInput.Name = "txtExpoInput";
            txtExpoInput.Size = new Size(133, 23);
            txtExpoInput.TabIndex = 4;
            // 
            // PowerResult
            // 
            PowerResult.FormattingEnabled = true;
            PowerResult.ItemHeight = 15;
            PowerResult.Location = new Point(172, 45);
            PowerResult.Name = "PowerResult";
            PowerResult.Size = new Size(173, 154);
            PowerResult.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(100, 151);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(54, 28);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Power_Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 230);
            Controls.Add(btnClear);
            Controls.Add(PowerResult);
            Controls.Add(txtExpoInput);
            Controls.Add(txtBaseInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Name = "Power_Calculator";
            Text = "Power_Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private TextBox txtBaseInput;
        private TextBox txtExpoInput;
        private ListBox PowerResult;
        private Button btnClear;
    }
}
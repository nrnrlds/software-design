namespace lab1
{
    partial class BubbleSort
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
            btnSort = new Button();
            btnClear = new Button();
            InputNumber = new TextBox();
            label1 = new Label();
            listBoxSortResult = new ListBox();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(28, 98);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(109, 98);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // InputNumber
            // 
            InputNumber.Location = new Point(28, 45);
            InputNumber.Name = "InputNumber";
            InputNumber.Size = new Size(156, 23);
            InputNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter a number: ";
            // 
            // listBoxSortResult
            // 
            listBoxSortResult.FormattingEnabled = true;
            listBoxSortResult.ItemHeight = 15;
            listBoxSortResult.Location = new Point(209, 26);
            listBoxSortResult.Name = "listBoxSortResult";
            listBoxSortResult.Size = new Size(222, 109);
            listBoxSortResult.TabIndex = 4;
            // 
            // BubbleSort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 162);
            Controls.Add(listBoxSortResult);
            Controls.Add(label1);
            Controls.Add(InputNumber);
            Controls.Add(btnClear);
            Controls.Add(btnSort);
            Name = "BubbleSort";
            Text = "BubbleSort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSort;
        private Button btnClear;
        private TextBox InputNumber;
        private Label label1;
        private ListBox listBoxSortResult;
    }
}
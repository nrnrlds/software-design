namespace lab3
{
    partial class Task_3
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
            ListBooks = new ListBox();
            btnShowInfo = new Button();
            SuspendLayout();
            // 
            // ListBooks
            // 
            ListBooks.FormattingEnabled = true;
            ListBooks.ItemHeight = 15;
            ListBooks.Location = new Point(26, 22);
            ListBooks.Name = "ListBooks";
            ListBooks.Size = new Size(315, 259);
            ListBooks.TabIndex = 3;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(108, 301);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(128, 31);
            btnShowInfo.TabIndex = 2;
            btnShowInfo.Text = "Show Information";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click_1;
            // 
            // Task_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 360);
            Controls.Add(ListBooks);
            Controls.Add(btnShowInfo);
            Name = "Task_3";
            Text = "Task_3";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBooks;
        private Button btnShowInfo;
    }
}
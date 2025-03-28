namespace Task_3
{
    partial class Task_3
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
            btnShowInfo = new Button();
            ListBooks = new ListBox();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(110, 305);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(128, 31);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Information";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // ListBooks
            // 
            ListBooks.FormattingEnabled = true;
            ListBooks.ItemHeight = 15;
            ListBooks.Location = new Point(28, 26);
            ListBooks.Name = "ListBooks";
            ListBooks.Size = new Size(315, 259);
            ListBooks.TabIndex = 1;
            // 
            // Task_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 359);
            Controls.Add(ListBooks);
            Controls.Add(btnShowInfo);
            Name = "Task_3";
            Text = "Task 3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private ListBox ListBooks;
    }
}

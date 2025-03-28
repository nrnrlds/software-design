namespace lab3
{
    partial class Task_2
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
            btnShowInfo = new Button();
            ListBooks = new ListBox();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(111, 377);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(95, 34);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // ListBooks
            // 
            ListBooks.FormattingEnabled = true;
            ListBooks.ItemHeight = 15;
            ListBooks.Location = new Point(25, 27);
            ListBooks.Name = "ListBooks";
            ListBooks.Size = new Size(303, 334);
            ListBooks.TabIndex = 1;
            // 
            // Task_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 450);
            Controls.Add(ListBooks);
            Controls.Add(btnShowInfo);
            Name = "Task_2";
            Text = "Task_2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private ListBox ListBooks;
    }
}
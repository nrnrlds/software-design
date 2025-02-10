namespace lab3
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
            BookListBox = new ListBox();
            DisplayBooksButton = new Button();
            AddBookButton = new Button();
            ClearList = new Button();
            TitleTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            YearTextBox = new TextBox();
            IssueTextBox = new TextBox();
            FormatTextBox = new TextBox();
            SubjectTextBox = new TextBox();
            DurationTextBox = new TextBox();
            NarratorTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BookTypeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // BookListBox
            // 
            BookListBox.FormattingEnabled = true;
            BookListBox.ItemHeight = 15;
            BookListBox.Location = new Point(245, 27);
            BookListBox.Name = "BookListBox";
            BookListBox.Size = new Size(543, 229);
            BookListBox.TabIndex = 0;
            // 
            // DisplayBooksButton
            // 
            DisplayBooksButton.Location = new Point(419, 281);
            DisplayBooksButton.Name = "DisplayBooksButton";
            DisplayBooksButton.Size = new Size(91, 23);
            DisplayBooksButton.TabIndex = 1;
            DisplayBooksButton.Text = "Display Books";
            DisplayBooksButton.UseVisualStyleBackColor = true;
            DisplayBooksButton.Click += DisplayBooksButton_Click_1;
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(516, 280);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(91, 23);
            AddBookButton.TabIndex = 2;
            AddBookButton.Text = "Add Book";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // ClearList
            // 
            ClearList.Location = new Point(613, 281);
            ClearList.Name = "ClearList";
            ClearList.Size = new Size(91, 23);
            ClearList.TabIndex = 3;
            ClearList.Text = "Clear List";
            ClearList.UseVisualStyleBackColor = true;
            ClearList.Click += ClearList_Click;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(33, 27);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(179, 23);
            TitleTextBox.TabIndex = 4;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(33, 74);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(179, 23);
            AuthorTextBox.TabIndex = 5;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(33, 123);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(179, 23);
            YearTextBox.TabIndex = 6;
            // 
            // IssueTextBox
            // 
            IssueTextBox.Location = new Point(33, 171);
            IssueTextBox.Name = "IssueTextBox";
            IssueTextBox.Size = new Size(179, 23);
            IssueTextBox.TabIndex = 7;
            IssueTextBox.TextChanged += IssueTextBox_TextChanged;
            // 
            // FormatTextBox
            // 
            FormatTextBox.Location = new Point(33, 218);
            FormatTextBox.Name = "FormatTextBox";
            FormatTextBox.Size = new Size(179, 23);
            FormatTextBox.TabIndex = 8;
            // 
            // SubjectTextBox
            // 
            SubjectTextBox.Location = new Point(33, 267);
            SubjectTextBox.Name = "SubjectTextBox";
            SubjectTextBox.Size = new Size(179, 23);
            SubjectTextBox.TabIndex = 9;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(33, 315);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(179, 23);
            DurationTextBox.TabIndex = 10;
            // 
            // NarratorTextBox
            // 
            NarratorTextBox.Location = new Point(33, 363);
            NarratorTextBox.Name = "NarratorTextBox";
            NarratorTextBox.Size = new Size(179, 23);
            NarratorTextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 12;
            label1.Text = "Title: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 58);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 13;
            label2.Text = "Author: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 107);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 14;
            label3.Text = "Year: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 154);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 15;
            label4.Text = "IssueNumber: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 202);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 16;
            label5.Text = "Format: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 249);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 17;
            label6.Text = "Subject: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 298);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 18;
            label7.Text = "Duration: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 346);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 19;
            label8.Text = "Narrator: ";
            // 
            // BookTypeComboBox
            // 
            BookTypeComboBox.FormattingEnabled = true;
            BookTypeComboBox.Location = new Point(245, 281);
            BookTypeComboBox.Name = "BookTypeComboBox";
            BookTypeComboBox.Size = new Size(168, 23);
            BookTypeComboBox.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookTypeComboBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NarratorTextBox);
            Controls.Add(DurationTextBox);
            Controls.Add(SubjectTextBox);
            Controls.Add(FormatTextBox);
            Controls.Add(IssueTextBox);
            Controls.Add(YearTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(ClearList);
            Controls.Add(AddBookButton);
            Controls.Add(DisplayBooksButton);
            Controls.Add(BookListBox);
            Name = "Form1";
            Text = "Laboratory Exercise";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox BookListBox;
        private Button DisplayBooksButton;
        private Button AddBookButton;
        private Button ClearList;
        private TextBox TitleTextBox;
        private TextBox AuthorTextBox;
        private TextBox YearTextBox;
        private TextBox IssueTextBox;
        private TextBox FormatTextBox;
        private TextBox SubjectTextBox;
        private TextBox DurationTextBox;
        private TextBox NarratorTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox BookTypeComboBox;
    }
}

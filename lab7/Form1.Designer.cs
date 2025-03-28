namespace lab7
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
            btnSearch = new Button();
            listBooks = new ListBox();
            txtSearch = new TextBox();
            btnExport = new Button();
            btnImport = new Button();
            lblPageNum = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(34, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listBooks
            // 
            listBooks.FormattingEnabled = true;
            listBooks.ItemHeight = 15;
            listBooks.Location = new Point(34, 93);
            listBooks.Name = "listBooks";
            listBooks.Size = new Size(310, 184);
            listBooks.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(128, 64);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(131, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(102, 293);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(206, 293);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 4;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // lblPageNum
            // 
            lblPageNum.AutoSize = true;
            lblPageNum.Location = new Point(266, 255);
            lblPageNum.Name = "lblPageNum";
            lblPageNum.Size = new Size(42, 15);
            lblPageNum.TabIndex = 5;
            lblPageNum.Text = "Page 1";
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(229, 251);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(31, 23);
            btnPrev.TabIndex = 6;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(310, 251);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(31, 23);
            btnNext.TabIndex = 7;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(lblPageNum);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(txtSearch);
            Controls.Add(listBooks);
            Controls.Add(btnSearch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private ListBox listBooks;
        private TextBox txtSearch;
        private Button btnExport;
        private Button btnImport;
        private Label lblPageNum;
        private Button btnPrev;
        private Button btnNext;
    }
}

namespace lab6
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
            label2 = new Label();
            label3 = new Label();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtID = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnFetch = new Button();
            btnSearch = new Button();
            listBookSearch = new ListBox();
            listBookFetch = new ListBox();
            txtSearch = new TextBox();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 47);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Author: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 81);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Title: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 119);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(84, 44);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(142, 23);
            txtAuthor.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(84, 78);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(142, 23);
            txtTitle.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(84, 116);
            txtID.Name = "txtID";
            txtID.Size = new Size(142, 23);
            txtID.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(112, 157);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(112, 186);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(112, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFetch
            // 
            btnFetch.Location = new Point(262, 186);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(75, 23);
            btnFetch.TabIndex = 9;
            btnFetch.Text = "Fetch";
            btnFetch.UseVisualStyleBackColor = true;
            btnFetch.Click += btnFetch_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(257, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listBookSearch
            // 
            listBookSearch.FormattingEnabled = true;
            listBookSearch.ItemHeight = 15;
            listBookSearch.Location = new Point(262, 37);
            listBookSearch.Name = "listBookSearch";
            listBookSearch.Size = new Size(262, 139);
            listBookSearch.TabIndex = 11;
            // 
            // listBookFetch
            // 
            listBookFetch.FormattingEnabled = true;
            listBookFetch.ItemHeight = 15;
            listBookFetch.Location = new Point(262, 215);
            listBookFetch.Name = "listBookFetch";
            listBookFetch.Size = new Size(262, 139);
            listBookFetch.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(338, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 13;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 331);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(244, 23);
            progressBar.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 373);
            Controls.Add(progressBar);
            Controls.Add(txtSearch);
            Controls.Add(listBookFetch);
            Controls.Add(listBookSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnFetch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private TextBox txtID;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnFetch;
        private Button btnSearch;
        private ListBox listBookSearch;
        private ListBox listBookFetch;
        private TextBox txtSearch;
        private ProgressBar progressBar;
    }
}

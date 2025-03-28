namespace lab5
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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtID = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            ListBook = new ListBox();
            btnShow = new Button();
            btnSearchAuthor = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSearchAuthor = new TextBox();
            txtDelete = new TextBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(181, 74);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(139, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(181, 100);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(139, 23);
            txtAuthor.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(181, 129);
            txtID.Name = "txtID";
            txtID.Size = new Size(139, 23);
            txtID.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(181, 170);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(58, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(259, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(58, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ListBook
            // 
            ListBook.FormattingEnabled = true;
            ListBook.ItemHeight = 15;
            ListBook.Location = new Point(26, 210);
            ListBook.Name = "ListBook";
            ListBook.Size = new Size(331, 199);
            ListBook.TabIndex = 5;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(26, 415);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Location = new Point(127, 415);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(98, 23);
            btnSearchAuthor.TabIndex = 7;
            btnSearchAuthor.Text = "Search Author";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(259, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 77);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 9;
            label1.Text = "Title: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 103);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 10;
            label2.Text = "Author: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 132);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 11;
            label3.Text = "ID Number: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(127, 23);
            label4.Name = "label4";
            label4.Size = new Size(129, 31);
            label4.TabIndex = 12;
            label4.Text = "Book Info";
            // 
            // txtSearchAuthor
            // 
            txtSearchAuthor.Location = new Point(127, 444);
            txtSearchAuthor.Name = "txtSearchAuthor";
            txtSearchAuthor.Size = new Size(100, 23);
            txtSearchAuthor.TabIndex = 13;
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(259, 444);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(100, 23);
            txtDelete.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 476);
            Controls.Add(txtDelete);
            Controls.Add(txtSearchAuthor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnSearchAuthor);
            Controls.Add(btnShow);
            Controls.Add(ListBook);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtID;
        private Button btnAdd;
        private Button btnUpdate;
        private ListBox ListBook;
        private Button btnShow;
        private Button btnSearchAuthor;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSearchAuthor;
        private TextBox txtDelete;
    }
}

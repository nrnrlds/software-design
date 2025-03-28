namespace Lab5_1
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
            txtDelete = new TextBox();
            txtSearchAuthor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            btnSearchAuthor = new Button();
            btnShow = new Button();
            ListBook = new ListBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtID = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            SuspendLayout();
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(249, 430);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(100, 23);
            txtDelete.TabIndex = 29;
            // 
            // txtSearchAuthor
            // 
            txtSearchAuthor.Location = new Point(117, 430);
            txtSearchAuthor.Name = "txtSearchAuthor";
            txtSearchAuthor.Size = new Size(100, 23);
            txtSearchAuthor.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 9);
            label4.Name = "label4";
            label4.Size = new Size(129, 31);
            label4.TabIndex = 27;
            label4.Text = "Book Info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 118);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 26;
            label3.Text = "ID Number: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 89);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 25;
            label2.Text = "Author: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 63);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 24;
            label1.Text = "Title: ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(249, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete ";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Location = new Point(117, 401);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(98, 23);
            btnSearchAuthor.TabIndex = 22;
            btnSearchAuthor.Text = "Search Author";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(16, 401);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 21;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // ListBook
            // 
            ListBook.FormattingEnabled = true;
            ListBook.ItemHeight = 15;
            ListBook.Location = new Point(16, 196);
            ListBook.Name = "ListBook";
            ListBook.Size = new Size(331, 199);
            ListBook.TabIndex = 20;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(249, 156);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(58, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(171, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(58, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(171, 115);
            txtID.Name = "txtID";
            txtID.Size = new Size(139, 23);
            txtID.TabIndex = 17;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(171, 86);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(139, 23);
            txtAuthor.TabIndex = 16;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(171, 60);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(139, 23);
            txtTitle.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 467);
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

        private TextBox txtDelete;
        private TextBox txtSearchAuthor;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnSearchAuthor;
        private Button btnShow;
        private ListBox ListBook;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtID;
        private TextBox txtAuthor;
        private TextBox txtTitle;
    }
}

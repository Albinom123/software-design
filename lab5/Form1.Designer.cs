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
            panel1 = new Panel();
            panel2 = new Panel();
            listBoxBooks = new ListBox();
            groupBox1 = new GroupBox();
            btnSearchAuthor = new Button();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnShowBooks = new Button();
            btnAddBook = new Button();
            txtBookID = new TextBox();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtBookID);
            panel1.Controls.Add(txtBookTitle);
            panel1.Controls.Add(txtAuthorName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1249, 790);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(listBoxBooks);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(29, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(1193, 605);
            panel2.TabIndex = 7;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(31, 151);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(1129, 424);
            listBoxBooks.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearchAuthor);
            groupBox1.Controls.Add(btnDeleteBook);
            groupBox1.Controls.Add(btnUpdateBook);
            groupBox1.Controls.Add(btnShowBooks);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Location = new Point(31, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Location = new Point(895, 26);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(210, 41);
            btnSearchAuthor.TabIndex = 4;
            btnSearchAuthor.Text = "Search by Author";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(679, 26);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(210, 41);
            btnDeleteBook.TabIndex = 3;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(463, 26);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(210, 41);
            btnUpdateBook.TabIndex = 2;
            btnUpdateBook.Text = "Update Record";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(247, 26);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(210, 41);
            btnShowBooks.TabIndex = 1;
            btnShowBooks.Text = "Show All Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(31, 26);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(210, 41);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Add Book And Author";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(622, 62);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(288, 27);
            txtBookID.TabIndex = 6;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(145, 103);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(288, 27);
            txtBookTitle.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(145, 62);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(288, 27);
            txtAuthorName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 69);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "Book ID (Key):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 110);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Book Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Author Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(231, 20);
            label1.TabIndex = 0;
            label1.Text = "[ Book and Author Management ]";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 790);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBookID;
        private Panel panel2;
        private ListBox listBoxBooks;
        private GroupBox groupBox1;
        private Button btnAddBook;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnShowBooks;
        private Button btnSearchAuthor;
    }
}

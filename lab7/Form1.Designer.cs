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
            panel1 = new Panel();
            panel2 = new Panel();
            lblPageNumber = new Label();
            btnNextPage = new Button();
            btnPreviousPage = new Button();
            listBoxBooks = new ListBox();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtBookTitle = new TextBox();
            btnImport = new Button();
            txtAuthorName = new TextBox();
            btnExportBooks = new Button();
            label3 = new Label();
            label2 = new Label();
            btnAddBook = new Button();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtSearchTitle = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 580);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPageNumber);
            panel2.Controls.Add(btnNextPage);
            panel2.Controls.Add(btnPreviousPage);
            panel2.Controls.Add(listBoxBooks);
            panel2.Location = new Point(339, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 499);
            panel2.TabIndex = 13;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(191, 408);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(56, 20);
            lblPageNumber.TabIndex = 9;
            lblPageNumber.Text = "Page: 1";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(331, 401);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(103, 35);
            btnNextPage.TabIndex = 8;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(12, 401);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(103, 35);
            btnPreviousPage.TabIndex = 7;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(12, 24);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(422, 364);
            listBoxBooks.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(486, 36);
            label4.Name = "label4";
            label4.Size = new Size(190, 31);
            label4.TabIndex = 12;
            label4.Text = "Books Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 36);
            label1.Name = "label1";
            label1.Size = new Size(172, 31);
            label1.TabIndex = 11;
            label1.Text = "Manage Books";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBookTitle);
            groupBox2.Controls.Add(btnImport);
            groupBox2.Controls.Add(txtAuthorName);
            groupBox2.Controls.Add(btnExportBooks);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnAddBook);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 330);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Book And Author";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(13, 184);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(288, 34);
            txtBookTitle.TabIndex = 9;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(215, 239);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(95, 66);
            btnImport.TabIndex = 3;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(13, 91);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(288, 34);
            txtAuthorName.TabIndex = 8;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(118, 239);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(91, 66);
            btnExportBooks.TabIndex = 2;
            btnExportBooks.Text = "Export";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 153);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 7;
            label3.Text = "Book Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 60);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 6;
            label2.Text = "Author Name:";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(13, 238);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(99, 67);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearchTitle);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Books";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(115, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(24, 38);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(277, 27);
            txtSearchTitle.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ListBox listBoxBooks;
        private Label label4;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtBookTitle;
        private Button btnImport;
        private TextBox txtAuthorName;
        private Button btnExportBooks;
        private Label label3;
        private Label label2;
        private Button btnAddBook;
        private GroupBox groupBox1;
        private TextBox txtSearchTitle;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private Label lblPageNumber;
        private Button btnSearch;
    }
}

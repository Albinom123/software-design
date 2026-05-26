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
            panel1 = new Panel();
            panel2 = new Panel();
            lblFetchStatus = new Label();
            progressBarProgress = new ProgressBar();
            listBoxBooks = new ListBox();
            btnFetchBooks = new Button();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtBookTitle = new TextBox();
            btnDeleteBook = new Button();
            txtAuthorName = new TextBox();
            btnUpdateBook = new Button();
            label3 = new Label();
            label2 = new Label();
            btnAddBook = new Button();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
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
            panel1.Size = new Size(702, 567);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblFetchStatus);
            panel2.Controls.Add(progressBarProgress);
            panel2.Controls.Add(listBoxBooks);
            panel2.Controls.Add(btnFetchBooks);
            panel2.Location = new Point(339, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 467);
            panel2.TabIndex = 13;
            // 
            // lblFetchStatus
            // 
            lblFetchStatus.AutoSize = true;
            lblFetchStatus.Location = new Point(12, 398);
            lblFetchStatus.Name = "lblFetchStatus";
            lblFetchStatus.Size = new Size(120, 20);
            lblFetchStatus.TabIndex = 6;
            lblFetchStatus.Text = "Fetch Status: Idle";
            // 
            // progressBarProgress
            // 
            progressBarProgress.Location = new Point(12, 421);
            progressBarProgress.Name = "progressBarProgress";
            progressBarProgress.Size = new Size(287, 29);
            progressBarProgress.TabIndex = 5;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(12, 64);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(320, 324);
            listBoxBooks.TabIndex = 1;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.BackColor = Color.DarkTurquoise;
            btnFetchBooks.ForeColor = SystemColors.ControlLightLight;
            btnFetchBooks.Location = new Point(95, 3);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(157, 42);
            btnFetchBooks.TabIndex = 4;
            btnFetchBooks.Text = "Refresh Book List";
            btnFetchBooks.UseVisualStyleBackColor = false;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(457, 36);
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
            groupBox2.Controls.Add(btnDeleteBook);
            groupBox2.Controls.Add(txtAuthorName);
            groupBox2.Controls.Add(btnUpdateBook);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnAddBook);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 386);
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
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(215, 255);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(95, 66);
            btnDeleteBook.TabIndex = 3;
            btnDeleteBook.Text = "Delete ";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(13, 91);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(288, 34);
            txtAuthorName.TabIndex = 8;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(118, 255);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(91, 66);
            btnUpdateBook.TabIndex = 2;
            btnUpdateBook.Text = "Update ";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
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
            btnAddBook.Location = new Point(13, 254);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(99, 67);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Add New Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 86);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Books";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(24, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(277, 27);
            txtSearch.TabIndex = 9;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 567);
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
        private GroupBox groupBox2;
        private ListBox listBoxBooks;
        private GroupBox groupBox1;
        private Button btnFetchBooks;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnAddBook;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Label label3;
        private Label label2;
        private TextBox txtSearch;
        private Label label4;
        private Label label1;
        private Panel panel2;
        private ProgressBar progressBarProgress;
        private Label lblFetchStatus;
    }
}

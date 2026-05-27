namespace lab8
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
            groupBox1 = new GroupBox();
            txtBookDetails = new TextBox();
            btnFetchBook = new Button();
            label2 = new Label();
            label1 = new Label();
            txtISBN = new TextBox();
            groupBox2 = new GroupBox();
            lstBooks = new ListBox();
            label4 = new Label();
            label3 = new Label();
            btnSearchAuthor = new Button();
            txtAuthorSearch = new TextBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightCyan;
            groupBox1.Controls.Add(txtBookDetails);
            groupBox1.Controls.Add(btnFetchBook);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(636, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "[ GroupBox: ISBN Lookup (Tasks 1 and 2) ]";
            // 
            // txtBookDetails
            // 
            txtBookDetails.Location = new Point(20, 136);
            txtBookDetails.Multiline = true;
            txtBookDetails.Name = "txtBookDetails";
            txtBookDetails.Size = new Size(589, 80);
            txtBookDetails.TabIndex = 3;
            // 
            // btnFetchBook
            // 
            btnFetchBook.BackColor = Color.LightSeaGreen;
            btnFetchBook.Location = new Point(460, 59);
            btnFetchBook.Name = "btnFetchBook";
            btnFetchBook.Size = new Size(149, 29);
            btnFetchBook.TabIndex = 2;
            btnFetchBook.Text = "Fetch Book Details";
            btnFetchBook.UseVisualStyleBackColor = false;
            btnFetchBook.Click += btnFetchBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 113);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Results Output:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 68);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Book ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(146, 61);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(308, 27);
            txtISBN.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightCyan;
            groupBox2.Controls.Add(lstBooks);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnSearchAuthor);
            groupBox2.Controls.Add(txtAuthorSearch);
            groupBox2.Location = new Point(12, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(636, 372);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "[ GroupBox: Author Search Challenge (Task 3) ]";
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.Location = new Point(20, 160);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(589, 184);
            lstBooks.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 129);
            label4.Name = "label4";
            label4.Size = new Size(196, 20);
            label4.TabIndex = 5;
            label4.Text = "Matching Book Titles Found:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 43);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 4;
            label3.Text = "Search by Author Name:";
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.BackColor = Color.LightSeaGreen;
            btnSearchAuthor.Location = new Point(268, 78);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(165, 29);
            btnSearchAuthor.TabIndex = 2;
            btnSearchAuthor.Text = "Search by Author";
            btnSearchAuthor.UseVisualStyleBackColor = false;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // txtAuthorSearch
            // 
            txtAuthorSearch.Location = new Point(20, 79);
            txtAuthorSearch.Name = "txtAuthorSearch";
            txtAuthorSearch.Size = new Size(242, 27);
            txtAuthorSearch.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 665);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 665);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFetchBook;
        private Label label1;
        private TextBox txtISBN;
        private TextBox txtBookDetails;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnSearchAuthor;
        private TextBox txtAuthorSearch;
        private Label label3;
        private ListBox lstBooks;
        private Label label4;
        private Panel panel1;
    }
}

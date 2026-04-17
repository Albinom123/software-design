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
            btnShowInfo = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnShowInfo3 = new Button();
            label3 = new Label();
            label2 = new Label();
            btnShowInfo2 = new Button();
            lstBooks = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(26, 59);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(75, 23);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Olive;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnShowInfo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 260);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "\"Task 1\"";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnShowInfo3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnShowInfo2);
            panel2.Controls.Add(lstBooks);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(126, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 260);
            panel2.TabIndex = 2;
            // 
            // btnShowInfo3
            // 
            btnShowInfo3.Location = new Point(32, 148);
            btnShowInfo3.Name = "btnShowInfo3";
            btnShowInfo3.Size = new Size(75, 23);
            btnShowInfo3.TabIndex = 4;
            btnShowInfo3.Text = "Show Info";
            btnShowInfo3.UseVisualStyleBackColor = true;
            btnShowInfo3.Click += btnShowInfo3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 108);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 3;
            label3.Text = "\"Task 3\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 28);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "\"Task 2\"";
            // 
            // btnShowInfo2
            // 
            btnShowInfo2.Location = new Point(32, 59);
            btnShowInfo2.Name = "btnShowInfo2";
            btnShowInfo2.Size = new Size(75, 23);
            btnShowInfo2.TabIndex = 1;
            btnShowInfo2.Text = "Show Info";
            btnShowInfo2.UseVisualStyleBackColor = true;
            btnShowInfo2.Click += btnShowInfo2_Click;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 15;
            lstBooks.Location = new Point(152, 12);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(441, 229);
            lstBooks.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(731, 260);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ListBox lstBooks;
        private Button btnShowInfo2;
        private Label label3;
        private Label label2;
        private Button btnShowInfo3;
    }
}

namespace lab4
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
            lstBooks = new ListBox();
            btnShowBooks = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstBooks
            // 
            lstBooks.Dock = DockStyle.Right;
            lstBooks.FormattingEnabled = true;
            lstBooks.Location = new Point(420, 0);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(380, 450);
            lstBooks.TabIndex = 0;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowBooks.ForeColor = Color.DarkOliveGreen;
            btnShowBooks.Location = new Point(123, 135);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(162, 61);
            btnShowBooks.TabIndex = 1;
            btnShowBooks.Text = "Display All Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 46);
            label1.Name = "label1";
            label1.Size = new Size(273, 38);
            label1.TabIndex = 2;
            label1.Text = "\"Library Inventory\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnShowBooks);
            Controls.Add(lstBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBooks;
        private Button btnShowBooks;
        private Label label1;
    }
}

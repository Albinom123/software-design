namespace Task_5
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
            listBoxResults = new ListBox();
            btnSortBubble = new Button();
            btnCDO = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(168, 21);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(200, 169);
            listBoxResults.TabIndex = 0;
            // 
            // btnSortBubble
            // 
            btnSortBubble.Location = new Point(38, 21);
            btnSortBubble.Name = "btnSortBubble";
            btnSortBubble.Size = new Size(104, 23);
            btnSortBubble.TabIndex = 1;
            btnSortBubble.Text = "Bubble Sort";
            btnSortBubble.UseVisualStyleBackColor = true;
            btnSortBubble.Click += btnSortBubble_Click;
            // 
            // btnCDO
            // 
            btnCDO.Location = new Point(38, 126);
            btnCDO.Name = "btnCDO";
            btnCDO.Size = new Size(104, 64);
            btnCDO.TabIndex = 2;
            btnCDO.Text = "Custom Descending Order";
            btnCDO.UseVisualStyleBackColor = true;
            btnCDO.Click += btnCDO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 234);
            Controls.Add(btnCDO);
            Controls.Add(btnSortBubble);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnSortBubble;
        private Button btnCDO;
    }
}

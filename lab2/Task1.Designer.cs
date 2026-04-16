namespace lab2
{
	partial class Task1
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
            btnCalculateFactorial = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            txtArrayInput = new TextBox();
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            txtFibonacciInput = new TextBox();
            btnCalculateFibonacci = new Button();
            lblFibonacciResult = new Label();
            SuspendLayout();
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(36, 152);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(145, 23);
            btnCalculateFactorial.TabIndex = 0;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(36, 56);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(145, 23);
            txtInput.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(36, 110);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result:";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(232, 56);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(147, 23);
            txtArrayInput.TabIndex = 3;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(232, 110);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(42, 15);
            lblSumResult.TabIndex = 4;
            lblSumResult.Text = "Result:";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(232, 152);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(147, 23);
            btnCalculateSum.TabIndex = 5;
            btnCalculateSum.Text = "Array Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(431, 56);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(139, 23);
            txtFibonacciInput.TabIndex = 6;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(431, 152);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(139, 23);
            btnCalculateFibonacci.TabIndex = 7;
            btnCalculateFibonacci.Text = "Calculate Fibonacci";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(431, 110);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(42, 15);
            lblFibonacciResult.TabIndex = 8;
            lblFibonacciResult.Text = "Result:";
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(602, 245);
            Controls.Add(lblFibonacciResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(txtFibonacciInput);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnCalculateFactorial);
            Name = "Task1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Week 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateFactorial;
        private TextBox txtInput;
        private Label lblResult;
        private TextBox txtArrayInput;
        private Label lblSumResult;
        private Button btnCalculateSum;
        private TextBox txtFibonacciInput;
        private Button btnCalculateFibonacci;
        private Label lblFibonacciResult;
    }
}

namespace lab2
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * RecursiveFactorial(n - 1);
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial of {number} is {result}";

        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";

        }


        public int RecursiveFibonacci(int n)
        {
            if (n <= 1) return n;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtFibonacciInput.Text);
            int result = RecursiveFibonacci(number);
            lblFibonacciResult.Text = $"Fibonacci of {number} is {result}";
        }
    }
}

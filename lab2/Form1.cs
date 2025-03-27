namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);

        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);

        }

        private void btnFactorialCalculate_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtFactInput.Text);
            int result = RecursiveFactorial(number);
            listbox_factResult.Items.Add("Factorial Result: " + result);

        }

        private void btnSumCalculate_Click(object sender, EventArgs e)
        {
            int[] number = txtSumInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(number, number.Length - 1);
            listbox_sumResult.Items.Add("Sum Result: " + result);
        }

        private void btnFactClear_Click(object sender, EventArgs e)
        {
            txtFactInput.Clear();
            listbox_factResult.Items.Clear();
        }

        private void btnSumClear_Click(object sender, EventArgs e)
        {
            txtSumInput.Clear();
            listbox_sumResult.Items.Clear();
        }
    }
}

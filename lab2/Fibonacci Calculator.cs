using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Fibonacci_Calculator : Form
    {
        public Fibonacci_Calculator()
        {
            InitializeComponent();
        }
        private int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void btnFiboCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtFiboInput.Text);
                if (n < 0)
                {
                    MessageBox.Show("Please enter a non-negative integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int result = Fibonacci(n);

                FiboResult.Items.Add($"The {n}th Fibonacci number is: {result}");
                // MessageBox.Show($"The {n}th Fibonacci number is: {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFiboInput.Clear();
        }
    }
}

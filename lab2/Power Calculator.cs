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
    public partial class Power_Calculator : Form
    {
        public Power_Calculator()
        {
            InitializeComponent();
        }

        private long Power(int @base, int exponent)
        {
            if (exponent == 0) return 1;


            return @base * Power(@base, exponent - 1);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int baseNum = Convert.ToInt32(txtBaseInput.Text);
                int exponent = Convert.ToInt32(txtExpoInput.Text);

                if (exponent < 0)
                {
                    MessageBox.Show("Please enter a non-negative integer for the exponent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long result = Power(baseNum, exponent);

                PowerResult.Items.Add($"Result: " + result);
                // MessageBox.Show($"{baseNum}^{exponent} = {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBaseInput.Clear();
            txtExpoInput.Clear();
        }
    }
}

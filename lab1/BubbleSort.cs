using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class BubbleSort : Form
    {
        public BubbleSort()
        {
            InitializeComponent();
        }

        private void BubbleSorting(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {

                string input = InputNumber.Text;
                string[] stringArray = input.Split(',');
                int[] numbers = Array.ConvertAll(stringArray, int.Parse);

                BubbleSorting(numbers);

                listBoxSortResult.Items.Clear();
                listBoxSortResult.Items.Add("Sorted Result:");
                foreach (int number in numbers)
                {
                    listBoxSortResult.Items.Add("\t " + number);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid integers. Sample '3,2,1,4,5'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InputNumber.Clear();
            listBoxSortResult.Items.Clear();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursion_Tutorial
{
    public partial class Sum_of_an_array_sequence : Form
    {
        public Sum_of_an_array_sequence()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sum_of_an_array_sequence_Load(object sender, EventArgs e)
        {

        }

        private void labelSumText_Click(object sender, EventArgs e)
        {

        }

        private void textBoxArraySequence_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResultArraySequence_Click(object sender, EventArgs e)
        {
            int[] array = textBoxArraySequence.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = Sum(array, 0);
            labelResultSum.Text = sum.ToString();
        }
        static int Sum(int[] array, int index)
        {
            if (index >= array.Length)
            {
                return 0;
            }
            return array[index] + Sum(array, index + 1);
        }

        private void buttonClearSumArray_Click(object sender, EventArgs e)
        {
            textBoxArraySequence.Text = "";
            labelResultSum.Text = "";
        }
    }
}

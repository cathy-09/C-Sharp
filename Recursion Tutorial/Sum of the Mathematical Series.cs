using System;
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
    public partial class Sum_of_the_Mathematical_Series : Form
    {
        public Sum_of_the_Mathematical_Series()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sum_of_the_Mathematical_Series_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMathSeries_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBoxXForSeries.Text);
            int n = int.Parse(textBoxNForSeries.Text);
            int resultSum = SpecialMathSeries(x, n);
            labelSumMathSeries.Text = resultSum.ToString();
        }
        public static int SpecialMathSeries(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return MyPow(x, n) + SpecialMathSeries(x, n - 1);
        }
        private static int MyPow(int num, int rise)
        {
            int result = 1;
            for (int i = 0; i < rise; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}

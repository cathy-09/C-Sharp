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
    public partial class Fibonacci_sequence : Form
    {
        public Fibonacci_sequence()
        {
            InitializeComponent();
        }

        private void buttonResultFibSequ_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxEnterN.Text);
            long fibonacci = Fibonacci(n);
            labelOutputResultFibonacciSequence.Text = fibonacci.ToString();
        }
        public static long Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

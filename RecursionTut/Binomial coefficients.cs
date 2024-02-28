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
    public partial class Binomial_coefficients : Form
    {
        public Binomial_coefficients()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Binomial_coefficients_Load(object sender, EventArgs e)
        {

        }

        private void labelResultTextBinomialCoefficient_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResultBinomialCoefficient_Click(object sender, EventArgs e)
        {

        }

        private void buttonResultBinomialCoefficient_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxN.Text);
            int k = int.Parse(textBoxK.Text);
            int binomialCoefficient = BinomialCoefficient(n, k);
            labelResultBinomialCoefficient.Text = binomialCoefficient.ToString();
        }
        static int BinomialCoefficient(int n, int k)
        {
            if (k > n)
            {
                return 0;
            }
            if (k == 0 || k == n)
            {
                return 1;
            }
            return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
        }

        private void buttonClearBinom_Click(object sender, EventArgs e)
        {
            textBoxN.Text = "";
            textBoxK.Text = "";
            labelResultBinomialCoefficient.Text = "";
        }
    }
}

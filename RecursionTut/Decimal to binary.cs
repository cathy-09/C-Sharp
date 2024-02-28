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
    public partial class Decimal_to_binary : Form
    {
        public Decimal_to_binary()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBinaryResult_Click(object sender, EventArgs e)
        {
            int decimalToBinary = int.Parse(textBoxEnterDecimal.Text);
            int binary = DecimalToBinary(decimalToBinary);
            labelBinaryResult.Text = binary.ToString();
        }
        static int DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
            {
                return 0;
            }
            return (decimalNumber % 2 + 10 * DecimalToBinary(decimalNumber / 2));
        }

        private void Decimal_to_binary_Load(object sender, EventArgs e)
        {

        }

        private void labelTextBinaryNumber_Click(object sender, EventArgs e)
        {

        }

        private void labelBinaryResult_Click(object sender, EventArgs e)
        {
        }

        private void buttonClearDecToBinary_Click(object sender, EventArgs e)
        {
            textBoxEnterDecimal.Text = "";
            labelBinaryResult.Text = "";
        }
    }
}

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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void Factorial_Load(object sender, EventArgs e)
        {

        }

        private void labelTextFactorial_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEnterN_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResultFactorial_Click(object sender, EventArgs e)
        {

        }
        private static long GetFactorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }

        private void buttonResultNFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxEnterN.Text);
            long factorial = GetFactorial(number);
            labelResultFactorial.Text = factorial.ToString();
        }

        private void buttonClearFact_Click(object sender, EventArgs e)
        {
            textBoxEnterN.Text = "";
            labelResultFactorial.Text = "";
        }
    }
}

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
    public partial class Minimum_element : Form
    {
        public Minimum_element()
        {
            InitializeComponent();
        }

        private void Minimum_element_Load(object sender, EventArgs e)
        {

        }

        private void buttonMinimumElementResult_Click(object sender, EventArgs e)
        {
            double[] array = textBoxArraySequenceDouble.Text.Split(new char[] { ' ', ';' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            double minimumElement = FindMinimumElement(array, array.Length);
            labelResultMimimumElement.Text = minimumElement.ToString();
        }
        static double FindMinimumElement(double[] array, int n)
        {
            if (n == 1)
            {
                return array[0];
            }
            if (array[n - 1] < FindMinimumElement(array, n - 1))
            {
                return array[n - 1];
            }
            else
            {
                return FindMinimumElement(array, n - 1);
            }
        }

        private void buttonClearMinElement_Click(object sender, EventArgs e)
        {
            textBoxArraySequenceDouble.Text = "";
            labelResultMimimumElement.Text = "";
        }
    }
}

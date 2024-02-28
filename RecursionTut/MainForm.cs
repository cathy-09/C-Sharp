using System.Diagnostics;
using System.Security;
using System.Text;

namespace Recursion_Tutorial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnectToFile_Click(object sender, EventArgs e)
        {
            listBoxInfoFromTxt.Visible = true;
            string filePath = "DocumentationLink.txt";
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    listBoxInfoFromTxt.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            openFileDialog1.Filter = "Word documents|*.docx|PDF|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath1 = openFileDialog1.FileName.Split('\\').ToArray();
                    var processWord = filePath1.ElementAt(filePath1.Length - 1);
                    using (Stream stream = openFileDialog1.OpenFile())
                    {
                        Process.Start(new ProcessStartInfo(processWord) { UseShellExecute = true });
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error: {ex.Message}\n\n{ex.StackTrace}");
                }
            }
            if (listBoxInfoFromTxt.Items.Count > 0)
            {
                listBoxInfoFromTxt.Items.Clear();
            }
        }

        private void linkLabelDocumentation_LinkClicked(object sender, EventArgs e)
        {
        }

        private void buttonFibonacciSequence_Click(object sender, EventArgs e)
        {
            Fibonacci_sequence fibonacciSequence = new Fibonacci_sequence();
            fibonacciSequence.Show();
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            Factorial factorial = new Factorial();
            factorial.Show();
        }

        private void buttonBinomialCoefficients_Click(object sender, EventArgs e)
        {
            Binomial_coefficients binomialCoefficients = new Binomial_coefficients();
            binomialCoefficients.Show();
        }

        private void buttonSumArray_Click(object sender, EventArgs e)
        {
            Sum_of_an_array_sequence sumOfAnArraySequence = new Sum_of_an_array_sequence();
            sumOfAnArraySequence.Show();
        }

        private void buttonMinimum_Click(object sender, EventArgs e)
        {
            Minimum_element minimumElement = new Minimum_element();
            minimumElement.Show();
        }

        private void buttonDecimalToBinary_Click(object sender, EventArgs e)
        {
            Decimal_to_binary decimalToBinary = new Decimal_to_binary();
            decimalToBinary.Show();
        }

        private void buttonSumMathSeries_Click(object sender, EventArgs e)
        {
            Sum_of_the_Mathematical_Series sumOfTheMathematicalSeries = new Sum_of_the_Mathematical_Series();
            sumOfTheMathematicalSeries.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Fibonacci_sequence fibonacciSequence = new Fibonacci_sequence();
            fibonacciSequence.Close(); 
            Factorial factorial = new Factorial();
            factorial.Close();
            Binomial_coefficients binomialCoefficients = new Binomial_coefficients();
            binomialCoefficients.Close();
            Sum_of_an_array_sequence sumOfAnArraySequence = new Sum_of_an_array_sequence();
            sumOfAnArraySequence.Close();
            Minimum_element minimumElement = new Minimum_element();
            minimumElement.Close();
            Decimal_to_binary decimalToBinary = new Decimal_to_binary();
            decimalToBinary.Close();
            Sum_of_the_Mathematical_Series sumOfTheMathematicalSeries = new Sum_of_the_Mathematical_Series();
            sumOfTheMathematicalSeries.Close();
        }
    }
}


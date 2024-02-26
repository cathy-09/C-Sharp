namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            int p = int.Parse(textBoxP.Text);
            int q = int.Parse(textBoxQ.Text);
            int n = richTextBoxData.Lines.Count();
            int[] array = new int[n]; 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(richTextBoxData.Lines[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= p && array[i] <= q)
                {
                    array[i] = int.Parse(richTextBoxData.Lines[i]);
                    int sum = Sum(array);
                    labelSumResult.Text = sum.ToString();
                    int count = Count(array);
                    labelCountResult.Text = count.ToString();
                    int min = Min(array);
                    labelMinimum.Text = min.ToString();
                    int max = Max(array);
                    labelMaximum.Text = max.ToString();                    
                }
            }
            //if (array[i] >= p && array[i] <= q)
            //{
                double average = Average(array);
                labelAverageResult.Text = average.ToString();
                int[] sortedArray = Sort(array);
                string sortedString = string.Join(", ", sortedArray);
                labelSortResult.Text = sortedString;
            //}
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxData.Text = "";
            textBoxP.Text = "";
            textBoxQ.Text = "";
            labelSumResult.Text = "";
            labelCountResult.Text = "";
            labelMinimum.Text = "";
            labelMaximum.Text = "";
            labelAverageResult.Text = "";
            labelSortResult.Text = "";
        }

        private int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        private int Count(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
            }
            return count;
        }
        private int Min(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        private int Max(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        private double Average(int[] array)
        {
            int sum = Sum(array);
            int count = Count(array);
            double average = 0d;
            average =+ sum / count;
            return average;
        }
        private int[] Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            { 
                for (int j = 0; j < n - i - 1; j++)
                { 
                    if (array[j] > array[j + 1])
                    {
                        int tempVar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempVar;
                    }
                }
            }
            return array;
        }
    }
}
namespace Average
{
    public partial class Form1 : Form
    {
        ComboBox[] marks = new ComboBox[15];
        Label[] subjects = new Label[15];
        string[] names = {"БЕЛ", "Първи ЧЕ", "Втори ЧЕ", "Математика"
        , "Информатика", "ИТ", "История", "География", "Философия", "Биология"
        , "Физика", "Химия", "Музика", "ИИ", "ФВС"};
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                subjects[i] = new Label();
                subjects[i].Parent = this;
                subjects[i].Top = 70 + (i % 8) * 50;
                subjects[i].Left = (i / 8) * 150 + 50;
                subjects[i].Text = names[i];
                subjects[i].AutoSize = true;
            }
            for (int i = 0; i < 15; i++)
            {
                marks[i] = new ComboBox();
                marks[i].Parent = this;
                marks[i].Width = 100;
                marks[i].Height = 25;
                marks[i].Top = subjects[i].Top + 20;
                marks[i].Left = subjects[i].Left;

                for (int j = 2; j <= 6; j++)
                {
                    marks[i].Items.Add(j);
                }

                if (i == 14)
                {
                    marks[i].Items.Add("освободен");
                }
                marks[i].DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void buttonAverageGrade_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int numberOfSubject = 14;
            for (int i = 0; i < 14; i++)
            {
                sum += int.Parse(marks[i].Text);
            }
            if (marks[14].Text != "освободен")
            {
                sum += int.Parse(marks[14].Text);
                numberOfSubject = 15;
            }

            double average = (double)sum / numberOfSubject; 
            textBoxResultAverage.Text = Math.Round(average, 2).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResultAverage.Text = "";
        }
    }
}
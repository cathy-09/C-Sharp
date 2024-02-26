using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace school_1
{
    public partial class Form1 : Form
    {
        static List<Person> people = new List<Person>();
        static List<Student> students = new List<Student>();
        static List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void gBPosition_Enter(object sender, EventArgs e)
        {

        }

        private void rdBStudent_CheckedChanged(object sender, EventArgs e)
        {
            gBStudent.Visible = true;
            gpBEmployee.Visible = false;
            btnInput.Visible = true;
            pBSchool.Visible = true;
            lblEmployeeName.Visible = true;
            lblStudentName.Visible = true;
            lBEmployee.Visible = true;
            lBStudent.Visible = true;
            btnLoad.Visible = true;
            lblEGNSearch.Visible = true;
            txtBSearchedEGN.Visible = true;
            btnSearch.Visible = true;
            txtBNameStudent.Enabled = true;
            txtBEGNStudent.Enabled = true;
            txtBClassStudent.Enabled = true;
            txtBParalelkaStudent.Enabled = true;
            rbMaleStudent.Enabled = true;
            rbWomenStudent.Enabled = true;
        }

        private void rdBEmployee_CheckedChanged(object sender, EventArgs e)
        {
            gBStudent.Visible = false;
            gpBEmployee.Visible = true;
            btnInput.Visible = true;
            pBSchool.Visible = true;
            lblEmployeeName.Visible = true;
            lblStudentName.Visible = true;
            lBEmployee.Visible = true;
            lBStudent.Visible = true;
            btnLoad.Visible = true;
            lblEGNSearch.Visible = true;
            txtBSearchedEGN.Visible = true;
            btnSearch.Visible = true;
            txtBNameEmployee.Enabled = true;
            txtBEGNEmployee.Enabled = true;
            txtBPositionEmployee.Enabled = true;
            txtBExperienceEmployee.Enabled = true;
            rbMaleEmployee.Enabled = true;
            rbWomanEmployee.Enabled = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gBEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void gpBEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (rdBStudent.Checked)
            {
                //Валидация за подсигуряване на бутона "Въведи", не може да се изпускат полета
                if (string.IsNullOrEmpty(txtBNameStudent.Text)
                    || string.IsNullOrEmpty(txtBEGNStudent.Text)
                    || string.IsNullOrEmpty(txtBClassStudent.Text)
                    || string.IsNullOrEmpty(txtBParalelkaStudent.Text)
                    || (!rbMaleStudent.Checked && !rbWomenStudent.Checked))
                {
                    MyClear();
                    return;
                }
                string name = txtBNameStudent.Text;
                string egn = txtBEGNStudent.Text;
                string studentGrade = txtBClassStudent.Text;
                string clas = txtBParalelkaStudent.Text;
                string gender = "";
                if (rbMaleStudent.Checked)
                {
                    gender = "мъж";
                }
                if (rbWomenStudent.Checked)
                {
                    gender = "жена";

                }
                Person student = new Student(name, egn, studentGrade, clas, gender);
                Student studentList = new Student(name, egn, studentGrade, clas, gender);
                string infoStudent = student.Info();
                students.Add(studentList);
                using (StreamWriter writer = new StreamWriter("Data.txt", true))
                {
                    writer.Write(infoStudent + "\n");
                }
            }
            else
            {
                //Валидация за подсигуряване на бутона "Въведи", не може да се изпускат полета
                if (string.IsNullOrEmpty(txtBNameEmployee.Text)
                    || string.IsNullOrEmpty(txtBEGNEmployee.Text)
                    || string.IsNullOrEmpty(txtBPositionEmployee.Text)
                    || string.IsNullOrEmpty(txtBExperienceEmployee.Text)
                    || (!rbMaleEmployee.Checked && !rbWomanEmployee.Checked))
                {
                    MyClear();
                    return;
                }
                string name = txtBNameEmployee.Text;
                string egn = txtBEGNEmployee.Text;
                string position = txtBPositionEmployee.Text;
                int experience = int.Parse(txtBExperienceEmployee.Text);
                string gender = "";
                if (rbMaleEmployee.Checked)
                {
                    gender = "мъж";
                }
                if (rbWomanEmployee.Checked)
                {
                    gender = "жена";
                }
                Person employee = new Employee(name, egn, position, experience, gender);
                Employee employeeList = new Employee(name, egn, position, experience, gender);
                string infoEmployee = employee.Info();
                employees.Add(employeeList);
                using (StreamWriter writer = new StreamWriter("Data.txt", true))
                {
                    writer.Write(infoEmployee + "\n");
                }
            }
            MyClear();
        }
        private void MyClear()
        {
            if (rdBStudent.Checked)
            {
                txtBNameStudent.Clear();
                txtBEGNStudent.Clear();
                txtBClassStudent.Clear();
                txtBParalelkaStudent.Clear();
                rbMaleStudent.Checked = false;
                rbWomenStudent.Checked = false;
            }
            else
            {
                txtBNameEmployee.Clear();
                txtBEGNEmployee.Clear();
                txtBPositionEmployee.Clear();
                txtBExperienceEmployee.Clear();
                rbMaleEmployee.Checked = false;
                rbWomanEmployee.Checked = false;
            }
        }

        private void lBStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lBEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            people.Clear();
            lBStudent.Items.Clear();
            lBEmployee.Items.Clear();
            using (StreamReader reader = new StreamReader("Data.txt", true))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    List<string> args = line.Split(' ').ToList();
                    if (args.Last() == "ученик")
                    {
                        string name = args[0];
                        string egn = args[1];
                        string studentGrade = args[2];
                        string clas = args[3];
                        string gender = args[4];
                        Person person = new Student(name, egn, studentGrade, clas, gender);
                        Student student = new Student(name, egn, studentGrade, clas, gender);
                        students.Add(student);
                        people.Add(person);
                    }
                    else
                    {
                        string name = args[0];
                        string egn = args[1];
                        string position = args[2];
                        int experience = int.Parse(args[3]);
                        string gender = args[4];
                        Person person = new Employee(name, egn, position, experience, gender);
                        Employee employee = new Employee(name, egn, position, experience, gender);
                        employees.Add(employee);
                        people.Add(person);
                    }
                    line = reader.ReadLine();
                }
            }
            foreach (var item in people)
            {
                if (item.Type == "student")
                {
                    lBStudent.Items.Add(item.Name);
                }
                else
                {
                    lBEmployee.Items.Add(item.Name);
                }
            }
        }

        private void lblEGNSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pBSchool.Visible = false;
            lblEmployeeName.Visible = false;
            lblStudentName.Visible = false;
            lBEmployee.Visible = false;
            lBStudent.Visible = false;
            btnLoad.Visible = false;
            bool flag = false;
            foreach (var student in students)
            {
                if (txtBSearchedEGN.Text == student.EGN)
                {
                    MessageBox.Show($"Ученик: {student.Name}\n" +
                        $"ЕГН: {student.EGN}\n" +
                        $"Клас: {student.Grade}\n" +
                        $"Паралелка: {student.Clas}\n" +
                        $"Пол: {student.Gender}");
                    flag = true;
                    return;
                }
            }
            foreach (var employee in employees)
            {
                if (txtBSearchedEGN.Text == employee.EGN)
                {
                    MessageBox.Show($"Служител: {employee.Name}\n" +
                        $"ЕГН: {employee.EGN}\n" +
                        $"Позиция: {employee.Position}\n" +
                        $"Трудов стаж: {employee.Experience}\n" +
                        $"Пол: {employee.Gender}");
                    flag = true;
                    return;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Лице с такова ЕГН не съществува.");
            }
        }
    }
}
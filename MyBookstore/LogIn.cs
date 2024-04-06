using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyBookstore
{
    public partial class LogIn : Form
    {
        /// <summary>
        /// Create a global list 
        /// </summary>
        List<UserData> logIn;

        /// <summary>
        /// Create an instance for Log in
        /// </summary>
        public LogIn()
        {
            InitializeComponent();
            logIn = new List<UserData>();
        }

        /// <summary>
        /// Get username text
        /// </summary>
        public string GetTextBoxText()
        {
            return textBoxUsername.Text;
        }

        /// <summary>
        /// Close current form
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Read from existing file
        /// Check for valid registration
        /// Extract ages from egn
        /// Navigate to other forms
        /// </summary>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            int age = 0;

            using (StreamReader reader = new StreamReader("DataUsers.txt", true))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    List<string> args = line.Split(' ').ToList();

                    if (textBoxUsername.Text.Equals(args[5]) && textBoxPassword.Text.Equals(args[6]))
                    {
                        UserData userData = new UserData(args[5], args[6]);
                        logIn.Add(userData);
                        age = CalculateAge(args[3]);
                        break;
                    }

                    line = reader.ReadLine();
                }
            }
            if (age <= 12)
            {
                string textFromTextBox = GetTextBoxText();
                ChildrenForm childrenForm = new ChildrenForm(textFromTextBox);
                childrenForm.Show();
            }
            else if (age > 12 && age < 18)
            {
                string textFromTextBox = GetTextBoxText();
                TeenagersForm teenagersForm = new TeenagersForm(textFromTextBox);
                teenagersForm.Show();
            }
            else
            {
                string textFromTextBox = GetTextBoxText();
                AdultsForm adultsForm = new AdultsForm(textFromTextBox);
                adultsForm.Show();
            }

        }

        /// <summary>
        /// Calculate ages according to a given egn
        /// </summary>
        /// <param name="egn"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static int CalculateAge(string egn)
        {
            if (string.IsNullOrEmpty(egn) || egn.Length != 10)
            {
                throw new ArgumentException("Невалидно ЕГН!");
            }

            string year = egn.Substring(0, 2);
            string month = egn.Substring(2, 2);
            string day = egn.Substring(4, 2);
            int intMonth = 0, intDay = int.Parse(day);

            string century = "";

            if (month.CompareTo("40") > 0)
            {
                century = "20";
                intMonth = int.Parse(month) - 40;
            }

            else
            {
                century = "19";
                intMonth = int.Parse(month);
            }

            DateTime birthDate = new DateTime(int.Parse(century + year), intMonth, intDay);
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }
    }
}

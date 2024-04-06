using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.DataFormats;
using System.Reflection.Emit;

namespace MyBookstore
{
    public partial class AdultsForm : Form
    {
        /// <summary>
        /// Take text from textBox controls for username
        /// and and assigns a value to a label
        /// </summary>
        /// <param name="labelText"></param>
        public AdultsForm(string labelText)
        {
            InitializeComponent();
            labelUser.Text = labelText;
        }

        /// <summary>
        /// Part 1
        /// Read from existing file
        /// Check for valid username
        /// Extract ages from egn
        /// </summary>

        /// <summary>
        /// Part 2
        /// Iterates over selected science books
        /// extracts title and price
        /// Displays info and navigate to other form
        /// </summary>
        private void buttonFinalizeOrder_Click(object sender, EventArgs e)
        {
            //Part 1
            List<string> infoUser = new List<string>();
            int age = 0;

            using (StreamReader reader = new StreamReader("DataUsers.txt", true))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    List<string> args = line.Split(' ').ToList();

                    if (labelUser.Text.Equals(args[5]))
                    {
                        UserData userData = new UserData(args[0], args[1], args[2]);
                        string userDataInfo = userData.InfoUser();
                        infoUser.Add(userDataInfo);
                        age = CalculateAge(args[3]);
                        break;
                    }

                    line = reader.ReadLine();
                }
            }

            //Part 2
            List<string> listTitleBooks = new List<string>();
            List<decimal> listPriceBooks = new List<decimal>();

            foreach (string item in checkedListBoxScience.CheckedItems)
            {
                string[] bookInfo = item.Split('-');

                if (bookInfo.Length == 2)
                {
                    string bookName = bookInfo[0].Trim();
                    string priceStr = bookInfo[1].Trim();

                    priceStr = priceStr.Replace("лв.", "").Trim();

                    if (decimal.TryParse(priceStr, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.GetCultureInfo("bg-BG"), out decimal price))
                    {
                        listTitleBooks.Add(bookName);
                        listPriceBooks.Add(price);
                    }
                }
            }

            InfoForm infoForm = new InfoForm(listTitleBooks, listPriceBooks, infoUser, age);
            infoForm.Show();
        }

        /// <summary>
        /// Load data
        /// </summary>
        private void AdultsForm_Load(object sender, EventArgs e)
        {
            BindCheckedList();
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

        /// <summary>
        /// Insert data in checkedListBox
        /// </summary>
        private void BindCheckedList()
        {
            checkedListBoxScience.Items.Add("Да се взреш в слънцето - 12лв.");
            checkedListBoxScience.Items.Add("Материалният свят - 13лв.");
            checkedListBoxScience.Items.Add("Силата на ненасилието - 19лв.");
            checkedListBoxScience.Items.Add("Мръсни гени - 18лв.");
            checkedListBoxScience.Items.Add("Психология на личната сигурност - 20лв.");
            checkedListBoxScience.Items.Add("Песента на клетката - 17,99лв.");
            checkedListBoxScience.Items.Add("Съвременният човек в търсене на душа- 17,99лв.");
            checkedListBoxScience.Items.Add("Антология на ораторската реч - 27лв.");
            checkedListBoxScience.Items.Add("Ненаситната молекула на желанието - 18,99лв.");
            checkedListBoxScience.Items.Add("SQL решения на практически задачи- 17,99лв.");
        }
    }
}

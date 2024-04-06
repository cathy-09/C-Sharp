using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBookstore
{
    public partial class TeenagersForm : Form
    {
        /// <summary>
        /// Take text from textBox controls for username
        /// and and assigns a value to a label
        /// </summary>
        /// <param name="labelText"></param>
        public TeenagersForm(string labelText)
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

            foreach (string item in checkedListBoxRomance.CheckedItems)
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
        private void TeenagersForm_Load(object sender, EventArgs e)
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
            checkedListBoxRomance.Items.Add("Брулени хълмове - 15лв.");
            checkedListBoxRomance.Items.Add("Шах и мат - 19,99лв.");
            checkedListBoxRomance.Items.Add("Господар на гордостта - 21лв.");
            checkedListBoxRomance.Items.Add("Диамантеният залив - 12,90лв.");
            checkedListBoxRomance.Items.Add("Робиня на любовта - 9,90лв.");
            checkedListBoxRomance.Items.Add("Да се довериш на непознат - 15лв.");
            checkedListBoxRomance.Items.Add("Любовни престрелки - 17лв.");
            checkedListBoxRomance.Items.Add("Подарък от съдбата - 19лв.");
            checkedListBoxRomance.Items.Add("Пънк 57 - 19,90лв.");
            checkedListBoxRomance.Items.Add("Покварени - 25лв.");
        }
    }
}

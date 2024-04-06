using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyBookstore
{
    public partial class InfoForm : Form
    {
        /// <summary>
        /// Create private lists to take infos from other forms
        /// </summary>
        private List<string> orderedBooks;
        private List<decimal> price;
        private List<string> userInfo;
        private int age;

        /// <summary>
        /// Load datas in controls
        /// </summary>
        /// <param name="orderedBooks"></param>
        /// <param name="price"></param>
        /// <param name="userInfo"></param>
        /// <param name="age"></param>
        public InfoForm(List<string> orderedBooks, List<decimal> price, List<string> userInfo, int age)
        {
            InitializeComponent();
            this.orderedBooks = orderedBooks;
            this.price = price;
            this.userInfo = userInfo;
            this.age = age;
            decimal totalAmount = CalculateTotalPrice(price);
            labelPrice.Text = $"Цена: {totalAmount} лв.";
            foreach (string book in orderedBooks)
            {
                listBoxListBooks.Items.Add(book);
            }
            foreach (string user in userInfo)
            {
                listBoxInfoUser.Items.Add(user);
            }
            listBoxAge.Items.Add(age);
        }

        /// <summary>
        /// Calculate price
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        private decimal CalculateTotalPrice(List<decimal> prices)
        {
            decimal total = 0;
            foreach (decimal price in prices)
            {
                total += price;
            }
            return total;
        }

        /// <summary>
        /// Exit entire app
        /// </summary>
        private void buttonExitOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поръчката е приета. Благодарим ви!");
            Application.Exit();
        }
    }
}

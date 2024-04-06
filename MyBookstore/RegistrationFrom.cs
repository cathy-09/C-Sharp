using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
namespace MyBookstore
{
    public partial class RegistrationFrom : Form
    {
        /// <summary>
        /// Create a global list
        /// </summary>
        List<UserData> users;

        /// <summary>
        /// Create an instance for users
        /// </summary>
        public RegistrationFrom()
        {
            InitializeComponent();
            this.users = new List<UserData>();
        }

        /// <summary>
        /// Sign in logic
        /// Validation with Regular expression
        /// Work with files
        /// </summary>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string surname = textBoxSurname.Text;
            string lastName = textBoxLastName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string egn = textBoxEGN.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            bool isFirstNameValid = IsValidFirstName(firstName);
            bool isSurnameValid = IsValidSurname(surname);
            bool isLastNameValid = IsValidLastName(lastName);
            bool isPhoneNumberValid = IsValidPhoneNumber(phoneNumber);
            bool isEGNValid = IsValidEGN(egn);

            string message = "";

            if (!isFirstNameValid)
            {
                message += "Невалидно име.\n";
            }
            if (!isSurnameValid)
            {
                message += "Невалидно бащино име.\n";
            }
            if (!isLastNameValid)
            {
                message += "Невалидна фамилия.\n";
            }
            if (!isPhoneNumberValid)
            {
                message += "Невалиден телефонен номер.\n";
            }
            if (!isEGNValid)
            {
                message += "Невалидно ЕНГ.\n";
            }
            if (message == "")
            {
                message = "Всички данни са валидни.";
                UserData userData = new UserData(firstName, surname, lastName, egn, phoneNumber, username, password);
                string infoUsers = userData.Info();
                users.Add(userData);
                using (StreamWriter writer = new StreamWriter("DataUsers.txt", true))
                {
                    writer.Write(infoUsers + "\n");
                }
            }
            MessageBox.Show(message, "Валидация на данни", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForNewClientsUsers();
        }

        /// <summary>
        /// Valid first name
        /// </summary>
        static bool IsValidFirstName(string firstName)
        {
            string pattern = @"[A-Z][a-z]+";
            return Regex.IsMatch(firstName, pattern);
        }

        /// <summary>
        /// Valid surname
        /// </summary>
        static bool IsValidSurname(string surname)
        {
            string pattern = @"[A-Z][a-z]+";
            return Regex.IsMatch(surname, pattern);
        }

        /// <summary>
        /// Valid last name
        /// </summary>
        static bool IsValidLastName(string lastName)
        {
            string pattern = @"[A-Z][a-z]+";
            return Regex.IsMatch(lastName, pattern);
        }

        /// <summary>
        /// Valid phone number
        /// </summary>
        static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"[0]\d{9}";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        /// <summary>
        /// Valid eng with logic for real validation
        /// </summary>
        static bool IsValidEGN(string egn)
        {
            string pattern = @"\d{10}";
            if (Regex.IsMatch(egn, pattern))
            {
                int month = int.Parse(egn.Substring(2, 2));
                int year = int.Parse(egn.Substring(0, 2));
                return ((year > 24 && year <= 99) 
                    && (month >= 1 && month <= 12)) 
                    || ((year >= 00 && year <= 24) 
                    && (month >= 41 && month <= 52));
            }
            return false;
        }

        /// <summary>
        /// Navigate to Log in form
        /// </summary>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        /// <summary>
        /// Clear all controls for registration
        /// </summary>
        public void ClearForNewClientsUsers()
        {
            textBoxFirstName.Text = "";
            textBoxSurname.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxEGN.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        /// <summary>
        /// Close current form
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
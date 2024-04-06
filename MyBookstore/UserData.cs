using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookstore
{
    /// <summary>
    /// Add class UserData to save our clients in file
    /// </summary>
    public class UserData
    {
        /// <summary>
        /// Fields
        /// </summary>
        private string firstName;
        private string surname;
        private string lastName;
        private string egn;
        private string phoneNumber;
        private string username;
        private string password;

        /// <summary>
        /// base ctor
        /// </summary>
        public UserData()
        {

        }

        /// <summary>
        /// UserData ctor for Log in form
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public UserData(string username,
            string password)
        {
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// UserData ctor to extract data for Info Form
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="surname"></param>
        /// <param name="lastName"></param>
        public UserData(string firstName,
            string surname,
            string lastName)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.LastName = lastName;
        }

        /// <summary>
        /// UserData ctor to add data in file
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="surname"></param>
        /// <param name="lastName"></param>
        /// <param name="egn"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public UserData(string firstName,
            string surname,
            string lastName,
            string egn,
            string phoneNumber,
            string username,
            string password)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.LastName = lastName;
            this.Egn = egn;
            this.PhoneNumber = phoneNumber;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// properties
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Egn
        {
            get { return egn; }
            set { egn = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Method Info for entire information
        /// </summary>
        /// <returns></returns>
        public string Info()
        {
            return $"{this.FirstName} {this.Surname} {this.LastName} {this.Egn} {this.PhoneNumber} {this.Username} {this.Password}";
        }

        /// <summary>
        /// Method InfoUser for Info Form
        /// </summary>
        /// <returns></returns>
        public string InfoUser()
        {
            return $"{this.FirstName} {this.Surname} {this.LastName}";
        }
    }
}

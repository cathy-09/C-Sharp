using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_1
{
    public class Employee : Person
    {
        private string position;
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        private int experience;
        public int Experience
        {
            get { return this.experience; }
            set { this.experience = value; }
        }
        private string gender;
        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public Employee(string name, string egn, string position, int experience, string gender)
            : base(name, egn, "employee")
        {
            this.Position = position;
            this.Experience = experience;
            this.Gender = gender;
        }
        public override string Info()
        {
            return $"{this.Name} {this.EGN} {this.Position} {this.Experience} {this.Gender} служител";
        }
    }
}

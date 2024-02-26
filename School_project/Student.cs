using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_1
{
    public class Student : Person
    {
        //10a,10b, etc.
        private string grade;
        public string Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
        private string clas;

        public string Clas
        {
            get { return this.clas; }
            set { this.clas = value; }
        }
        private string gender;
        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public Student(string name, string egn, string studentGrade, string clas, string gender)
            : base(name, egn, "student")
        {
            this.Grade = studentGrade;
            this.Clas = clas;
            this.Gender = gender;
        }
        public override string Info()
        {
            return $"{this.Name} {this.EGN} {this.Grade} {this.Clas} {this.Gender} ученик";
        }
    }
}

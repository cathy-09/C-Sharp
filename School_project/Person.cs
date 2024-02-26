using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_1
{
    public abstract class Person
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        private string eGN;
        public string EGN
        {
            get { return this.eGN; }
            set { this.eGN = value; }
        }
        private string type;

        public string Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }
        public Person(string name, string egn, string type)
        {
            this.Name = name;
            this.EGN = egn;
            this.Type = type;
        }
        public abstract string Info();
    }
}

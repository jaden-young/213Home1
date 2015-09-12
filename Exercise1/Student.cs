using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public abstract class Student
    {
        private string name;
        public string Name
        {
            get;
            set;
        }

        protected Student(string name)
        {
            this.name = name;
        }

        public string toString()
        {
            return name;
        }
    }
}

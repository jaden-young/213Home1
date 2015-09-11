using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class UnderGraduate : Student
    {
        private string name;
        private string classification;
        private string guardianName;
        private string guardianAddress;

        public string Classification
        {
            get;
            set;
        }
        public string GuardianName
        {
            get;
            set;
        }

        public string GuardianAddress
        {
            get;
            set;
        }
    }
}

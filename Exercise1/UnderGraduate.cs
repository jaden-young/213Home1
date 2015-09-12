using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class UnderGraduate : Student
    {
        private string classification;
        private string guardianName;
        private string guardianAddress;

        public UnderGraduate(string name, 
                             string classification, 
                             string guardianName,
                             string guardianAddress) : base(name)
        {
            this.classification = classification;
            this.guardianName = guardianName;
            this.guardianAddress = guardianAddress;
            base.Name = name;
        }

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

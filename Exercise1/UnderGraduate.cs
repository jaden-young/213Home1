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
        private string[] classifications = {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"
        };
        private string guardianName;
        private string guardianAddress;

        public string Classification
        {
            get;
            set
            {
                foreach (string gradeYear in classifications)
                {
                    if (gradeYear.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        classification = value;
                        return;
                    }
                }
            }
        }

        public string guardianName
        {
            get;
            set;
        }

        public string guardianAddress
        {
            get;
            set;
        }
    }
}

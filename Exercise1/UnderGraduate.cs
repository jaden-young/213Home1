using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class UnderGraduate : Student
    {
      
        // name field is handled by Student base class
        public UnderGraduate(string name, 
                             string classification, 
                             string guardianName,
                             string guardianAddress) 
                             : base(name)
        {
            base.Name = name;
            this.Classification = classification;
            this.GuardianName = guardianName;
            this.GuardianAddress = guardianAddress;
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

        
        //Returns a printable string of the form:
        //Name:               John Doe
        //Classification:     Freshman
        //Guardian's name:    William Doe
        //Guardian's address: 1234 2nd Ave
        public new string toString()
        {
            return string.Format("{0, -20}: {1}\n" +
                                 "{2, -20}: {3}\n" +
                                 "{4, -20}: {5}\n" +
                                 "{6, -20}: {7}\n",
                                 "Name", Name,
                                 "Classification", Classification,
                                 "Guardian's Name", GuardianName, 
                                 "Guardian's Address", GuardianAddress);
        }
    }
}

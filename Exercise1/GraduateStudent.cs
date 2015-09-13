using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class GraduateStudent : Student
    {
        private string degree;
        private string institution;

        public GraduateStudent (string name,
                                string degree,
                                string institution)
                                : base(name)
        {
            base.Name = name;
            this.degree = degree;
            this.institution = institution;
        }

        public string Degree
        {
            get;
            set;
        }

        public string Institution
        {
            get;
            set;
        }

        public new string toString() {
            return String.Format("{0, -12}: {1}\n" +
                                 "{2, -12}: {3}\n" +
                                 "{4, -12}: {5}\n",
                                 "Name", Name,
                                 "Degree", Degree,
                                 "Institution", Institution);
        }
    }
}

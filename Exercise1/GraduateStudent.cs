using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class GraduateStudent : Student
    {
        private string name;
        private string degree;
        private string institution;

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
    }
}

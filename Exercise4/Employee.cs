using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Employee
    {
        // Name and Number are autoimplemented by properties
        private decimal rate;
        private decimal hours;
        private decimal pay;

        public Employee(string name, int number, decimal rate, decimal hours)
        {
            Name = name;
            Number = number;
            // Throw exception back up to caller
            try
            {
                Rate = rate;
            }
            catch
            {
                throw;
            }
            // Throw exception back up to caller
            try
            {
                Hours = hours;
            }
            catch
            {
                throw;
            }

            if (hours > 40)
            {
                pay = 40 * rate;
                pay += rate * 1.5M * (hours - 40);
            }
            else
            {
                pay = hours * rate;
            }
        }

        public string Name
        {
            get;
            set;
        }

        public int Number
        {
            get;
            set;
        }

        public decimal Rate
        {
            get
            {
                return rate;
            }
            set
            {
                if (value > 0)
                {
                    rate = value;
                }
                else
                {
                    throw new ArgumentException("ERROR: Pay rate must be a postive number.");
                }
            }
        }

        public decimal Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value > 0)
                {
                    hours = value;
                }
                else
                {
                    throw new ArgumentException("ERROR: Pay rate must be a positive number.");
                }
            }
        }

        public decimal Pay
        {
            get
            {
                return pay;
            }
            private set 
            {
                pay = value;
            }
        }
    }
}

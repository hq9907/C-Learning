using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_School
{
    internal class Person : IPersonService
    {
        List<string> Addresses = new List<string>();

        public int Age
        {
            get { return Age; }
            set
            {
                if (value > 0)
                    Age = value;
            }
        }

        public virtual decimal Salary
        {
            get { return Salary; }
            set
            {
                if (value > 0)
                    Salary = value;
            }
        }

        public void addAddress(string address)
        {
            Addresses.Append(address);
        }

        public string[] getAddresses()
        {
            return Addresses.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_School
{
    internal interface IPersonService
    {
        int Age { get; }
        decimal Salary { get; }
        void addAddress(string address);
        string[] getAddresses();
    }
}

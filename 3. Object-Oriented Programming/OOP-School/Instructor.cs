using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_School
{
    internal class Instructor : Person, IInstructorService
    {
        DateTime JoinDate;
        public Department Department { get; set; }

        public override decimal Salary 
        {
            get
            {
                return Salary + YearsOfExperience() * 1000;
            }
        }

        public int YearsOfExperience()
        {
            return (DateTime.Now - JoinDate).Days / 365;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_School
{
    internal class Student : Person, IStudentService
    {
        public List<(Course, Grade)> Grades { set; get; }

        public double GPA()
        {
            return Grades.Select((c, g) => g).Average();
        }
    }

    enum Grade { A, B, C, D, E, F }
}
